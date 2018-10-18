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
    public partial class Manp_Users : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        User _User = null;
        List<PermissionMasterExt> PermissionMastersExt = null;
        public Manp_Users()
        {
            InitializeComponent();
        }

        private void Manp_Users_Load(object sender, EventArgs e)
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

        private void Manp_Users_Shown(object sender, EventArgs e)
        {
            PermissionMastersExt = new List<PermissionMasterExt>();

            Operation<List<PermissionMaster>> op_PermissionMasters = OperationHandler.GetPermissionMasters();
            if (!op_PermissionMasters.Successful)
            {
                OnLoadError(op_PermissionMasters.Fail);
                return;
            }

            foreach (PermissionMaster permissionMaster in op_PermissionMasters.Value)
                PermissionMastersExt.Add(permissionMaster.GetEligibleOjbect<PermissionMasterExt>());

            if (Id == 0)
            {
                _User = new User();
            }
            else
            {
                Operation<User> op_User = OperationHandler.GetUserById(Id);
                if (!op_User.Successful)
                {
                    OnLoadError(op_User.Fail);
                    return;
                }
                _User = op_User.Value;
                txtName.Text = _User.BaseUser.Name_;
                txtUserName.Text = _User.BaseUser.UserName;
                chkIsActive.Checked = _User.BaseUser.IsActive;
                chkIsAdmin.Checked = _User.BaseUser.IsAdmin;

                foreach (var permissionMastersExtItem in PermissionMastersExt)
                {
                    var detailObj = _User.PermissionDetails.Where(x => x.PermissionId == permissionMastersExtItem.Id).FirstOrDefault();
                    permissionMastersExtItem.IsPermitted = detailObj != null;
                }
            }
            treeListPermissions.DataSource = PermissionMastersExt.Where(x=>x.IsActive).ToList();
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

            foreach (var perMaster in PermissionMastersExt.Where(x=>x.IsPermitted))
            {
                PermissionDetail permissionDetail = new PermissionDetail();
                permissionDetail.CreatedBy = StaticData.CurrentUserId;
                permissionDetail.CreatedDate = DateTime.Now;
                permissionDetail.PermissionId = perMaster.Id;
                permissionDetail.UserId = Id;
                permissionDetails.Add(permissionDetail);
            }
            
            if (Id == 0)
            {
                _User.BaseUser = new BaseUser();
            }

            _User.PermissionDetails = permissionDetails;
            _User.BaseUser.IsActive = chkIsActive.Checked;
            _User.BaseUser.IsAdmin = chkIsAdmin.Checked;
            _User.BaseUser.Name_ = txtName.Text;
            _User.BaseUser.UserName = txtUserName.Text;
            Operation<User> operation = OperationHandler.PostUser(_User);
            if (operation.Successful) this.Close();
            lblError.Text = operation.Fail;
        }


        private void lblError_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(this.Handle);
        }
    }
}