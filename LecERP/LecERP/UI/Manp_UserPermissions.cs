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
using LecERP.ViewModels;
using LecERP.Models;

namespace LecERP
{
    public partial class Manp_UserPermissions : DevExpress.XtraEditors.XtraForm
    {
        public int UserId { get; set; }
        List<PermissionMasterView> Permissions = null;
        public Manp_UserPermissions()
        {
            InitializeComponent();
        }

        private void Manp_UserPermissions_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            lblError.Text = "";
        }

        void OnLoadError(string Message)
        {
            grpCenter.Enabled = false;
            btnOk.Enabled = false;
            if (Message == null) Message = "Unknown Error";
            lblError.Text = "Error : " + Message;
        }

        private void Manp_UserPermissions_Shown(object sender, EventArgs e)
        {
            Operation<List<PermissionMasterView>> op_PermissionMasters = OperationHandler.GetUserPermissions(UserId);
            if (!op_PermissionMasters.Successful)
            {
                OnLoadError(op_PermissionMasters.Fail);
                return;
            }
            Permissions = op_PermissionMasters.Value;
            treeListPermissions.DataSource = Permissions;
        }

        private void pnlExecution_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(this.Handle);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (UIFunctions.CheckCancellation()) Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<PermissionDetail> permissionDetails = new List<PermissionDetail>();

            foreach (var perMaster in Permissions.Where(x => x.IsPermitted))
            {
                PermissionDetail permissionDetail = new PermissionDetail
                {
                    CreatedBy = StaticData.CurrentUserId,
                    CreatedDate = DateTime.Now,
                    PermissionId = perMaster.Id,
                    UserId = UserId
                };
                permissionDetails.Add(permissionDetail);
            }

            Operation<string> operation = OperationHandler.PostUserPermissions(UserId,permissionDetails);
            if (operation.Successful) this.Close();
            lblError.Text = operation.Fail;
        }


        private void lblError_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(this.Handle);
        }
    }
}