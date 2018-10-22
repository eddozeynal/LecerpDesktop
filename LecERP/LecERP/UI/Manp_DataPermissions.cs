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
    public partial class Manp_DataPermissions : DevExpress.XtraEditors.XtraForm
    {
        int userId = 0;
        public Manp_DataPermissions( int _userId)
        {
            InitializeComponent();
            userId = _userId;
        }

        void RefreshPermissionsView()
        {
            var data = OperationHandler.GetUserDataPermissionView(userId);
            if (data.Successful)
            {
                gcLines.DataSource = data.Value;
            }

            var op_CardMaster = OperationHandler.GetAllCards();
            if (op_CardMaster.Successful)
            {
                searchLookUpCard.Properties.DataSource = op_CardMaster.Value.Where(x => x.CardType == 4).ToList();
            }

            GridViewDesignHandler gvh = new GridViewDesignHandler();
            gvh.GridView = searchLookUpCard.Properties.View;
            gvh.GridViewInfo = OperationHandler.GetGridViewInfo(14);
            gvh.SetView();
        }

        private void Manp_DataPermissions_Load(object sender, EventArgs e)
        {

        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            object objValue = searchLookUpCard.EditValue;
            if (objValue == null) return;
            DataPermission datapermission = new DataPermission();
            datapermission.CreatedBy = StaticData.CurrentUserId;
            datapermission.CreatedDate = DateTime.Now;
            datapermission.SourceType = 1;
            datapermission.SourceId = userId;
            datapermission.PermissionType = 1;
            datapermission.PermissionId = Convert.ToInt32(objValue);
            Operation<DataPermission> operation = OperationHandler.PostDataPermission(datapermission);
            if (!operation.Successful)
            {
                MessageBox.Show(operation.Fail);
            }
            RefreshPermissionsView();
        }

        private void Manp_DataPermissions_Shown(object sender, EventArgs e)
        {
            RefreshPermissionsView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            object objId = gvLines.GetFocusedRow();
            if (objId == null) return;
            int Id = (objId as DataPermission).Id;
            Operation<int> operation = OperationHandler.DeleteDataPermission(Id);
            if (!operation.Successful)
            {
                MessageBox.Show(operation.Fail);
            }
            RefreshPermissionsView();
        }
    }
}