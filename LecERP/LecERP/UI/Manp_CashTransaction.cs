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
    public partial class Manp_CashTransaction : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        public bool IsEditMode { get; set; }

        CashTransaction cashTransaction = null;
        List<ExchangeMaster> Exchanges = null;
        List<CardMasterView> Cards = null;
        List<EnumMaster> CashTrsancationTypes = null;

        public byte DocTypeId { get; set; }

        public Manp_CashTransaction()
        {
            InitializeComponent();
        }

        private void Manp_CashTransaction_Load(object sender, EventArgs e)
        {

        }

        private void Manp_CashTransaction_Shown(object sender, EventArgs e)
        {
            if (!IsEditMode)
            {
                foreach (Control c in grpCenter.Controls) c.Enabled = false;
                btnOk.Enabled = false;
            }
            
            List<IBaseOperation> loadOperations = new List<IBaseOperation>();
            Operation<List<ExchangeMaster>> op_ExchangeMaster = OperationHandler.GetAllExchanges();
            loadOperations.Add(op_ExchangeMaster);
            Operation<List<CardMasterView>> op_CardMaster = OperationHandler.GetAllCards();
            loadOperations.Add(op_CardMaster);
            Operation<List<EnumMaster>> op_CashTrsancationTypes = OperationHandler.GetEnums(8);
            loadOperations.Add(op_CashTrsancationTypes);

            foreach (IBaseOperation ibop in loadOperations)
            {
                if (!ibop.Successful)
                {
                    SetError(ibop.Fail);
                    return;
                }
            }

            Exchanges = op_ExchangeMaster.Value;
            Cards = op_CardMaster.Value;
            CashTrsancationTypes = op_CashTrsancationTypes.Value;


            lookUpExchange.Properties.DataSource = Exchanges;
            lookUpTransactionType.Properties.DataSource = CashTrsancationTypes;

            lookUpTransactionType.ItemIndex = 2;


            if (Id == 0)
            {
                cashTransaction = new CashTransaction();
            }
            else
            {
                Operation<CashTransaction> op_ExistingCashTransaction = OperationHandler.GetCashTransactionById(Id);
                if (!op_ExistingCashTransaction.Successful)
                {
                    SetError(op_ExistingCashTransaction.Fail);
                    return;
                }
                cashTransaction = op_ExistingCashTransaction.Value;
                lookUpTransactionType.EditValue = cashTransaction.TransactionType;
                lookUpTransactionType.ReadOnly = true;
                lookUpExchange.EditValue = cashTransaction.ExchangeId;
                FillLookUpCards(cashTransaction.ExchangeId);
                lookUpExchange.ReadOnly = true;
                txtNote.Text = cashTransaction.Note;
                txtFicheno.Text = cashTransaction.Ficheno;
                txtDate.Text = cashTransaction.CreatedDate.ToString("dd.MM.yyyy HH:mm");
                spAmount.EditValue = cashTransaction.Total;
                searchLookUpSourceCard.EditValue = cashTransaction.SourceCardId;
                searchLookUpDestCard.EditValue = cashTransaction.DestCardId;
            }

            searchLookUpSourceCard.Properties.View.AssignGridView(14);
            searchLookUpDestCard.Properties.View.AssignGridView(14);
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
            
            cashTransaction.TransactionType = Convert.ToByte( lookUpTransactionType.EditValue );
            cashTransaction.ExchangeId = Convert.ToByte( lookUpExchange.EditValue );
            cashTransaction.Note = txtNote.Text ;
            cashTransaction.Ficheno = txtFicheno.Text ;
            if (Id == 0)
            {
                cashTransaction.CreatedBy = StaticData.CurrentUserId;
                cashTransaction.CreatedDate = DateTime.Now;
            }
            cashTransaction.Total = spAmount.Value ;
            cashTransaction.SourceCardId = Convert.ToInt32( searchLookUpSourceCard.EditValue );
            cashTransaction.DestCardId = Convert.ToInt32(searchLookUpDestCard.EditValue) ;
            Operation<CashTransaction> postedCashTransaction = OperationHandler.PostCashTransaction(cashTransaction);
            if (postedCashTransaction.Successful) this.Close();
            SetError(postedCashTransaction.Fail,false);
        }

        private void lookUpExchange_EditValueChanged(object sender, EventArgs e)
        {
            int ExchangeId = Convert.ToInt32(lookUpExchange.EditValue);
            //lookUpExchange.Enabled = false;
            FillLookUpCards(ExchangeId);
        }

        void FillLookUpCards(int ExchangeId)
        {
            Cards = Cards.Where(x => x.ExchangeId == ExchangeId).ToList();
            searchLookUpSourceCard.Properties.DataSource = Cards;
            searchLookUpDestCard.Properties.DataSource = Cards;
        }
    }
}