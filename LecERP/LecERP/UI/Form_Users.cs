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
    public partial class Form_Users : DevExpress.XtraEditors.XtraForm
    {
        public Form_Users()
        {
            InitializeComponent();
        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            new Manp_Users().ShowDialog();
            RefreshData();
        }

        private void tsModify_Click(object sender, EventArgs e)
        {
            object objValue = gvData.GetFocusedRowCellValue("Id");
            if (objValue == null) return;
            Manp_Users manp_Users = new Manp_Users();
            manp_Users.Id = Convert.ToInt32(objValue);
            manp_Users.ShowDialog();
            RefreshData();
        }

        private void Form_Users_Load(object sender, EventArgs e)
        {
           
        }

        private void Form_Users_Shown(object sender, EventArgs e)
        {
            GridViewDesignHandler gvh = new GridViewDesignHandler();
            gvh.GridView = gvData;
            gvh.GridViewInfo = OperationHandler.GetGridViewInfo(16);
            gvh.SetView();
            RefreshData();
        }

        private void RefreshData()
        {
            Operation<List<BaseUser>> operation = OperationHandler.GetUsers();
            if (operation.Successful)
            {
                gcData.DataSource = operation.Value;
            }
            else
            {
                // Show Error
            }
        }
    }
}