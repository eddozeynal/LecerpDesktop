namespace LecERP
{
    partial class Manp_Users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCenter = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeListPermissions = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.chkIsAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.chkIsActive = new DevExpress.XtraEditors.CheckEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnlExecution = new DevExpress.XtraEditors.PanelControl();
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpCenter)).BeginInit();
            this.grpCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPermissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlExecution)).BeginInit();
            this.pnlExecution.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCenter
            // 
            this.grpCenter.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpCenter.Appearance.Options.UseFont = true;
            this.grpCenter.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpCenter.AppearanceCaption.Options.UseFont = true;
            this.grpCenter.Controls.Add(this.groupControl1);
            this.grpCenter.Controls.Add(this.chkIsAdmin);
            this.grpCenter.Controls.Add(this.chkIsActive);
            this.grpCenter.Controls.Add(this.txtName);
            this.grpCenter.Controls.Add(this.txtUserName);
            this.grpCenter.Controls.Add(this.labelControl3);
            this.grpCenter.Controls.Add(this.labelControl2);
            this.grpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCenter.Location = new System.Drawing.Point(0, 0);
            this.grpCenter.Name = "grpCenter";
            this.grpCenter.Size = new System.Drawing.Size(543, 441);
            this.grpCenter.TabIndex = 0;
            this.grpCenter.Text = "İstifadəçi";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.treeListPermissions);
            this.groupControl1.Location = new System.Drawing.Point(12, 113);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(523, 323);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Səlahiyyətlər";
            // 
            // treeListPermissions
            // 
            this.treeListPermissions.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeListPermissions.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeListPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListPermissions.KeyFieldName = "Id";
            this.treeListPermissions.Location = new System.Drawing.Point(2, 23);
            this.treeListPermissions.Name = "treeListPermissions";
            this.treeListPermissions.OptionsPrint.PrintReportFooter = false;
            this.treeListPermissions.ParentFieldName = "ParentId";
            this.treeListPermissions.Size = new System.Drawing.Size(519, 298);
            this.treeListPermissions.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Səlahiyyət";
            this.treeListColumn1.FieldName = "Name_";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 346;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "İzn Verilir";
            this.treeListColumn2.FieldName = "IsPermitted";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 155;
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.Location = new System.Drawing.Point(348, 64);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Properties.Caption = "Admin";
            this.chkIsAdmin.Size = new System.Drawing.Size(75, 19);
            this.chkIsAdmin.TabIndex = 21;
            // 
            // chkIsActive
            // 
            this.chkIsActive.Location = new System.Drawing.Point(348, 38);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Properties.Caption = "Aktiv";
            this.chkIsActive.Size = new System.Drawing.Size(75, 19);
            this.chkIsActive.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 85);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(259, 22);
            this.txtName.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(130, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(141, 22);
            this.txtUserName.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "İstifadəçi Tam Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "İstifadəçi Adı";
            // 
            // pnlExecution
            // 
            this.pnlExecution.Controls.Add(this.lblError);
            this.pnlExecution.Controls.Add(this.btnCancel);
            this.pnlExecution.Controls.Add(this.btnOk);
            this.pnlExecution.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExecution.Location = new System.Drawing.Point(0, 441);
            this.pnlExecution.Name = "pnlExecution";
            this.pnlExecution.Size = new System.Drawing.Size(543, 43);
            this.pnlExecution.TabIndex = 1;
            this.pnlExecution.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlExecution_MouseDown);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblError.Location = new System.Drawing.Point(12, 15);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(288, 16);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "Error :";
            this.lblError.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblError_MouseDown);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::LecERP.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(425, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "İmtina Et";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.ImageOptions.Image = global::LecERP.Properties.Resources.apply_16x16;
            this.btnOk.Location = new System.Drawing.Point(306, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 32);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Yaddaşa Yaz";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Manp_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 484);
            this.Controls.Add(this.grpCenter);
            this.Controls.Add(this.pnlExecution);
            this.Name = "Manp_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Manp_Users_Load);
            this.Shown += new System.EventHandler(this.Manp_Users_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpCenter)).EndInit();
            this.grpCenter.ResumeLayout(false);
            this.grpCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlExecution)).EndInit();
            this.pnlExecution.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCenter;
        private DevExpress.XtraEditors.PanelControl pnlExecution;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraEditors.CheckEdit chkIsAdmin;
        private DevExpress.XtraEditors.CheckEdit chkIsActive;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTreeList.TreeList treeListPermissions;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
    }
}