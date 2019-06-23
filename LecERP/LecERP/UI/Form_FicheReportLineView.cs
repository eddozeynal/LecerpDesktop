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
    public partial class Form_FicheReportLineView : DevExpress.XtraEditors.XtraForm
    {
        public Form_FicheReportLineView()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gcLines.DataSource = OperationHandler.GetFicheReportLines(dateBegin.DateTime,dateEnd.DateTime).Value;
        }

        private void Form_FicheReportLineView_Load(object sender, EventArgs e)
        {
            dateBegin.DateTime = DateTime.Today;
            dateEnd.DateTime = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
        }
    }
}