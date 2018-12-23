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
    public partial class Form_Prices : DevExpress.XtraEditors.XtraForm
    {
        public Form_Prices()
        {
            InitializeComponent();
        }

        private void Form_Prices_Shown(object sender, EventArgs e)
        {
            gvByItems.AssignGridView(12);

            RefreshItemPriceData();
        }

       

        private void RefreshItemPriceData()
        {
            Operation<List<ItemDefaultPrices>> op_itprs_def = OperationHandler.GetItemDefaultPricesView();
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
            ItemDefaultPrices itemDef = (ItemDefaultPrices)objCurrent;
            Manp_ItemPriceByItem m_itp = new Manp_ItemPriceByItem();
            m_itp.itemDef = itemDef;
            m_itp.ShowDialog();
            RefreshItemPriceData();
        }
    }
}