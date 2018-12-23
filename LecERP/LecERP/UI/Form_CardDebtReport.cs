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
    public partial class Form_CardDebtReport : DevExpress.XtraEditors.XtraForm
    {
        public Form_CardDebtReport()
        {
            InitializeComponent();
        }

        private void Form_CardDebtReport_Load(object sender, EventArgs e)
        {
            dateBegin.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateEnd.DateTime = new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month), 23,59,59);
        }

        private void Form_CardDebtReport_Shown(object sender, EventArgs e)
        {
            gvData.AssignGridView(18);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gcData.DataSource = OperationHandler.GetCardTotalsByInterval(StaticData.CurrentUserId,dateBegin.DateTime,dateEnd.DateTime).Value;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            gvData.ExportExcell();
        }

        private void gcData_DoubleClick(object sender, EventArgs e)
        {
            showCurrentCardHistory();
        }

        private void showCurrentCardHistory()
        {
            object objCardId = gvData.GetFocusedRowCellValue("Id");
            if (objCardId == null) return;
            int CardId = Convert.ToInt32(objCardId);
            Form_CardHistory cardHistoryFm = new Form_CardHistory();
            cardHistoryFm.CardId = CardId;
            cardHistoryFm.ShowDialog();
        }

        private void gcData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) showCurrentCardHistory();
        }
    }
}