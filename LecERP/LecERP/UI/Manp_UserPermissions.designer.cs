namespace LecERP
{
    partial class Manp_UserPermissions
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
            this.treeListPermissions = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pnlExecution = new DevExpress.XtraEditors.PanelControl();
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpCenter)).BeginInit();
            this.grpCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListPermissions)).BeginInit();
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
            this.grpCenter.Controls.Add(this.treeListPermissions);
            this.grpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCenter.Location = new System.Drawing.Point(0, 0);
            this.grpCenter.Name = "grpCenter";
            this.grpCenter.Size = new System.Drawing.Size(543, 441);
            this.grpCenter.TabIndex = 0;
            this.grpCenter.Text = "Səlahiyyətlər";
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
            this.treeListPermissions.Size = new System.Drawing.Size(539, 416);
            this.treeListPermissions.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Səlahiyyət";
            this.treeListColumn1.FieldName = "Name";
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
            this.btnCancel.ImageOptions.Image = global::LecERP.Properties.Resources.cancel_16x161;
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
            this.btnOk.ImageOptions.Image = global::LecERP.Properties.Resources.apply_16x161;
            this.btnOk.Location = new System.Drawing.Point(306, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 32);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Yaddaşa Yaz";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Manp_UserPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 484);
            this.Controls.Add(this.grpCenter);
            this.Controls.Add(this.pnlExecution);
            this.Name = "Manp_UserPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Manp_UserPermissions_Load);
            this.Shown += new System.EventHandler(this.Manp_UserPermissions_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpCenter)).EndInit();
            this.grpCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListPermissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlExecution)).EndInit();
            this.pnlExecution.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCenter;
        private DevExpress.XtraEditors.PanelControl pnlExecution;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraTreeList.TreeList treeListPermissions;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
    }
}