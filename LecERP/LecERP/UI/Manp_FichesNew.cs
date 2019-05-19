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

        FicheMasterView Fiche = null;

        DataHolder dataHolder = null;

        DocumentMaster currentDocumentType = null;
        public bool CreateInvoiceFromOrderFiche { get; set; }

        public byte DocTypeId { get; set; }

        public Manp_FichesNew()
        {
            InitializeComponent();
        }

        private void Manp_FichesNew_Load(object sender, EventArgs e)
        {
            btnAddLine.Enabled = IsEditMode;
            btnOk.Enabled = IsEditMode;
            gvLines.Columns["Weight_"].Visible = spWeight.Visible = lblWeight.Visible = StaticData.weightVisible;
            gvLines.Columns["Height_"].Visible = spHeight.Visible = lblHeight.Visible = StaticData.heightVisible;
            gvLines.Columns["IsCompleted"].OptionsColumn.AllowEdit = StaticData.IsPermitted(34);
            if (StaticData.weightVisible == false || StaticData.heightVisible == false)
            {
                lblPrice.Left -= spPrice.Width;
                spPrice.Left -= spPrice.Width;
            }
            if (StaticData.weightVisible == false && StaticData.heightVisible == false)
            {
                lblPrice.Left -= spPrice.Width;
                spPrice.Left -= spPrice.Width;
            }
        }

        private void Manp_FichesNew_Shown(object sender, EventArgs e)
        {
            searchLookUpCard.Enabled =
                LookUpWarehouse.Enabled =
                lookUpItem.Enabled =
                cmbItemType.Enabled = btnAddLine.Enabled= IsEditMode;

            dataHolder = new DataHolder();
            IBaseOperation loadOper = dataHolder.LoadMasterData();
            if (!loadOper.Successful)
            {
                SetError(loadOper.Fail);
                return;
            }

            

            searchLookUpCard.Properties.View.AssignGridView(14); 
            
            lookUpExchange.Properties.DataSource = dataHolder.Exchanges;
            
            LookUpWarehouse.Properties.DataSource = dataHolder.Warehouses;
            if (DocTypeId != 0)
            {
                currentDocumentType = dataHolder.DocumentMasters.Where(x => x.Id == DocTypeId).FirstOrDefault();
                searchLookUpCard.Properties.DataSource = dataHolder.Cards.Where(x => x.CardTypeId == currentDocumentType.CardType).ToList();
            }

            if (Id == 0)
            {
                Fiche = new FicheMasterView();
                Fiche.FicheLines = new List<FicheLineView>();
                LookUpWarehouse.ItemIndex = 0;
            }
            else
            {
                Operation<FicheMasterView> op_ExistingFiche = OperationHandler.GetFicheById(Id);
                if (!op_ExistingFiche.Successful)
                {
                    SetError(op_ExistingFiche.Fail);
                    return;
                }
                Fiche = op_ExistingFiche.Value;
                DocTypeId = Fiche.DocTypeId;

                currentDocumentType = dataHolder.DocumentMasters.Where(x => x.Id == DocTypeId).FirstOrDefault();
                searchLookUpCard.Properties.DataSource = dataHolder.Cards.Where(x => x.CardTypeId == currentDocumentType.CardType).ToList();

                searchLookUpCard.EditValue = Fiche.CardId;
                LookUpWarehouse.EditValue = Fiche.SourceWarehouse;
                lookUpExchange.EditValue = Fiche.ExchangeId;
                txtNote1.Text = Fiche.Note1;
                txtNote2.Text = Fiche.Note2;
                txtNote3.Text = Fiche.Note3;
                txtNote4.Text = Fiche.Note4;

                if (CreateInvoiceFromOrderFiche)
                {
                    Fiche.SourceDocument = Fiche.Ficheno;
                }

                txtSourceDoc.Text =Fiche.SourceDocument;
                gvLines.Columns["IsCompleted"].OptionsColumn.AllowEdit = Fiche.Status_ == 2;
            }
            gcLines.DataSource = null;
            gcLines.DataSource = Fiche.FicheLines;
            cmbItemType.SelectedIndex = 0;
            RefreshCashTrans();
        }
      

        private void Rle_ItemType_EditValueChanged(object sender, EventArgs e)
        {
            RefreshLines();
        }

        void RefreshLines()
        {
            gcLines.DataSource = Fiche.FicheLines;
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
            Fiche.FicheLines.ForEach(x => x.Note = x.Note ?? string.Empty );
            Fiche.CardId = Convert.ToInt32(searchLookUpCard.EditValue);
            Fiche.SourceWarehouse = Convert.ToInt32(LookUpWarehouse.EditValue);
            if ( Id == 0 ) Fiche.CreatedBy = StaticData.CurrentUserId;
            if ( Id == 0 ) Fiche.CreatedDate = DateTime.Now;
            if (Id == 0) Fiche.Status_ = 1;
            Fiche.DocTypeId = DocTypeId;
            Fiche.ExchangeId = Convert.ToByte(lookUpExchange.EditValue);
            Fiche.Note1 = txtNote1.Text;
            Fiche.Note2 = txtNote2.Text;
            Fiche.Note3 = txtNote3.Text;
            Fiche.Note4 = txtNote4.Text;
            Fiche.SourceDocument = txtSourceDoc.Text;
           
            if (CreateInvoiceFromOrderFiche)
            {
                Fiche.DocTypeId = 2;
                Fiche.CreatedDate = DateTime.Now;
                Fiche.CreatedBy = StaticData.CurrentUserId;
                Fiche.Id = 0;
            }
            Operation<FicheMasterView> postedFiche = OperationHandler.PostFiche(Fiche);

            if (postedFiche.Successful) Close();
            SetError(postedFiche.Fail,false);
        }

        private void searchLookUpCard_EditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpCard.EditValue == null) return;
            lookUpExchange.EditValue = dataHolder.Cards.Where(x => x.Id == (int)searchLookUpCard.EditValue).First().ExchangeId;
            lookUpItem.Enabled = true;
            
            gcServices.DataSource = dataHolder.GetFicheLineServicesView((int)searchLookUpCard.EditValue);
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lookUpItem.Properties.DataSource = dataHolder.Items.Where(x => x.ItemTypeId == cmbItemType.SelectedIndex + 1);
            lookUpItem.Properties.ValueMember = "Id";
            lookUpItem.Properties.DisplayMember = "ItemName";
        }

        private void lookUpItem_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpItem.EditValue == null) return;
            ItemView item = dataHolder.Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault();
            spHeight.Value = item.Height_;
            spWeight.Value = item.Weight_;
            spLength.Value = item.Length_;
            spWidth.Value = item.Width_;
            ItemPrice itemPrice = dataHolder.ItemPrices.Where
                (x => x.ItemId == Convert.ToInt32(lookUpItem.EditValue) && x.PriceTypeId == currentDocumentType.PriceType && x.CardId == Convert.ToInt32(searchLookUpCard.EditValue)
                ).FirstOrDefault();
            if (itemPrice == null)
            {
                itemPrice = dataHolder.ItemPrices.Where
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
            if (spPrice.Value == 0 && currentDocumentType.PriceRequired)
            {
                XtraMessageBox.Show("Məhsulun qiymətini daxil edin");
                return;
            }
            FicheLineView line = new FicheLineView();
            line.Amount = spAmount.Value;
            line.Height_ = spHeight.Value;
            line.ItemId = Convert.ToInt32(lookUpItem.EditValue);
            line.ItemName = dataHolder.Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault().ItemName;
            line.ItemTypeName = dataHolder.Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault().ItemTypeName;
            line.ItemCode = dataHolder.Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault().ItemCode;
            line.ItemTypeId = Convert.ToByte(cmbItemType.SelectedIndex);

            line.Services = gvServices.GetSelectedRows<FicheLineServiceView>().DeepClone();


            foreach (var servLine in line.Services)
            {
                Item srvItem = dataHolder.Items.Where(x => x.Id == servLine.ServiceItemId).First();
                servLine.LineTotal = StaticData.CalculateItemTotal(srvItem.PriceCalcTypeId, servLine.ItemPrice, servLine.Amount, line.Width_, line.Length_, line.Height_);
                servLine.LineNetTotal = StaticData.CalculateItemTotal(srvItem.PriceCalcTypeId, servLine.LinePrice, servLine.Amount, line.Width_, line.Length_, line.Height_);
            }


            //line.LineNumber
            line.Weight_ = spWeight.Value;
            line.Width_ = spWidth.Value;
            line.Length_ = spLength.Value;
            line.LinePrice = spPrice.Value;

            //line.LineNetTotal = line.LinePrice * line.Amount;
            ItemView item = dataHolder.Items.Where(x => x.Id == line.ItemId).First();
            line.LineNetTotal = StaticData.CalculateItemTotal(item.PriceCalcTypeId, line.LinePrice, line.Amount, line.Width_, line.Length_, line.Height_);
            line.ServiceLineNetTotalSum = line.Services.Sum(x=>x.LineNetTotal);
            line.LineFinalSum = line.LineNetTotal + line.LineExpense + line.ServiceLineNetTotalSum;
            Fiche.FicheLines.Add(line );
            Fiche.FicheLines.ForEach(x => x.LineNumber = Fiche.FicheLines.IndexOf(x) + 1);
            Fiche.FicheLines = Fiche.FicheLines.OrderBy(x => x.LineNumber).ToList();
            lookUpItem.EditValue = null;
            RefreshLines();
            if (AppSettings.FichesManpServiceLinesClearCheckedRowsOnAddLine) gvServices.ClearSelection();
            
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
                    Fiche.FicheLines.Remove(currentLine);
                }
                Fiche.FicheLines.ForEach(x => x.LineNumber = Fiche.FicheLines.IndexOf(x) + 1);
                Fiche.FicheLines = Fiche.FicheLines.OrderBy(x => x.LineNumber).ToList();
                RefreshLines();
            }
            if (e.Shift && e.KeyValue >= (int)Keys.A && e.KeyValue <= (int)Keys.Z)
            {
                if (gvLines.GetFocusedRow() == null) return;

                string keyString = ((char)(e.KeyValue + 32)).ToString();
                ItemView newItem = dataHolder.Items.Where(x => x.ShortcutKey.ToLower() == keyString.ToLower()).FirstOrDefault();
                if (newItem == null) return;


                FicheLineView currentLine = gvLines.GetFocusedRow() as FicheLineView;
                int index = Fiche.FicheLines.IndexOf(currentLine);

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

                ItemPrice itemPrice = dataHolder.ItemPrices.Where
               (x => x.ItemId == newItem.Id && x.PriceTypeId == currentDocumentType.PriceType && x.CardId == Convert.ToInt32(searchLookUpCard.EditValue)
               ).FirstOrDefault();
                if (itemPrice == null)
                {
                    itemPrice = dataHolder.ItemPrices.Where
                    (x => x.ItemId == newItem.Id && x.PriceTypeId == currentDocumentType.PriceType
                    ).FirstOrDefault();
                }
                if (itemPrice != null)
                {
                    newLine.LinePrice = itemPrice.Price;
                }
               
                newLine.LineNetTotal = StaticData.CalculateItemTotal(newItem.PriceCalcTypeId, newLine.LinePrice, newLine.Amount, newLine.Width_, newLine.Length_, newLine.Height_);

                Fiche.FicheLines.Insert(index + 1, newLine);
                Fiche.FicheLines.ForEach(x => x.LineNumber = Fiche.FicheLines.IndexOf(x) + 1);
                Fiche.FicheLines = Fiche.FicheLines.OrderBy(x => x.LineNumber).ToList();
                RefreshLines();
            }
        }

        private void gvLines_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            FicheLineView vw = gvLines.GetFocusedRow() as FicheLineView;
            if (vw == null)
            {
                gcServicesOfLine.DataSource = null;
                return;
            }
            gcServicesOfLine.DataSource = vw.Services;
        }

        private void tsAddExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Dialog_DecimalInput ddi = new Dialog_DecimalInput();
            //ddi.Caption = "Xərclərin cəmini daxil edin";
            //ddi.ShowDialog();
            //if (ddi.IsOk)
            //{
            //    decimal acceptedValue = ddi.Value;
            //    decimal ficheLinesSum = Fiche.FicheLines.Sum(x=>x.LineNetTotal);
            //    foreach (var line in Fiche.FicheLines)
            //    {
            //        var linePerc = line.LineNetTotal / ficheLinesSum;
            //        line.LineExpense = Math.Round(acceptedValue * linePerc,2);
            //    }
            //}
            List<CashTransactionView> cashes = gcCashTrans.DataSource as List<CashTransactionView>;
            if (cashes == null) return;
            decimal acceptedValue = cashes.Sum(x => x.TotalMEx) ;
            decimal ficheLinesSum = Fiche.FicheLines.Sum(x => x.LineNetTotal);
            foreach (var line in Fiche.FicheLines)
            {
                var linePerc = line.LineNetTotal / ficheLinesSum;
                line.LineExpense = Math.Round(acceptedValue * linePerc, 2);
            }
            gcLines.RefreshDataSource();
        }

        private void btnAddCashTran_Click(object sender, EventArgs e)
        {
            if (Fiche.Id == 0)
            {
                XtraMessageBox.Show("Əvvəlcə Yaddaşa Yazın !");
                return;
            }
            Manp_CashTransaction cashTransaction = new Manp_CashTransaction(0,0,0,string.Empty,Fiche.Id,0);
            cashTransaction.ShowDialog();
            RefreshCashTrans();
        }

        private void RefreshCashTrans()
        {
            gcCashTrans.DataSource = OperationHandler.GetCashTransactionsViewByFiche(Id).Value;
        }
    }
}