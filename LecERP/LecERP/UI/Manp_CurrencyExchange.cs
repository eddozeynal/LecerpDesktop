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
    public partial class Manp_CurrencyExchange : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        public bool IsEditMode { get; set; }

        ExchangeTransaction exchangeTransaction = null;
        List<CardView> Cards = null;
        DataHolder dataHolder = new DataHolder();
        DataObjectBindTool<ExchangeTransaction> bindTool = new DataObjectBindTool<ExchangeTransaction>();

        public Manp_CurrencyExchange()
        {
            InitializeComponent();
        }

        private void Manp_CurrencyExchange_Load(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void Manp_CurrencyExchange_Shown(object sender, EventArgs e)
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
                Operation<ExchangeTransaction> op_ExistingCashTransaction = OperationHandler.GetExchangeTransactionById(Id);
                loadOperations.Add(op_ExistingCashTransaction);
                exchangeTransaction = op_ExistingCashTransaction.Value;
            }
            else
            {
                exchangeTransaction = new ExchangeTransaction();
                exchangeTransaction.CurrencyRate = 1;
                exchangeTransaction.CreatedDate = DateTime.Now;
                exchangeTransaction.CreatedBy = StaticData.CurrentUserId;
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

            searchLookUpSourceCard.Properties.DataSource = Cards;
            searchLookUpDestCard.Properties.DataSource = Cards;

            bindTool.BindControl(txtNote, nameof(exchangeTransaction.Note));
            bindTool.BindControl(txtFicheno, nameof(exchangeTransaction.Ficheno));
            bindTool.BindControl(spAmount, nameof(exchangeTransaction.Total));
            bindTool.BindControl(spCurrencyRate, nameof(exchangeTransaction.CurrencyRate));
            bindTool.BindControl(searchLookUpSourceCard, nameof(exchangeTransaction.SourceCardId));
            bindTool.BindControl(searchLookUpDestCard, nameof(exchangeTransaction.DestCardId));
            bindTool.DataObject = exchangeTransaction;

            txtDate.Text = exchangeTransaction.CreatedDate.ToString(StaticData.DateTimeFromatStr);

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
            exchangeTransaction = bindTool.DataObject;
            Operation<ExchangeTransaction> postedexchangeTransaction = OperationHandler.PostExchangeTransaction(exchangeTransaction);
            if (postedexchangeTransaction.Successful) this.Close();
            SetError(postedexchangeTransaction.Fail, false);
        }
    }
}