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
            GridViewDesignHandler gvh_items = new GridViewDesignHandler();
            gvh_items.GridView = gvByItems;
            gvh_items.GridViewInfo = OperationHandler.GetGridViewInfo(12);
            gvh_items.SetView();

            
            RefreshItemPriceData();
        }

       

        private void RefreshItemPriceData()
        {
            Operation<List<VW_ItemPricesDefault>> op_itprs_def = OperationHandler.GetItemDefaultPricesView();
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
            VW_ItemPricesDefault itemDef = (VW_ItemPricesDefault)objCurrent;
            Manp_ItemPriceByItem m_itp = new Manp_ItemPriceByItem();
            m_itp.itemDef = itemDef;
            m_itp.ShowDialog();
            RefreshItemPriceData();
        }
    }
}