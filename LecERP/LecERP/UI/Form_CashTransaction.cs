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
        }

        private void Form_CashTransaction_Shown(object sender, EventArgs e)
        {
            gvData.AssignGridView(17);
            //Operation<List<DocumentMaster>> op_DocumentMasters = OperationHandler.GetDocumentMasters();

            //if (!op_DocumentMasters.Successful)
            //{


            //}

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

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            //object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            //if (objCurrentId == null) return;
            //int CurrentId = Convert.ToInt32(objCurrentId);
            //Manp_FichesNew manp = new Manp_FichesNew();
            //manp.Id = CurrentId;
            //manp.IsEditMode = true;
            //manp.CreateInvoiceFromOrderFiche = true;
            //manp.ShowDialog();
            //RefreshData();
        }
    }
}