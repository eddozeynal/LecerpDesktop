namespace LecERP
{
    partial class Manp_DataPermissions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manp_DataPermissions));
            this.grpCenter = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.searchLookUpCard = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddLine = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcLines = new DevExpress.XtraGrid.GridControl();
            this.gvLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rsp_Amount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.rse_Lenth = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.rse_Width = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpCenter)).BeginInit();
            this.grpCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsp_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rse_Lenth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rse_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCenter
            // 
            this.grpCenter.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpCenter.Appearance.Options.UseFont = true;
            this.grpCenter.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpCenter.AppearanceCaption.Options.UseFont = true;
            this.grpCenter.Controls.Add(this.btnDelete);
            this.grpCenter.Controls.Add(this.comboBoxEdit1);
            this.grpCenter.Controls.Add(this.searchLookUpCard);
            this.grpCenter.Controls.Add(this.labelControl4);
            this.grpCenter.Controls.Add(this.labelControl1);
            this.grpCenter.Controls.Add(this.btnAddLine);
            this.grpCenter.Controls.Add(this.groupControl1);
            this.grpCenter.Controls.Add(this.txtUserName);
            this.grpCenter.Controls.Add(this.labelControl2);
            this.grpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCenter.Location = new System.Drawing.Point(0, 0);
            this.grpCenter.Name = "grpCenter";
            this.grpCenter.Size = new System.Drawing.Size(621, 505);
            this.grpCenter.TabIndex = 1;
            this.grpCenter.Text = "İstifadəçi";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = global::LecERP.Properties.Resources.cancel_32x32;
            this.btnDelete.Location = new System.Drawing.Point(569, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(130, 66);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(198, 20);
            this.comboBoxEdit1.TabIndex = 45;
            // 
            // searchLookUpCard
            // 
            this.searchLookUpCard.Location = new System.Drawing.Point(130, 98);
            this.searchLookUpCard.Name = "searchLookUpCard";
            this.searchLookUpCard.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchLookUpCard.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpCard.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpCard.Properties.DisplayMember = "CardName";
            this.searchLookUpCard.Properties.NullText = "Seçin";
            this.searchLookUpCard.Properties.ValueMember = "Id";
            this.searchLookUpCard.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpCard.Size = new System.Drawing.Size(387, 22);
            this.searchLookUpCard.TabIndex = 44;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 16);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Hesab";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 16);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Növü";
            // 
            // btnAddLine
            // 
            this.btnAddLine.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLine.ImageOptions.Image")));
            this.btnAddLine.Location = new System.Drawing.Point(523, 90);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(40, 40);
            this.btnAddLine.TabIndex = 41;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.gcLines);
            this.groupControl1.Location = new System.Drawing.Point(12, 139);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(597, 359);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Səlahiyyətlər";
            // 
            // gcLines
            // 
            this.gcLines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcLines.Location = new System.Drawing.Point(2, 42);
            this.gcLines.MainView = this.gvLines;
            this.gcLines.Name = "gcLines";
            this.gcLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rsp_Amount,
            this.rse_Lenth,
            this.rse_Width});
            this.gcLines.Size = new System.Drawing.Size(593, 315);
            this.gcLines.TabIndex = 1;
            this.gcLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLines});
            // 
            // gvLines
            // 
            this.gvLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn8,
            this.gridColumn9});
            this.gvLines.GridControl = this.gcLines;
            this.gvLines.Name = "gvLines";
            this.gvLines.OptionsView.ColumnAutoWidth = false;
            this.gvLines.OptionsView.ShowFooter = true;
            this.gvLines.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Növü";
            this.gridColumn6.FieldName = "PermissionTypeName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 83;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Kodu";
            this.gridColumn2.FieldName = "PermissionCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 102;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Adı";
            this.gridColumn3.FieldName = "PermissionName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 229;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Level 1";
            this.gridColumn1.FieldName = "Level1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 50;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Level 2";
            this.gridColumn8.FieldName = "Level2";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 50;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.Caption = "Level 3";
            this.gridColumn9.FieldName = "Level3";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 50;
            // 
            // rsp_Amount
            // 
            this.rsp_Amount.AutoHeight = false;
            this.rsp_Amount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rsp_Amount.Name = "rsp_Amount";
            // 
            // rse_Lenth
            // 
            this.rse_Lenth.AutoHeight = false;
            this.rse_Lenth.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rse_Lenth.Name = "rse_Lenth";
            // 
            // rse_Width
            // 
            this.rse_Width.AutoHeight = false;
            this.rse_Width.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rse_Width.Name = "rse_Width";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(130, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(198, 22);
            this.txtUserName.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "İstifadəçi Adı";
            // 
            // Manp_DataPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 505);
            this.Controls.Add(this.grpCenter);
            this.Name = "Manp_DataPermissions";
            this.Text = "Məlumat Səlahiyyətləri";
            this.Load += new System.EventHandler(this.Manp_DataPermissions_Load);
            this.Shown += new System.EventHandler(this.Manp_DataPermissions_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpCenter)).EndInit();
            this.grpCenter.ResumeLayout(false);
            this.grpCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsp_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rse_Lenth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rse_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCenter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gcLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLines;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rsp_Amount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rse_Lenth;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit rse_Width;
        private DevExpress.XtraEditors.SimpleButton btnAddLine;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpCard;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}