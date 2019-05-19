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
    public partial class Form_CurrencyExchange : DevExpress.XtraEditors.XtraForm
    {
        public Form_CurrencyExchange()
        {
            InitializeComponent();
        }

        private void Form_CurrencyExchange_Load(object sender, EventArgs e)
        {
            dateBegin.DateTime = DateTime.Today;
            dateEnd.DateTime = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            tsAddNew.Enabled = StaticData.IsPermitted(39);
            tsModify.Enabled = StaticData.IsPermitted(40);
            tsDelete.Enabled = StaticData.IsPermitted(41);
        }

        private void Form_CurrencyExchange_Shown(object sender, EventArgs e)
        {

        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            Manp_CurrencyExchange manp = new Manp_CurrencyExchange();
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
            Operation<List<ExchangeTransactionView>> op_ExchangeTransactions = OperationHandler.GetExchangeTransactionsView(dateBegin.DateTime, dateEnd.DateTime,StaticData.CurrentUserId);
            gcData.DataSource = op_ExchangeTransactions.Value;
        }

        

        private void tsModify_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            Manp_CurrencyExchange manp = new Manp_CurrencyExchange();
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
            Manp_CurrencyExchange manp = new Manp_CurrencyExchange();
            manp.Id = CurrentId;
            manp.ShowDialog();
            RefreshData();
        }

        

        private void tsExportToExcel_Click(object sender, EventArgs e)
        {
            gvData.ExportExcell();
        }

        

       

        private void tsDelete_Click(object sender, EventArgs e)
        {
            //var objCashTran = gvData.GetFocusedRow() as CashTransactionView;
            //if (objCashTran == null) return;
            //DialogResult dialogResult = XtraMessageBox.Show("Əminsinizmi?", "Kassa Tranzaksiya", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    CashTransaction cashTransaction = OperationHandler.GetCashTransactionById(objCashTran.Id).Value;
            //    cashTransaction.StatusId = 13;
            //    var oper = OperationHandler.PostCashTransaction(cashTransaction);
            //    if (oper.Successful)
            //    {
            //        XtraMessageBox.Show("Ləğv olundu");
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("Səhvlik oldu " + oper.Fail);
            //    }
            //}
            //RefreshData();
        }
    }
}