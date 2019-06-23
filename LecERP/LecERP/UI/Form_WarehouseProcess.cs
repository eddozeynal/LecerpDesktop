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
    public partial class Form_WarehouseProcess : DevExpress.XtraEditors.XtraForm
    {
        public Form_WarehouseProcess()
        {
            InitializeComponent();
        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            new Manp_WarehouseProcess().ShowDialog();
            RefreshData();
        }

        private void tstsViewFiches_Click(object sender, EventArgs e)
        {
            object objValue = gvData.GetFocusedRowCellValue("Id");
            if (objValue == null) return;
            Manp_WarehouseProcess mp_items = new Manp_WarehouseProcess();
            mp_items.Id = Convert.ToInt32(objValue);
            mp_items.ShowDialog();
            RefreshData();
        }

        private void Form_WarehouseProcess_Load(object sender, EventArgs e)
        {
            dateBegin.DateTime = DateTime.Today;
            dateEnd.DateTime = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            //tsAddNew.Enabled = StaticData.IsPermitted(3);
            //tsModify.Enabled = StaticData.IsPermitted(4);
            //tsDelete.Enabled = StaticData.IsPermitted(6);
        }

        private void Form_WarehouseProcess_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            Operation<List<WarehouseProcessView>> op_Items = OperationHandler.GetWarehouseProcesses(dateBegin.DateTime,dateEnd.DateTime);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void tsBeginProcess_Click(object sender, EventArgs e)
        {
            object objValue = gvData.GetFocusedRowCellValue("Id");
            if (objValue == null) return;
            var operation = OperationHandler.WarehouseProcessBegin(Convert.ToInt32(objValue));
            RefreshData();
        }

        private void tsEndProcess_Click(object sender, EventArgs e)
        {
            object objValue = gvData.GetFocusedRowCellValue("Id");
            if (objValue == null) return;
            var operation = OperationHandler.WarehouseProcessEnd(Convert.ToInt32(objValue));
            RefreshData();
        }

        private void tsViewProcess_Click(object sender, EventArgs e)
        {
            object objValue = gvData.GetFocusedRowCellValue("Id");
            if (objValue == null) return;
            Manp_WarehouseProcessDetail processDetail = new Manp_WarehouseProcessDetail();
            processDetail.Id = Convert.ToInt32(objValue);
            processDetail.ShowDialog();
            RefreshData();
        }
    }
}