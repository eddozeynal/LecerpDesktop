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
            dateEnd.DateTime = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        private void Form_CardDebtReport_Shown(object sender, EventArgs e)
        {
            GridViewDesignHandler gvh = new GridViewDesignHandler();
            gvh.GridView = gvData;
            gvh.GridViewInfo = OperationHandler.GetGridViewInfo(18);
            gvh.SetView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gcData.DataSource = OperationHandler.GetAllCardsExt(dateEnd.DateTime, StaticData.CurrentUserId).Value;
        }
    }
}