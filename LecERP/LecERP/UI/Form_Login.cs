using DevExpress.XtraEditors;
using LecERP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LecERP
{
	public partial class Form_Login : Form
	{
		public bool LoggedIn { get; private set; }
		
		

		public Form_Login()
		{
			InitializeComponent();
		}

		private void Form_Login_Load(object sender, EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
            Close();
		}

		void Login()
		{
            try
            {
                if (txtUsername.Text == string.Empty) { XtraMessageBox.Show("İstifadəçi adı daxil edin"); return; }
                if (txtPassword.Text == string.Empty) { XtraMessageBox.Show("Şifrə daxil edin"); return; }

                object lookUpConnectionsCurrentRow = lookUpConnections.GetSelectedDataRow();
                if (lookUpConnectionsCurrentRow == null) return;
                ConnectionConfiguration SelectedConfig = (lookUpConnectionsCurrentRow as ConnectionConfiguration);
                StaticData.CurrentConnectionConfiguration = SelectedConfig;

                Operation<UserView> operation = OperationHandler.LoginUser( new LoginData { Login = txtUsername.Text, PassHash = StaticData.Cryptor.Encrypt(txtPassword.Text) });
                if (operation.Successful)
                {
                    StaticData.CurrentUser = operation.Value;
                    PrivateProfileStringHandler.SetPrivateProfileString("USERNAME", txtUsername.Text);
                    Close();
                }
                else
                {
                    XtraMessageBox.Show(operation.Fail);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Bağlantı alınmadı /n" + ex.Message);
            }
        }

		private void txtUsername_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (txtUsername.Text.Length == 0) return;
				if (txtPassword.Text.Length == 0)
				{
					txtPassword.Focus();
				}
				else
				{
					Login();
				}
			}
			if (e.KeyCode == Keys.Escape) this.Close();
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Login();
			}
			if (e.KeyCode == Keys.Escape) this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
            
			Login();
		}

        private void Form_Login_Shown(object sender, EventArgs e)
        {
            try
            {
                txtUsername.Text = PrivateProfileStringHandler.ReadPrivateProfileString("USERNAME");
            }
            catch { }
            //if (txtUsername.Text.Length == 0) txtUsername.Text = Environment.UserName;
            txtPassword.Focus();

            lookUpConnections.Properties.DataSource = StaticData.ConnectionConfigurations;
            lookUpConnections.Properties.DisplayMember = "Name";
            lookUpConnections.ItemIndex = 0;

            //TO DO Test only
            //txtUsername.Text = "Admin";
            //txtPassword.Text = "000";

        }

        private void grpMain_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(Handle);
        }
    }
}
