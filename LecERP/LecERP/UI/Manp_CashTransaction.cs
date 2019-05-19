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
using LecERP.Models;

namespace LecERP
{
    public partial class Manp_CashTransaction : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        public bool IsEditMode { get; set; }

        CashTransaction cashTransaction = null;
        List<Currency> Currencies = null;
        List<CardView> Cards = null;
        List<CashType> CashTypes = null;
        public byte DocTypeId { get; set; }
        DataHolder dataHolder = new DataHolder();
        DataObjectBindTool<CashTransaction> bindTool = new DataObjectBindTool<CashTransaction>();
        bool injected = false;
        int sourceCardId; int destCardId; decimal amount; string note = string.Empty; int connectedInvoiceId; byte cashCategoryId;

        public Manp_CashTransaction()
        {
            InitializeComponent();
        }

        public Manp_CashTransaction(int _sourceCardId,int _destCardId,decimal _amount, string _note, int _connectedInvoiceId, byte _cashCategoryId)
        {
            InitializeComponent();
            sourceCardId = _sourceCardId;
            destCardId = _destCardId;
            amount = _amount;
            note = _note;
            connectedInvoiceId = _connectedInvoiceId;
            cashCategoryId = _cashCategoryId;
            IsEditMode = true;
            injected = true;
        }

        private void Manp_CashTransaction_Load(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void Manp_CashTransaction_Shown(object sender, EventArgs e)
        {
            if (!IsEditMode)
            {
                foreach (Control c in grpCenter.Controls) c.Enabled = false;
                btnOk.Enabled = false;
            }
            List<IBaseOperation> loadOperations = new List<IBaseOperation>();

            IBaseOperation baseOperation = dataHolder.LoadEnumData();
            loadOperations.Add(baseOperation);

            Operation<List<CardView>> op_CardMaster = OperationHandler.GetCards();
            loadOperations.Add(op_CardMaster);

            if (Id != 0)
            {
                Operation<CashTransaction> op_ExistingCashTransaction = OperationHandler.GetCashTransactionById(Id);
                loadOperations.Add(op_ExistingCashTransaction);
                cashTransaction = op_ExistingCashTransaction.Value;
                lookUpCurrency.ReadOnly = true;
            }
            else
            {
                cashTransaction = new CashTransaction();
                cashTransaction.CurrencyId = 1;
                cashTransaction.CurrencyRate = 1;
                cashTransaction.CreatedDate = DateTime.Now;
                cashTransaction.CreatedBy = StaticData.CurrentUserId;
                cashTransaction.StatusId = 11;
            }

            foreach (IBaseOperation ibop in loadOperations)
            {
                if (!ibop.Successful)
                {
                    SetError(ibop.Fail);
                    return;
                }
            }

            Cards = op_CardMaster.Value;
            Currencies = dataHolder.Currencies;
            CashTypes = dataHolder.CashTypes;

            lookUpCurrency.Properties.DataSource = Currencies;
            lookUpCashType.Properties.DataSource = CashTypes;

            bindTool.BindControl(lookUpCurrency, nameof(cashTransaction.CurrencyId));
            bindTool.BindControl(lookUpCashType, nameof(cashTransaction.CashTypeId));
            bindTool.BindControl(txtNote, nameof(cashTransaction.Note));
            bindTool.BindControl(txtFicheno, nameof(cashTransaction.Ficheno));
            bindTool.BindControl(spAmount, nameof(cashTransaction.Total));
            bindTool.BindControl(spCurrencyRate, nameof(cashTransaction.CurrencyRate));
            bindTool.BindControl(searchLookUpSourceCard, nameof(cashTransaction.SourceCardId));
            bindTool.BindControl(searchLookUpDestCard, nameof(cashTransaction.DestCardId));
            bindTool.DataObject = cashTransaction;

            txtDate.Text = cashTransaction.CreatedDate.ToString(StaticData.DateTimeFromatStr);

            if (injected)
            {
                
                
                CardView sourceCard = Cards.Where(x => x.Id == sourceCardId).FirstOrDefault();
                lookUpCurrency.EditValue = sourceCard.CurrencyId;
                searchLookUpSourceCard.EditValue = sourceCard.Id;
                searchLookUpDestCard.EditValue = destCardId;
                spAmount.EditValue = amount;
                txtNote.Text = note;
                lookUpCurrency.ReadOnly = true;
                cashTransaction.ConnectedFicheId = connectedInvoiceId;
            }
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
            cashTransaction = bindTool.DataObject;
            Operation<CashTransaction> postedCashTransaction = OperationHandler.PostCashTransaction(cashTransaction);
            if (postedCashTransaction.Successful) this.Close();
            SetError(postedCashTransaction.Fail, false);
        }

        private void lookUpCurrency_EditValueChanged(object sender, EventArgs e)
        {
            int currencyId = Convert.ToInt32(lookUpCurrency.EditValue);
            List<CardView> cardViews = Cards.Where(x => x.CurrencyId == currencyId).ToList();
            searchLookUpSourceCard.Properties.DataSource = cardViews;
            searchLookUpDestCard.Properties.DataSource = cardViews;
            
        }

        private void lookUpCashCategory_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}