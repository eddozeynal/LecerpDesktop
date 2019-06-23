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
using ERPService.Models;

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
            
            btnAddCashTran.Enabled = btnDistributeExpences.Enabled =
            btnOk.Enabled = searchLookUpCard.Enabled =
                lookUpWarehouse.Enabled = IsEditMode;

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
            lookUpWarehouse.Properties.DataSource = dataHolder.Warehouses;
            
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
                Operation<FicheMasterView> op_ExistingFiche = OperationHandler.GetFicheById(Id);
                if (!op_ExistingFiche.Successful)
                {
                    SetError(op_ExistingFiche.Fail);
                    return;
                }
                Fiche = op_ExistingFiche.Value;
                txtDate.Text = Fiche.CreatedDate.ToString("dd.MM.yyyy");
                DocumentType = dataHolder.DocumentTypes.Where(x => x.Id == Fiche.DocTypeId).First();
                if (CreateInvoiceFromOrderFiche)
                {
                    Fiche.SourceDocument = Fiche.Ficheno;
                    Id = Fiche.Id = 0;
                    Fiche.DocTypeId = 2;
                    btnOk.Text = "Fakturala";
                }
               
            }
            if (DocumentType.Id == 1 || DocumentType.Id == 2)
            {
                gvLines.Columns["LineExpense"].Visible = false;
                tabNavigationExpencesPage.PageVisible = false;
            }
            else
            {
                gvLines.Columns["LineServicesTotal"].Visible = false;
                gvLines.Columns["IsCustomerItem"].Visible = false;
                gvLines.Columns["IsSketched"].Visible = false;
                gvLines.Columns["IsTemplated"].Visible = false;
                gcServicesOfLine.Visible = false;
                gcLines.ContextMenuStrip = null;
                tabNavigationExpencesPage.PageVisible = true;
            }

            bindTool.BindControl(searchLookUpCard, nameof(Fiche.CardId));
            bindTool.BindControl(lookUpWarehouse, nameof(Fiche.SourceWarehouse));
            bindTool.BindControl(txtFicheno, nameof(Fiche.Ficheno));
            bindTool.BindControl(txtNote1, nameof(Fiche.Note1));
            bindTool.BindControl(txtNote2, nameof(Fiche.Note2));
            bindTool.BindControl(txtNote3, nameof(Fiche.Note3));
            bindTool.BindControl(txtNote4, nameof(Fiche.Note4));
            bindTool.BindControl(txtSourceDoc, nameof(Fiche.SourceDocument));
            bindTool.BindControl(spCurrencyRate, nameof(Fiche.CurrencyRate));
            bindTool.DataObject = Fiche;
            
            if (dataHolder.Warehouses.Count > 0)
                lookUpWarehouse.EditValue = dataHolder.Warehouses.First().Number;

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

            Fiche = bindTool.DataObject;
            if (isNew)
            {
                Fiche.CreatedBy = StaticData.CurrentUserId;
                Fiche.CreatedDate = DateTime.Now;
            }
            Fiche.DocTypeId = DocumentType.Id;

            if (CreateInvoiceFromOrderFiche)
            {
                Fiche.DocTypeId = DocumentType.Id = 2;
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
            if (searchLookUpCard.EditValue == null || Convert.ToInt32(searchLookUpCard.EditValue) == 0) return;
            grpLines.Enabled = true;
            int cardId = Convert.ToInt32(searchLookUpCard.EditValue);
            itemPrices = OperationHandler.GetItemPricesByCard(cardId).Value;
            CardView card = dataHolder.Cards.Where(x => x.Id == Convert.ToInt32(searchLookUpCard.EditValue)).First();
            Currency currency = dataHolder.Currencies.Where(x=>x.Id == card.CurrencyId).First();
            lblCurrencyName.Text = currency.CurrencyName;
            Operation<CurrencyByDate> currencyByDateOperation = OperationHandler.GetCurrencyLastValue(currency.Id);
            if (currencyByDateOperation.Successful)
            {
                spCurrencyRate.Value = currencyByDateOperation.Value.Rate;
            }
            Fiche.CurrencyId = currency.Id;
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lookUpItem_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gvLines_KeyDown(object sender, KeyEventArgs e)
        {
          
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

      

        private void btnAddCashTran_Click(object sender, EventArgs e)
        {
            if (Fiche.Id == 0)
            {
                XtraMessageBox.Show("Əvvəlcə Yaddaşa Yazın !");
                return;
            }
            Manp_CashTransaction cashTransaction = new Manp_CashTransaction(0, 0, 0, string.Empty, Fiche.Id, 0);
            cashTransaction.ShowDialog();
            RefreshCashTrans();
        }

        private void RefreshCashTrans()
        {
            gcCashTrans.DataSource = OperationHandler.GetCashTransactionsViewByFiche(Id).Value;
        }

        private void gvLines_ShownEditor(object sender, EventArgs e)
        {
          
           
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
            line.LineTotal = calculation.CalculateLineTotal(item.LineCalcTypeId, line.ItemPrice, line.Quantity, line.Width, line.Length);
            line.LineNetTotal = calculation.CalculateLineTotal(item.LineCalcTypeId, line.LinePrice, line.Quantity, line.Width, line.Length);
            foreach (var srvLine in line.LineServices)
            {
                ItemView srvItem = dataHolder.Items.Where(x => x.Id == srvLine.ServiceItemId).FirstOrDefault();
                if (isNew) srvLine.ItemPrice = calculation.GetItemDefaultPriceByDocumentType(srvItem, DocumentType);
                if (isNew && updateLinePrice) srvLine.LinePrice = calculation.CalculateLinePrice(srvItem, DocumentType, itemPrices);
                srvLine.LineTotal = calculation.CalculateLineTotal(srvItem.LineCalcTypeId, srvLine.ItemPrice, srvLine.Quantity, line.Width, line.Length);
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

        private void btnDistributeExpences_Click(object sender, EventArgs e)
        {
            List <CashTransactionView> cashes = gcCashTrans.DataSource as List<CashTransactionView>;
            decimal expcSum = cashes.Sum(x => x.DmTotal) / spCurrencyRate.Value;
            decimal ficheLinesSum = Fiche.Lines.Sum(x => x.LineNetTotal);

            foreach (var line in Fiche.Lines)
            {
                var linePerc = line.LineNetTotal / ficheLinesSum;
                line.LineExpense = Math.Round(expcSum * linePerc, 2);
                line.LineTotalAcc = line.LineNetTotal + line.LineExpense;
            }
            
            gcLines.RefreshDataSource();
        }
    }
}