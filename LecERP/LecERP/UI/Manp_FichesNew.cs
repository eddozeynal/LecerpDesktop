using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.ObjectModel;
using DevExpress.XtraGrid.Views.Base;

namespace LecERP
{
    public partial class Manp_FichesNew : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        public bool IsEditMode { get; set; }

        Fiche Fiche_ = null;
        List<FicheLineView> Lines = null;
        List<ItemView> Items = null;
        List<ExchangeMaster> Exchanges = null;
        List<CardMasterView> Cards = null;
        List<WarehouseMaster> Warehouses = null;
        List<ItemPrice> ItemPrices = null;
        List<DocumentMaster> DocumentMasters = null;
        List<PriceCalcType> PriceCalcTypes = null;
        DocumentMaster currentDocumentType = null;
        public bool CreateInvoiceFromOrderFiche { get; set; }

        public byte DocTypeId { get; set; }

        public Manp_FichesNew()
        {
            InitializeComponent();
        }

        private void Manp_FichesNew_Load(object sender, EventArgs e)
        {

        }

        private void Manp_FichesNew_Shown(object sender, EventArgs e)
        {
            btnOk.Enabled =
                LookUpWarehouse.Enabled =
                lookUpItem.Enabled =
                cmbItemType.Enabled = btnAddLine.Enabled= IsEditMode;

            List<IBaseOperation> loadOperations = new List<IBaseOperation>();
            Operation<List<EnumMaster>> op_ItemTypes = OperationHandler.GetEnums(3);
            loadOperations.Add(op_ItemTypes);
            Operation<List<ItemView>> op_Items = OperationHandler.GetAllItems();
            loadOperations.Add(op_Items);
            Operation<List<ExchangeMaster>> op_ExchangeMaster = OperationHandler.GetAllExchanges();
            loadOperations.Add(op_ExchangeMaster);
            Operation<List<CardMasterView>> op_CardMaster = OperationHandler.GetAllCards();
            loadOperations.Add(op_CardMaster);
            Operation<List<WarehouseMaster>> op_Warehouses = OperationHandler.GetWarehouses();
            loadOperations.Add(op_Warehouses);
            Operation<List<ItemPrice>> op_ItemPrices = OperationHandler.GetItemPricesList();
            loadOperations.Add(op_ItemPrices);
            Operation<List<DocumentMaster>> op_DocumentMasters = OperationHandler.GetDocumentMasters();
            loadOperations.Add(op_DocumentMasters);
            Operation<List<PriceCalcType>> op_PriceCalcTypes = OperationHandler.GetPriceCalcTypes();
            loadOperations.Add(op_PriceCalcTypes);

            foreach (IBaseOperation ibop in loadOperations)
            {
                if (!ibop.Successful)
                {
                    SetError(ibop.Fail);
                    return;
                }
            }

            Items = op_Items.Value;
            Exchanges = op_ExchangeMaster.Value;
            Cards = op_CardMaster.Value;
            Warehouses = op_Warehouses.Value.Where(x=>x.Number != 0).ToList();
            ItemPrices = op_ItemPrices.Value;
            DocumentMasters = op_DocumentMasters.Value;
            PriceCalcTypes = op_PriceCalcTypes.Value;

            searchLookUpCard.Properties.View.AssignGridView(14); 
            
            lookUpExchange.Properties.DataSource = Exchanges;
            
            LookUpWarehouse.Properties.DataSource = Warehouses;
            if (DocTypeId != 0)
            {
                currentDocumentType = DocumentMasters.Where(x => x.Id == DocTypeId).FirstOrDefault();
                searchLookUpCard.Properties.DataSource = Cards.Where(x => x.CardType == currentDocumentType.CardType).ToList();
            }

            if (Id == 0)
            {
                Fiche_ = new Fiche();
                Lines = new List<FicheLineView>();
                LookUpWarehouse.ItemIndex = 0;
            }
            else
            {
                Operation<Fiche> op_ExistingFiche = OperationHandler.GetFicheById(Id);
                if (!op_ExistingFiche.Successful)
                {
                    SetError(op_ExistingFiche.Fail);
                    return;
                }
                Fiche_ = op_ExistingFiche.Value;
                DocTypeId = Fiche_.FicheMaster.DocTypeId;

                currentDocumentType = DocumentMasters.Where(x => x.Id == DocTypeId).FirstOrDefault();
                searchLookUpCard.Properties.DataSource = Cards.Where(x => x.CardType == currentDocumentType.CardType).ToList();

                searchLookUpCard.EditValue = Fiche_.FicheMaster.CardId;
                LookUpWarehouse.EditValue = Fiche_.FicheMaster.SourceWarehouse;
                lookUpExchange.EditValue = Fiche_.FicheMaster.ExchangeId;
                txtNote1.Text = Fiche_.FicheMaster.Note1;
                txtNote2.Text = Fiche_.FicheMaster.Note2;
                txtNote3.Text = Fiche_.FicheMaster.Note3;
                txtNote4.Text = Fiche_.FicheMaster.Note4;

                if (CreateInvoiceFromOrderFiche)
                {
                    Fiche_.FicheMaster.SourceDocument = Fiche_.FicheMaster.Ficheno;
            }

                txtSourceDoc.Text =Fiche_.FicheMaster.SourceDocument;

                Lines = new List<FicheLineView>();
                foreach (var line_ in Fiche_.FicheLines)
                {
                    FicheLineView ficheLineEditMode = line_.GetEligibleOjbect<FicheLineView>();
                    ficheLineEditMode.ItemCode = Items.Where(x => x.Id == ficheLineEditMode.ItemId).First().ItemCode;
                    ficheLineEditMode.ItemName = Items.Where(x => x.Id == ficheLineEditMode.ItemId).First().ItemName;
                    ficheLineEditMode.ItemTypeName = Items.Where(x => x.Id == ficheLineEditMode.ItemId).First().ItemTypeName;
                    Lines.Add(ficheLineEditMode);
                }

                gcLines.DataSource = null;
                gcLines.DataSource = Lines;
            }

            cmbItemType.SelectedIndex = 0;
           
        }
      

        private void Rle_ItemType_EditValueChanged(object sender, EventArgs e)
        {
            RefreshLines();
        }

        void RefreshLines()
        {
            gcLines.DataSource = Lines;
            gvLines.RefreshData();
        }


        private void Rse_ItemCode_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            gvLines.CloseEditor();
            RefreshLines();
        }

        private void Rse_ItemCode_EditValueChanged(object sender, EventArgs e)
        {
            //var v = gvLines.GetFocusedRow();
        }

        private void SetError(string fail,bool disableControls = true)
        {
            if (disableControls)
            {
                grpCenter.Enabled = false;
                btnOk.Enabled = false;
            }
            if (fail == null) fail = "Unknown Error";
            lblError.Text = "Error : " + fail;
            lblError.BackColor = Color.Red;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!IsEditMode) { Close(); return; }
            
            if (UIFunctions.CheckCancellation()) Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Fiche_.FicheLines = new List<FicheLine>();
            foreach (var line in Lines) Fiche_.FicheLines.Add(line);
            Fiche_.FicheMaster.CardId = Convert.ToInt32(searchLookUpCard.EditValue);
            Fiche_.FicheMaster.SourceWarehouse = Convert.ToInt32(LookUpWarehouse.EditValue);
            Fiche_.FicheMaster.CreatedBy = StaticData.CurrentUserId;
            Fiche_.FicheMaster.CreatedDate = DateTime.Now;
            Fiche_.FicheMaster.DocTypeId = DocTypeId;
            Fiche_.FicheMaster.ExchangeId = Convert.ToByte(lookUpExchange.EditValue);
            Fiche_.FicheMaster.Note1 = txtNote1.Text;
            Fiche_.FicheMaster.Note2 = txtNote2.Text;
            Fiche_.FicheMaster.Note3 = txtNote3.Text;
            Fiche_.FicheMaster.Note4 = txtNote4.Text;
            Fiche_.FicheMaster.SourceDocument = txtSourceDoc.Text;
           
            if (CreateInvoiceFromOrderFiche)
            {
                Fiche_.FicheMaster.DocTypeId = 2;
                Fiche_.FicheMaster.Id = 0;
            }
            Operation<Fiche> postedFiche = OperationHandler.PostFiche(Fiche_);

            if (postedFiche.Successful) this.Close();
            SetError(postedFiche.Fail,false);
        }

        private void searchLookUpCard_EditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpCard.EditValue == null) return;
            lookUpExchange.EditValue = Cards.Where(x => x.Id == (int)searchLookUpCard.EditValue).First().ExchangeId;
            lookUpItem.Enabled = true;
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lookUpItem.Properties.DataSource = Items.Where(x => x.ItemTypeId == cmbItemType.SelectedIndex + 1);
            lookUpItem.Properties.ValueMember = "Id";
            lookUpItem.Properties.DisplayMember = "ItemName";
        }

        private void lookUpItem_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpItem.EditValue == null) return;
            ItemView item = Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault();
            spHeight.Value = item.Height_;
            spWeight.Value = item.Weight_;
            spLength.Value = item.Length_;
            spWidth.Value = item.Width_;
            ItemPrice itemPrice = ItemPrices.Where
                (x => x.ItemId == Convert.ToInt32(lookUpItem.EditValue) && x.PriceTypeId == currentDocumentType.PriceType && x.CardId == Convert.ToInt32(searchLookUpCard.EditValue)
                ).FirstOrDefault();
            if (itemPrice == null)
            {
                itemPrice = ItemPrices.Where
                (x => x.ItemId == Convert.ToInt32(lookUpItem.EditValue) && x.PriceTypeId == currentDocumentType.PriceType
                ).FirstOrDefault();
            }
            if (itemPrice != null)
            {
                spPrice.Value = itemPrice.Price;
            }
            else
            {
                spPrice.Value = 0;
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (lookUpItem.EditValue == null) return;
            if (spPrice.Value == 0)
            {
                XtraMessageBox.Show("Məhsulun qiymətini daxil edin");
                return;
            }
            FicheLineView line = new FicheLineView();
            line.Amount = spAmount.Value;
            line.Height_ = spHeight.Value;
            line.ItemId = Convert.ToInt32(lookUpItem.EditValue);
            line.ItemName = Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault().ItemName;
            line.ItemTypeName = Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault().ItemTypeName;
            line.ItemCode = Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault().ItemCode;
            line.ItemTypeId = Convert.ToByte(cmbItemType.SelectedIndex);
            
            
            //line.LineNumber
            line.Weight_ = spWeight.Value;
            line.Width_ = spWidth.Value;
            line.Length_ = spLength.Value;
            line.LinePrice = spPrice.Value;

            //line.LineNetTotal = line.LinePrice * line.Amount;
            ItemView item = Items.Where(x => x.Id == line.ItemId).First();
            line.LineNetTotal = StaticData.CalculateItemTotal(item.PriceCalcTypeId, line.LinePrice, line.Amount, line.Width_, line.Length_, line.Height_);

            Lines.Add(line );
            Lines.ForEach(x => x.LineNumber = Lines.IndexOf(x) + 1);
            Lines = Lines.OrderBy(x => x.LineNumber).ToList();
            lookUpItem.EditValue = null;
            gcLines.DataSource = null;
            gcLines.DataSource = Lines;
        }

        private void gvLines_KeyDown(object sender, KeyEventArgs e)
        {
            if (!IsEditMode) return;
            if (e.KeyCode == Keys.Delete)
            {
                if (gvLines.GetFocusedRow() == null) return;
                DialogResult del = XtraMessageBox.Show("Silmək istədiyinizdən əminsinizmi?", "Sətir silinməsi", MessageBoxButtons.YesNo);
                if (del == DialogResult.Yes)
                {
                    FicheLineView currentLine = gvLines.GetFocusedRow() as FicheLineView;
                    Lines.Remove(currentLine);
                }
                Lines.ForEach(x => x.LineNumber = Lines.IndexOf(x) + 1);
                Lines = Lines.OrderBy(x => x.LineNumber).ToList();
                gcLines.DataSource = null;
                gcLines.DataSource = Lines;
            }
            if (e.Shift && e.KeyValue >= (int)Keys.A && e.KeyValue <= (int)Keys.Z)
            {
                if (gvLines.GetFocusedRow() == null) return;

                string keyString = ((char)(e.KeyValue + 32)).ToString();
                ItemView newItem = Items.Where(x => x.ShortcutKey.ToLower() == keyString.ToLower()).FirstOrDefault();
                if (newItem == null) return;


                FicheLineView currentLine = gvLines.GetFocusedRow() as FicheLineView;
                int index = Lines.IndexOf(currentLine);

                FicheLineView newLine = new FicheLineView();
               
                newLine.ItemId = newItem.Id;
                newLine.ItemName = newItem.ItemName;
                newLine.ItemTypeName = newItem.ItemTypeName;
                newLine.ItemCode = newItem.ItemCode;
                newLine.ItemTypeId = newItem.ItemTypeId;


                newLine.Amount = currentLine.Amount;
                if (newItem.PriceCalcTypeId != 1)
                {
                    newLine.Height_ = currentLine.Height_;
                    newLine.Weight_ = currentLine.Weight_;
                    newLine.Width_ = currentLine.Width_;
                    newLine.Length_ = currentLine.Length_;
                }

                ItemPrice itemPrice = ItemPrices.Where
               (x => x.ItemId == newItem.Id && x.PriceTypeId == currentDocumentType.PriceType && x.CardId == Convert.ToInt32(searchLookUpCard.EditValue)
               ).FirstOrDefault();
                if (itemPrice == null)
                {
                    itemPrice = ItemPrices.Where
                    (x => x.ItemId == newItem.Id && x.PriceTypeId == currentDocumentType.PriceType
                    ).FirstOrDefault();
                }
                if (itemPrice != null)
                {
                    newLine.LinePrice = itemPrice.Price;
                }
               
                newLine.LineNetTotal = StaticData.CalculateItemTotal(newItem.PriceCalcTypeId, newLine.LinePrice, newLine.Amount, newLine.Width_, newLine.Length_, newLine.Height_);

                Lines.Insert(index + 1, newLine);
                Lines.ForEach(x => x.LineNumber = Lines.IndexOf(x) + 1);
                Lines = Lines.OrderBy(x => x.LineNumber).ToList();
                gcLines.DataSource = null;
                gcLines.DataSource = Lines;
            }
        }
    }
}