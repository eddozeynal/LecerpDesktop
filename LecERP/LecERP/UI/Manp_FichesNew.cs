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
using LecERP.ViewModels;
using DevExpress.XtraGrid.Views.Grid;
using LecERP.Models;

namespace LecERP
{
    public partial class Manp_FichesNew : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        public bool IsEditMode { get; set; }
        FicheMasterView Fiche = new FicheMasterView();
        List<ItemPrice> itemPrices = null;
        bool isNew
        {
            get { return Id == 0; }
        }

        DataHolder dataHolder = null;

        public DocumentMaster DocumentType { get; set; }
        public bool CreateInvoiceFromOrderFiche { get; set; }

        DataObjectBindTool<FicheMasterView> bindTool = new DataObjectBindTool<FicheMasterView>();

        public Manp_FichesNew()
        {
            InitializeComponent();
            
        }

        private void Manp_FichesNew_Load(object sender, EventArgs e)
        {
            //gvLines.Columns["IsCompleted"].OptionsColumn.AllowEdit = StaticData.IsPermitted(34);
        }

        private void Manp_FichesNew_Shown(object sender, EventArgs e)
        {
            if (DocumentType.Id == 1 || DocumentType.Id == 2)
            {
                gvLines.Columns["LineExpense"].Visible = false;
            }
            else
            {
                gvLines.Columns["ServiceLineNetTotalSum"].Visible = false;
            }

            btnOk.Enabled = searchLookUpCard.Enabled =
                LookUpWarehouse.Enabled = IsEditMode;

            dataHolder = new DataHolder();
            IBaseOperation loadOper = dataHolder.LoadEnumData();
            if (!loadOper.Successful)
            {
                SetError(loadOper.Fail);
                return;
            }
            loadOper = dataHolder.LoadMasterData();
            if (!loadOper.Successful)
            {
                SetError(loadOper.Fail);
                return;
            }
            searchLookUpCard.Properties.DataSource = dataHolder.Cards;

            rpLookupItem.DataSource = dataHolder.Items;
            rpLookupItem.DisplayMember = "ItemName";
            rpLookupItem.ValueMember = "Id";
            LookUpWarehouse.Properties.DataSource = dataHolder.Warehouses;
            if (dataHolder.Warehouses.Count > 0) LookUpWarehouse.ItemIndex = 0;
            foreach (ItemView item in dataHolder.Items.Where(x => x.ItemTypeId == 2))
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem();
                menuItem.Tag = item.Id;
                menuItem.Text = item.ItemName;
                menuItem.Click += SrvBlukMenuItem_Click;
                tsBulkAddServices.DropDownItems.Add(menuItem);
            }
            




            if (isNew)
            {
                Fiche = new FicheMasterView();
                Fiche.Lines = new List<FicheLineView>();
                
            }



            else
            {
                //Operation<FicheMasterView> op_ExistingFiche = OperationHandler.GetFicheById(Id);
                //if (!op_ExistingFiche.Successful)
                //{
                //    SetError(op_ExistingFiche.Fail);
                //    return;
                //}
                //Fiche = op_ExistingFiche.Value;
                //DocTypeId = Fiche.DocTypeId;

                //currentDocumentType = dataHolder.DocumentMasters.Where(x => x.Id == DocTypeId).FirstOrDefault();
                //searchLookUpCard.Properties.DataSource = dataHolder.Cards.Where(x => x.CardTypeId == currentDocumentType.CardType).ToList();
                if (CreateInvoiceFromOrderFiche)
                {
                    Fiche.SourceDocument = Fiche.Ficheno;
                }
                bindTool.BindControl(searchLookUpCard, nameof(Fiche.CardId));
                bindTool.BindControl(LookUpWarehouse, nameof(Fiche.SourceWarehouse));
                bindTool.BindControl(txtNote1, nameof(Fiche.Note1));
                bindTool.BindControl(txtNote2, nameof(Fiche.Note2));
                bindTool.BindControl(txtNote3, nameof(Fiche.Note3));
                bindTool.BindControl(txtNote4, nameof(Fiche.Note4));
                bindTool.BindControl(txtSourceDoc, nameof(Fiche.SourceDocument));
                bindTool.DataObject = Fiche;
            }
            gcLines.DataSource = null;
            gcLines.DataSource = Fiche.Lines;
            // gcLines.DataSource = Fiche.FicheLines;
            //cmbItemType.SelectedIndex = 0;
            RefreshCashTrans();
           
        }

        private void SrvBlukMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            List<FicheLineView> selectedLines = gvLines.GetSelectedRows<FicheLineView>();
            foreach (var ficheLine in selectedLines)
            {
                foreach (var ficheLineService in ficheLine.LineServices.Where(x=>x.ServiceItemId == Convert.ToInt32(menuItem.Tag)))
                {
                    ficheLineService.Quantity = ficheLine.Quantity;
                }
                CheckLine(ficheLine,true);
            }
        }

        private void Rle_ItemType_EditValueChanged(object sender, EventArgs e)
        {
            RefreshLines();
        }

        void RefreshLines()
        {
            gcLines.DataSource = Fiche.Lines;
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
            refreshLineTotals();
            //Fiche.FicheLines.ForEach(x => x.Note = x.Note ?? string.Empty );
            //Fiche.CardId = Convert.ToInt32(searchLookUpCard.EditValue);
            //Fiche.SourceWarehouse = Convert.ToInt32(LookUpWarehouse.EditValue);
            //if ( Id == 0 ) Fiche.CreatedBy = StaticData.CurrentUserId;
            //if ( Id == 0 ) Fiche.CreatedDate = DateTime.Now;
            //if (Id == 0) Fiche.Status_ = 1;
            //Fiche.DocTypeId = DocTypeId;
            //Fiche.ExchangeId = Convert.ToByte(lookUpExchange.EditValue);
            //Fiche.Note1 = txtNote1.Text;
            //Fiche.Note2 = txtNote2.Text;
            //Fiche.Note3 = txtNote3.Text;
            //Fiche.Note4 = txtNote4.Text;
            //Fiche.SourceDocument = txtSourceDoc.Text;
           
            //if (CreateInvoiceFromOrderFiche)
            //{
            //    Fiche.DocTypeId = 2;
            //    Fiche.CreatedDate = DateTime.Now;
            //    Fiche.CreatedBy = StaticData.CurrentUserId;
            //    Fiche.Id = 0;
            //}
            //Operation<FicheMasterView> postedFiche = OperationHandler.PostFiche(Fiche);

            //if (postedFiche.Successful) Close();
            //SetError(postedFiche.Fail,false);
        }

        private void searchLookUpCard_EditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpCard.EditValue == null) return;
            grpLines.Enabled = true;
            itemPrices = OperationHandler.GetItemPricesByCard((int)searchLookUpCard.EditValue).Value;

            //lookUpExchange.EditValue = dataHolder.Cards.Where(x => x.Id == (int)searchLookUpCard.EditValue).First().ExchangeId;
            //lookUpItem.Enabled = true;
            
            //gcServices.DataSource = dataHolder.GetFicheLineServicesView((int)searchLookUpCard.EditValue);
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lookUpItem.Properties.DataSource = dataHolder.Items.Where(x => x.ItemTypeId == cmbItemType.SelectedIndex + 1);
            //lookUpItem.Properties.ValueMember = "Id";
            //lookUpItem.Properties.DisplayMember = "ItemName";
        }

        private void lookUpItem_EditValueChanged(object sender, EventArgs e)
        {
            //if (lookUpItem.EditValue == null) return;
            //ItemView item = dataHolder.Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault();
            //spHeight.Value = item.Height_;
            //spWeight.Value = item.Weight_;
            //spLength.Value = item.Length_;
            //spWidth.Value = item.Width_;
            //ItemPrice itemPrice = dataHolder.ItemPrices.Where
            //    (x => x.ItemId == Convert.ToInt32(lookUpItem.EditValue) && x.PriceTypeId == currentDocumentType.PriceType && x.CardId == Convert.ToInt32(searchLookUpCard.EditValue)
            //    ).FirstOrDefault();
            //if (itemPrice == null)
            //{
            //    itemPrice = dataHolder.ItemPrices.Where
            //    (x => x.ItemId == Convert.ToInt32(lookUpItem.EditValue) && x.PriceTypeId == currentDocumentType.PriceType
            //    ).FirstOrDefault();
            //}
            //if (itemPrice != null)
            //{
            //    spPrice.Value = itemPrice.Price;
            //}
            //else
            //{
            //    spPrice.Value = 0;
            //}
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            //gcLines.EmbeddedNavigator.Enabled = true;
            //gridView2.AddNewRow();
            //if (lookUpItem.EditValue == null) return;
            //if (spPrice.Value == 0 && currentDocumentType.PriceRequired)
            //{
            //    XtraMessageBox.Show("Məhsulun qiymətini daxil edin");
            //    return;
            //}
            //FicheLineView line = new FicheLineView();
            //line.Amount = spAmount.Value;
            //line.Height_ = spHeight.Value;
            //line.ItemId = Convert.ToInt32(lookUpItem.EditValue);
            //line.ItemName = dataHolder.Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault().ItemName;
            //line.ItemTypeName = dataHolder.Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault().ItemTypeName;
            //line.ItemCode = dataHolder.Items.Where(x => x.Id == Convert.ToInt32(lookUpItem.EditValue)).FirstOrDefault().ItemCode;
            //line.ItemTypeId = Convert.ToByte(cmbItemType.SelectedIndex);

            //line.Services = gvServices.GetSelectedRows<FicheLineServiceView>().DeepClone();


            //foreach (var servLine in line.Services)
            //{
            //    Item srvItem = dataHolder.Items.Where(x => x.Id == servLine.ServiceItemId).First();
            //    servLine.LineTotal = StaticData.CalculateItemTotal(srvItem.PriceCalcTypeId, servLine.ItemPrice, servLine.Amount, line.Width_, line.Length_, line.Height_);
            //    servLine.LineNetTotal = StaticData.CalculateItemTotal(srvItem.PriceCalcTypeId, servLine.LinePrice, servLine.Amount, line.Width_, line.Length_, line.Height_);
            //}


            ////line.LineNumber
            //line.Weight_ = spWeight.Value;
            //line.Width_ = spWidth.Value;
            //line.Length_ = spLength.Value;
            //line.LinePrice = spPrice.Value;

            ////line.LineNetTotal = line.LinePrice * line.Amount;
            //ItemView item = dataHolder.Items.Where(x => x.Id == line.ItemId).First();
            //line.LineNetTotal = StaticData.CalculateItemTotal(item.PriceCalcTypeId, line.LinePrice, line.Amount, line.Width_, line.Length_, line.Height_);
            //line.ServiceLineNetTotalSum = line.Services.Sum(x=>x.LineNetTotal);
            //line.LineFinalSum = line.LineNetTotal + line.LineExpense + line.ServiceLineNetTotalSum;
            //Fiche.FicheLines.Add(line );
            //Fiche.FicheLines.ForEach(x => x.LineNumber = Fiche.FicheLines.IndexOf(x) + 1);
            //Fiche.FicheLines = Fiche.FicheLines.OrderBy(x => x.LineNumber).ToList();
            //lookUpItem.EditValue = null;
            //RefreshLines();
            //if (AppSettings.FichesManpServiceLinesClearCheckedRowsOnAddLine) gvServices.ClearSelection();
            
        }

        private void gvLines_KeyDown(object sender, KeyEventArgs e)
        {
            //if (!IsEditMode) return;
            //if (e.KeyCode == Keys.Delete)
            //{
            //    if (gvLines.GetFocusedRow() == null) return;
            //    DialogResult del = XtraMessageBox.Show("Silmək istədiyinizdən əminsinizmi?", "Sətir silinməsi", MessageBoxButtons.YesNo);
            //    if (del == DialogResult.Yes)
            //    {
            //        FicheLineView currentLine = gvLines.GetFocusedRow() as FicheLineView;
            //        Fiche.FicheLines.Remove(currentLine);
            //    }
            //    Fiche.FicheLines.ForEach(x => x.LineNumber = Fiche.FicheLines.IndexOf(x) + 1);
            //    Fiche.FicheLines = Fiche.FicheLines.OrderBy(x => x.LineNumber).ToList();
            //    RefreshLines();
            //}
            //if (e.Shift && e.KeyValue >= (int)Keys.A && e.KeyValue <= (int)Keys.Z)
            //{
            //    if (gvLines.GetFocusedRow() == null) return;

            //    string keyString = ((char)(e.KeyValue + 32)).ToString();
            //    ItemView newItem = dataHolder.Items.Where(x => x.ShortcutKey.ToLower() == keyString.ToLower()).FirstOrDefault();
            //    if (newItem == null) return;


            //    FicheLineView currentLine = gvLines.GetFocusedRow() as FicheLineView;
            //    int index = Fiche.FicheLines.IndexOf(currentLine);

            //    FicheLineView newLine = new FicheLineView();
               
            //    newLine.ItemId = newItem.Id;
            //    newLine.ItemName = newItem.ItemName;
            //    newLine.ItemTypeName = newItem.ItemTypeName;
            //    newLine.ItemCode = newItem.ItemCode;
            //    newLine.ItemTypeId = newItem.ItemTypeId;


            //    newLine.Amount = currentLine.Amount;
            //    if (newItem.PriceCalcTypeId != 1)
            //    {
            //        newLine.Height_ = currentLine.Height_;
            //        newLine.Weight_ = currentLine.Weight_;
            //        newLine.Width_ = currentLine.Width_;
            //        newLine.Length_ = currentLine.Length_;
            //    }

            //    ItemPrice itemPrice = dataHolder.ItemPrices.Where
            //   (x => x.ItemId == newItem.Id && x.PriceTypeId == currentDocumentType.PriceType && x.CardId == Convert.ToInt32(searchLookUpCard.EditValue)
            //   ).FirstOrDefault();
            //    if (itemPrice == null)
            //    {
            //        itemPrice = dataHolder.ItemPrices.Where
            //        (x => x.ItemId == newItem.Id && x.PriceTypeId == currentDocumentType.PriceType
            //        ).FirstOrDefault();
            //    }
            //    if (itemPrice != null)
            //    {
            //        newLine.LinePrice = itemPrice.Price;
            //    }
               
            //    newLine.LineNetTotal = StaticData.CalculateItemTotal(newItem.PriceCalcTypeId, newLine.LinePrice, newLine.Amount, newLine.Width_, newLine.Length_, newLine.Height_);

            //    Fiche.FicheLines.Insert(index + 1, newLine);
            //    Fiche.FicheLines.ForEach(x => x.LineNumber = Fiche.FicheLines.IndexOf(x) + 1);
            //    Fiche.FicheLines = Fiche.FicheLines.OrderBy(x => x.LineNumber).ToList();
            //    RefreshLines();
            //}
        }

        private void gvLines_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            FicheLineView vw = gvLines.GetFocusedRow() as FicheLineView;
            if (vw == null)
            {
                gcServicesOfLine.DataSource = null;
                return;
            }
            gcServicesOfLine.DataSource = vw.LineServices;
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
            //List<CashTransactionView> cashes = gcCashTrans.DataSource as List<CashTransactionView>;
            //if (cashes == null) return;
            //decimal acceptedValue = cashes.Sum(x => x.TotalMEx) ;
            //decimal ficheLinesSum = Fiche.FicheLines.Sum(x => x.LineNetTotal);
            //foreach (var line in Fiche.FicheLines)
            //{
            //    var linePerc = line.LineNetTotal / ficheLinesSum;
            //    line.LineExpense = Math.Round(acceptedValue * linePerc, 2);
            //}
            //gcLines.RefreshDataSource();
        }

        private void btnAddCashTran_Click(object sender, EventArgs e)
        {
            //if (Fiche.Id == 0)
            //{
            //    XtraMessageBox.Show("Əvvəlcə Yaddaşa Yazın !");
            //    return;
            //}
            //Manp_CashTransaction cashTransaction = new Manp_CashTransaction(0,0,0,string.Empty,Fiche.Id,0);
            //cashTransaction.ShowDialog();
            //RefreshCashTrans();
        }

        private void RefreshCashTrans()
        {
            //gcCashTrans.DataSource = OperationHandler.GetCashTransactionsViewByFiche(Id).Value;
        }

        private void gvLines_ShownEditor(object sender, EventArgs e)
        {
            //GridView view = (GridView)sender;
            //if (view.FocusedColumn.FieldName == "ItemId")
            //{
            //    LookUpEdit editor = (LookUpEdit)view.ActiveEditor;
            //    FicheLineView line = (FicheLineView)view.GetFocusedRow();
            //    dataHolder.Items.Where(x => x.ItemTypeId == line.ItemTypeId).ToList();
            //    //ClsItems item = (ClsItems)view.GetFocusedRow();
            //    editor.Properties.DataSource = dataHolder.Items.Where(x => x.ItemTypeId == line.ItemTypeId).ToList();
            //    editor.Properties.DisplayMember = "ItemName";
            //    editor.Properties.ValueMember = "Id";
            //}
           
        }

        private void rpLookupItem_EditValueChanged(object sender, EventArgs e)
        {
            gvLines.PostEditor();
            FicheLineView line = (FicheLineView)gvLines.GetFocusedRow();

            CheckLine(line,true);
            gvLines.RefreshData();
        }

        void CheckLine(FicheLineView line , bool updateLinePrice = false)
        {
            if (line == null) return;
            if (line.ItemId == 0) return;
            ItemView item = dataHolder.Items.Where(x => x.Id == line.ItemId).FirstOrDefault();
            if (item == null) return;
            line.ItemCode = item.ItemCode;
            line.ItemTypeId = item.ItemTypeId;
            line.ItemTypeName = item.ItemTypeName;
            line.ItemName = item.ItemName;
            Calculation calculation = new Calculation();

            if (isNew) line.ItemPrice = calculation.GetItemDefaultPriceByDocumentType(item,DocumentType);
            if (isNew && updateLinePrice) line.LinePrice = calculation.CalculateLinePrice(item,DocumentType, itemPrices);
            line.LineNetTotal = calculation.CalculateLineTotal(item.LineCalcTypeId, line.LinePrice, line.Quantity, line.Width, line.Length);
            line.LineTotal = line.Quantity * line.ItemPrice;
            foreach (var srvLine in line.LineServices)
            {
                ItemView srvItem = dataHolder.Items.Where(x => x.Id == srvLine.ServiceItemId).FirstOrDefault();
                if (isNew) srvLine.ItemPrice = calculation.GetItemDefaultPriceByDocumentType(srvItem, DocumentType);
                if (isNew && updateLinePrice) srvLine.LinePrice = calculation.CalculateLinePrice(srvItem, DocumentType, itemPrices);
                srvLine.LineNet = calculation.CalculateLineTotal(srvItem.LineCalcTypeId, srvLine.LinePrice, srvLine.Quantity, line.Width, line.Length);
            }
            //line.
            gvLines.RefreshData();
            //gcServicesOfLine.DataSource = null;
            gcServicesOfLine.DataSource = line.LineServices;
            gcServicesOfLine.RefreshDataSource();
        }

        void refreshLineTotals()
        {
            foreach (var line in (gcLines.DataSource as List<FicheLineView>))
            {
                CheckLine(line);
                //decimal itemPrice = 0;
                //byte priceType = 0;
                //if (DocumentType.Id == 1 || DocumentType.Id == 2)
                //{
                //    itemPrice = item.DefaultSalePrice;
                //    priceType = 2;
                //}
                //else
                //{
                //    itemPrice = item.DefaultPurchasePrice;
                //    priceType = 1;
                //}
                //if (line.ItemPrice == 0) line.ItemPrice = itemPrice;

                //decimal linePrice = itemPrice;
                //ItemPrice priceOfCard = itemPrices.Where(x => x.ItemId == line.ItemId && x.PriceTypeId == priceType).FirstOrDefault();
                //if (priceOfCard != null) linePrice = priceOfCard.Price;
                //line.LinePrice = linePrice;
            }
        }

        private void rpLookupItem_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
           
        }

        private void Manp_FichesNew_KeyUp(object sender, KeyEventArgs e)
        {
            FicheLineView currenLine = gvLines.GetFocusedRow() as FicheLineView;
           // CheckLine(currenLine);
           // gvLines.RefreshData();

            if (e.KeyValue == 107 || e.KeyValue == 187)
            {
                FicheLineView newLine = new FicheLineView();
                  
                if (currenLine != null)
                {
                    if (chkStoreItem.Checked)
                    {
                        newLine.ItemId = currenLine.ItemId;
                    }
                    if (chkStoreQuantity.Checked)
                    {
                        newLine.Quantity = currenLine.Quantity;
                    }
                    if (chkStoreSizes.Checked)
                    {
                        newLine.Width = currenLine.Width;
                        newLine.Length = currenLine.Length;
                    }
                    if (chkStoreLinePrice.Checked)
                    {
                        newLine.LinePrice = currenLine.LinePrice;
                    }

                }
                newLine.LineServices = new List<FicheLineServiceView>();
                foreach (var srvItem in dataHolder.Items.Where(x => x.IsLineService))
                {
                    FicheLineServiceView lineServiceView = new FicheLineServiceView();
                    lineServiceView.ItemCode = srvItem.ItemCode;
                    lineServiceView.ItemName = srvItem.ItemName;
                    lineServiceView.ServiceItemId = srvItem.Id;
                    //lineServiceView. = srvItem.ItemName;
                    newLine.LineServices.Add(lineServiceView);
                }
                CheckLine(newLine,!chkStoreLinePrice.Checked);
                Fiche.Lines.Add(newLine);
                gcLines.RefreshDataSource();
                gvLines.MoveLast();

                //gcLines.EmbeddedNavigator.Buttons.Append
                //gvLines.AddNewRow();
            }
            if (e.KeyCode == Keys.Delete)
            {
                if (gvLines.GetFocusedRow() == null) return;
                DialogResult del = XtraMessageBox.Show("Silmək istədiyinizdən əminsinizmi?", "Sətir silinməsi", MessageBoxButtons.YesNo);
                if (del == DialogResult.Yes)
                {
                    FicheLineView currentLine = gvLines.GetFocusedRow() as FicheLineView;
                    Fiche.Lines.Remove(currentLine);
                }
                foreach (var line in Fiche.Lines) line.LineNumber = Fiche.Lines.IndexOf(line) + 1;
                Fiche.Lines = Fiche.Lines.OrderBy(x => x.LineNumber).ToList();
                RefreshLines();
            }
            if (e.KeyCode == Keys.Tab)
            {
                gvLines.PostEditor();gvLines.UpdateCurrentRow();
            }
        }

        //private void rse_Price_EditValueChanged(object sender, EventArgs e)
        //{
        //    gvLines.PostEditor();
        //    gvLines.UpdateCurrentRow();
        //    FicheLineView currenLine = gvLines.GetFocusedRow() as FicheLineView;
        //    CheckLine(currenLine);
        //}

        private void spinSrvLinePrice_EditValueChanged(object sender, EventArgs e)
        {
            gvServicesOfLine.PostEditor();
            gvServicesOfLine.UpdateCurrentRow();
            FicheLineView currenLine = gvLines.GetFocusedRow() as FicheLineView;
            CheckLine(currenLine);
        }

        private void spinSrvLineQuantity_EditValueChanged(object sender, EventArgs e)
        {
            gvServicesOfLine.PostEditor();
            gvServicesOfLine.UpdateCurrentRow();
            FicheLineView currenLine = gvLines.GetFocusedRow() as FicheLineView;
            CheckLine(currenLine);
        }
        private void gvLines_repositoryItems_EditValueChanged(object sender, EventArgs e)
        {
            gvLines.PostEditor();
            gvLines.UpdateCurrentRow();
            FicheLineView currenLine = gvLines.GetFocusedRow() as FicheLineView;
            CheckLine(currenLine);
        }

        private void tsIsCustomerItem_True_Click(object sender, EventArgs e)
        {
            gvLines.GetSelectedRows<FicheLineView>().ForEach(x=>x.IsCustomerItem = true);
            RefreshLines();
        }

        private void tsIsCustomerItem_False_Click(object sender, EventArgs e)
        {
            gvLines.GetSelectedRows<FicheLineView>().ForEach(x => x.IsCustomerItem = false);
            RefreshLines();
        }

        private void tsIsSketched_True_Click(object sender, EventArgs e)
        {
            gvLines.GetSelectedRows<FicheLineView>().ForEach(x => x.IsSketched = true);
            RefreshLines();
        }

        private void tsIsSketched_False_Click(object sender, EventArgs e)
        {
            gvLines.GetSelectedRows<FicheLineView>().ForEach(x => x.IsSketched = false);
            RefreshLines();
        }

        private void tsIsTemplated_True_Click(object sender, EventArgs e)
        {
            gvLines.GetSelectedRows<FicheLineView>().ForEach(x => x.IsTemplated = true);
            RefreshLines();
        }

        private void tsIsTemplated_False_Click(object sender, EventArgs e)
        {
            gvLines.GetSelectedRows<FicheLineView>().ForEach(x => x.IsTemplated = false);
            RefreshLines();
        }
    }
}