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
    public partial class Form_CurrencyByDate : DevExpress.XtraEditors.XtraForm
    {
        public Form_CurrencyByDate()
        {
            InitializeComponent();
        }

        private void Form_CurrencyByDate_Load(object sender, EventArgs e)
        {

        }

        void refreshData()
        {
            gcData.DataSource = null;
            gcData.DataSource = OperationHandler.GetCurrenciesByDate().Value;
        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            new Manp_CurrencyByDate().ShowDialog();
            refreshData();
        }

        private void Form_CurrencyByDate_Shown(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}