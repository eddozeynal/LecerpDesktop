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
using ERPService.Models;
using LecERP.Models;

namespace LecERP
{
    public partial class Form_CashTransaction : DevExpress.XtraEditors.XtraForm
    {
        public Form_CashTransaction()
        {
            InitializeComponent();
        }

        private void Form_CashTransaction_Load(object sender, EventArgs e)
        {
            dateBegin.DateTime = DateTime.Today;
            dateEnd.DateTime = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            tsAddNew.Enabled = StaticData.IsPermitted(29);
            tsModify.Enabled = StaticData.IsPermitted(30);
            tsDelete.Enabled = StaticData.IsPermitted(31);
            tsAcceptCashTran.Enabled = StaticData.IsPermitted(36);
            tsReserveCash.Enabled = StaticData.IsPermitted(37);
        }

        private void Form_CashTransaction_Shown(object sender, EventArgs e)
        {

        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            Manp_CashTransaction manp = new Manp_CashTransaction();
            manp.IsEditMode = true;
            manp.ShowDialog();
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        void RefreshData()
        {
            Operation<List<CashTransactionView>> op_CashTransactions = OperationHandler.GetCashTransactionsView(dateBegin.DateTime, dateEnd.DateTime,StaticData.CurrentUserId);
            gcData.DataSource = op_CashTransactions.Value;
        }

        private void lookUpFicheType_EditValueChanged(object sender, EventArgs e)
        {
            gcData.DataSource = null;
        }

        private void tsModify_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            Manp_CashTransaction manp = new Manp_CashTransaction();
            manp.Id = CurrentId;
            manp.IsEditMode = true;
            manp.ShowDialog();
            RefreshData();
        }

        private void tsView_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            Manp_CashTransaction manp = new Manp_CashTransaction();
            manp.Id = CurrentId;
            manp.ShowDialog();
            RefreshData();
        }

        

        private void tsExportToExcel_Click(object sender, EventArgs e)
        {
            gvData.ExportExcell();
        }

        private void tsAcceptCashTran_Click(object sender, EventArgs e)
        {
             
            var objCashTran = gvData.GetFocusedRow() as CashTransactionView;
            if (objCashTran == null) return;
            DialogResult dialogResult = XtraMessageBox.Show("Əminsinizmi?", "Kassa Tranzaksiya", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CashTransaction cashTransaction = OperationHandler.GetCashTransactionById(objCashTran.Id).Value;
                cashTransaction.StatusId = 12;
                var oper = OperationHandler.PostCashTransaction(cashTransaction);
                if (oper.Successful)
                {
                    XtraMessageBox.Show("Təhvil alındı");
                }
                else
                {
                    XtraMessageBox.Show("Səhvlik oldu " + oper.Fail);
                }
            }
            RefreshData();
        }

        private void tsReserveCash_Click(object sender, EventArgs e)
        {
            var objCashTran = gvData.GetFocusedRow() as CashTransactionView;
            if (objCashTran == null) return;
            DialogResult dialogResult = XtraMessageBox.Show("Əminsinizmi?", "Kassa Tranzaksiya", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CashTransaction cashTransaction = OperationHandler.GetCashTransactionById(objCashTran.Id).Value;
                cashTransaction.StatusId = 10;
                var oper = OperationHandler.PostCashTransaction(cashTransaction);
                if (oper.Successful)
                {
                    XtraMessageBox.Show("Rezervə alındı");
                }
                else
                {
                    XtraMessageBox.Show("Səhvlik oldu " + oper.Fail);
                }
            }
            RefreshData();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            var objCashTran = gvData.GetFocusedRow() as CashTransactionView;
            if (objCashTran == null) return;
            DialogResult dialogResult = XtraMessageBox.Show("Əminsinizmi?", "Kassa Tranzaksiya", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CashTransaction cashTransaction = OperationHandler.GetCashTransactionById(objCashTran.Id).Value;
                cashTransaction.StatusId = 13;
                var oper = OperationHandler.PostCashTransaction(cashTransaction);
                if (oper.Successful)
                {
                    XtraMessageBox.Show("Ləğv olundu");
                }
                else
                {
                    XtraMessageBox.Show("Səhvlik oldu " + oper.Fail);
                }
            }
            RefreshData();
        }
    }
}