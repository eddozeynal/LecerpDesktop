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
    public partial class Form_Items : DevExpress.XtraEditors.XtraForm
    {
        public Form_Items()
        {
            InitializeComponent();
        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            new Manp_Items().ShowDialog();
            RefreshData();
        }

        private void tsModify_Click(object sender, EventArgs e)
        {
            object objValue = gvData.GetFocusedRowCellValue("Id");
            if (objValue == null) return;
            Manp_Items mp_items = new Manp_Items();
            mp_items.Id = Convert.ToInt32(objValue);
            mp_items.ShowDialog();
            RefreshData();
        }

        private void Form_Items_Load(object sender, EventArgs e)
        {
            tsAddNew.Enabled = StaticData.IsPermitted(3);
            tsModify.Enabled = StaticData.IsPermitted(4);
            tsDelete.Enabled = StaticData.IsPermitted(6);
        }

        private void Form_Items_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            Operation<List<ItemView>> op_Items = OperationHandler.GetItems();
            if (op_Items.Successful)
            {
                gcData.DataSource = op_Items.Value;
            }
            else
            {
                // Show Error
            }
        }

        private void tsExportToExcel_Click(object sender, EventArgs e)
        {
            gvData.ExportExcell();
        }
    }
}