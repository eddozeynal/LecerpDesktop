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
    public partial class Manp_Users : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        DataObjectBindTool<User> objectBindTool = new DataObjectBindTool<User>();
        //User _User = null;
        public Manp_Users()
        {
            InitializeComponent();
        }

        private void Manp_Users_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        void OnLoadError(string Message)
        {
            grpCenter.Enabled = false;
            btnOk.Enabled = false;
            if (Message == null) Message = "Unknown Error";
            XtraMessageBox.Show(Message);
        }

        private void Manp_Users_Shown(object sender, EventArgs e)
        {
            User user = new User();
            objectBindTool.BindControl(txtLogin, nameof(user.Login));
            objectBindTool.BindControl(txtUserName, nameof(user.UserName));
            objectBindTool.BindControl(chkIsActive, nameof(user.IsActive));
            objectBindTool.BindControl(chkIsAdmin, nameof(user.IsAdmin));
            if (Id != 0) user = OperationHandler.GetUserById(Id).Value;
            if (user == null) OnLoadError(null);
            if (user.Id == 0)
            {

            }
            else
            {
                txtLogin.ReadOnly = true;
            }
            objectBindTool.DataObject = user;
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
            User user = objectBindTool.DataObject;
            Operation<User> operation = OperationHandler.PostUser(user);
            if (operation.Successful)
            {
                this.Close();
            }
            else
            {
                XtraMessageBox.Show(operation.Fail);
            }
        }


        private void lblError_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(this.Handle);
        }
    }
}