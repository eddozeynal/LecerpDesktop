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
            RefreshData();
        }

        private void RefreshData()
        {
            Operation<List<User>> operation = OperationHandler.GetUsers();
            if (operation.Successful)
            {
                gcData.DataSource = operation.Value;
            }
            else
            {
                // Show Error
            }
        }

        private void tsDataPermissions_Click(object sender, EventArgs e)
        {
            object objValue = gvData.GetFocusedRowCellValue("Id");
            if (objValue == null) return;
            int userId = Convert.ToInt32(objValue);
            Manp_DataPermissions manp_dataper = new Manp_DataPermissions();
            manp_dataper.UserId = userId;
            manp_dataper.ShowDialog();
            RefreshData();
        }

        private void tsMenuPermissions_Click(object sender, EventArgs e)
        {
            object objValue = gvData.GetFocusedRowCellValue("Id");
            if (objValue == null) return;
            Manp_UserPermissions manp_Users = new Manp_UserPermissions();
            manp_Users.UserId = Convert.ToInt32(objValue);
            manp_Users.ShowDialog();
            RefreshData();
        }
    }
}