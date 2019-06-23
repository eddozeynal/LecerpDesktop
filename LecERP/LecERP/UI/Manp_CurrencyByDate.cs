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
using LecERP.Models;

namespace LecERP
{
    public partial class Manp_CurrencyByDate : DevExpress.XtraEditors.XtraForm
    {
        DataHolder dataHolder = new DataHolder();
        DataObjectBindTool<CurrencyByDate> bindTool = new DataObjectBindTool<CurrencyByDate>();
        CurrencyByDate currencyByDate = new CurrencyByDate();
        public Manp_CurrencyByDate()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Manp_CurrencyByDate_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            currencyByDate = bindTool.DataObject;
            var postOperation = OperationHandler.PostCurrencyByDate(currencyByDate);
            if (postOperation.Successful)
            {
                this.Close();
            }
            else
            {
                XtraMessageBox.Show(postOperation.Fail);
            }
        }

        private void Manp_CurrencyByDate_Shown(object sender, EventArgs e)
        {
            dataHolder.LoadEnumData();
            dateOfCurrency.DateTime = DateTime.Today;
            lookUpCurrency.Properties.DataSource = dataHolder.Currencies;
            bindTool.BindControl(dateOfCurrency, nameof(currencyByDate.Date));
            bindTool.BindControl(lookUpCurrency, nameof(currencyByDate.CurrencyId));
            bindTool.BindControl(spRate, nameof(currencyByDate.Rate));
        }
    }
}