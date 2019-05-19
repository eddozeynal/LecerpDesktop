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
    public partial class Form_ItemReport : DevExpress.XtraEditors.XtraForm
    {
        public Form_ItemReport()
        {
            InitializeComponent();
        }

        private void Form_ItemReport_Load(object sender, EventArgs e)
        {
            dateBegin.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateEnd.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month), 23, 59, 59);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            gvData.ExportExcell();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var list = OperationHandler.GetItemTotalsByInterval(StaticData.CurrentUserId, dateBegin.DateTime, dateEnd.DateTime).Value;
            
            gcData.DataSource = list;
        }

        private void Form_ItemReport_Shown(object sender, EventArgs e)
        {
            gvData.AssignGridView(20);
        }
    }
}