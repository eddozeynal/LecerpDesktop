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
    public partial class Form_Prices : DevExpress.XtraEditors.XtraForm
    {
        public Form_Prices()
        {
            InitializeComponent();
        }

        private void Form_Prices_Shown(object sender, EventArgs e)
        {
            RefreshItemPriceData();
        }

       

        private void RefreshItemPriceData()
        {
            Operation<List<ItemView>> op_itprs_def = OperationHandler.GetItems();
            if (op_itprs_def.Successful)
            {
                gcByItems.DataSource = op_itprs_def.Value;
            }
            else
            {
                // Show Error
            }
        }

       
        private void Form_Prices_Load(object sender, EventArgs e)
        {

        }

        private void gcByItems_DoubleClick(object sender, EventArgs e)
        {
            object objCurrent = gvByItems.GetFocusedRow();
            if (objCurrent == null) return;
            ItemView itemDef = (ItemView)objCurrent;
            Manp_ItemPrice m_itp = new Manp_ItemPrice();
            m_itp.item = itemDef;
            m_itp.ShowDialog();
            RefreshItemPriceData();
        }
    }
}