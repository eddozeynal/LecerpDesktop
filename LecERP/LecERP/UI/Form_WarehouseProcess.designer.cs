namespace LecERP
{
    partial class Form_WarehouseProcess
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
            this.components = new System.ComponentModel.Container();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBeginProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEndProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.tsViewFiches = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroup3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpTop = new DevExpress.XtraEditors.GroupControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateBegin = new DevExpress.XtraEditors.DateEdit();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            this.cmsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTop)).BeginInit();
            this.grpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcData
            // 
            this.gcData.ContextMenuStrip = this.cmsMain;
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(0, 58);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1153, 414);
            this.gcData.TabIndex = 0;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddNew,
            this.tsViewProcess,
            this.tsBeginProcess,
            this.tsEndProcess,
            this.tsViewFiches,
            this.tsDelete,
            this.tsExportToExcel});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(142, 158);
            // 
            // tsAddNew
            // 
            this.tsAddNew.Image = global::LecERP.Properties.Resources.newtask_16x16;
            this.tsAddNew.Name = "tsAddNew";
            this.tsAddNew.Size = new System.Drawing.Size(141, 22);
            this.tsAddNew.Text = "Yeni...";
            this.tsAddNew.Click += new System.EventHandler(this.tsAddNew_Click);
            // 
            // tsViewProcess
            // 
            this.tsViewProcess.Image = global::LecERP.Properties.Resources.rzs_thunder_24;
            this.tsViewProcess.Name = "tsViewProcess";
            this.tsViewProcess.Size = new System.Drawing.Size(141, 22);
            this.tsViewProcess.Text = "Əməliyyatlar";
            this.tsViewProcess.Click += new System.EventHandler(this.tsViewProcess_Click);
            // 
            // tsBeginProcess
            // 
            this.tsBeginProcess.Image = global::LecERP.Properties.Resources.next_32x32;
            this.tsBeginProcess.Name = "tsBeginProcess";
            this.tsBeginProcess.Size = new System.Drawing.Size(141, 22);
            this.tsBeginProcess.Text = "Başlat";
            this.tsBeginProcess.Click += new System.EventHandler(this.tsBeginProcess_Click);
            // 
            // tsEndProcess
            // 
            this.tsEndProcess.Image = global::LecERP.Properties.Resources.stop_32x32;
            this.tsEndProcess.Name = "tsEndProcess";
            this.tsEndProcess.Size = new System.Drawing.Size(141, 22);
            this.tsEndProcess.Text = "Bitir";
            this.tsEndProcess.Click += new System.EventHandler(this.tsEndProcess_Click);
            // 
            // tsViewFiches
            // 
            this.tsViewFiches.Image = global::LecERP.Properties.Resources.withtextwrapping_topcenter_16x16;
            this.tsViewFiches.Name = "tsViewFiches";
            this.tsViewFiches.Size = new System.Drawing.Size(141, 22);
            this.tsViewFiches.Text = "Sifarişlər";
            this.tsViewFiches.Click += new System.EventHandler(this.tstsViewFiches_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = global::LecERP.Properties.Resources.deletetable_16x16;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(141, 22);
            this.tsDelete.Text = "Sil";
            // 
            // tsExportToExcel
            // 
            this.tsExportToExcel.Image = global::LecERP.Properties.Resources.excel_16x16;
            this.tsExportToExcel.Name = "tsExportToExcel";
            this.tsExportToExcel.Size = new System.Drawing.Size(141, 22);
            this.tsExportToExcel.Text = "Excel-ə çıxar";
            this.tsExportToExcel.Click += new System.EventHandler(this.tsExportToExcel_Click);
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colItemTypeName,
            this.colItemCode,
            this.colItemName,
            this.colGroup1,
            this.colGroup2,
            this.colGroup3});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colId.Width = 80;
            // 
            // colItemTypeName
            // 
            this.colItemTypeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemTypeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemTypeName.Caption = "Proses No";
            this.colItemTypeName.FieldName = "Id";
            this.colItemTypeName.Name = "colItemTypeName";
            this.colItemTypeName.OptionsColumn.AllowEdit = false;
            this.colItemTypeName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colItemTypeName.Visible = true;
            this.colItemTypeName.VisibleIndex = 0;
            this.colItemTypeName.Width = 80;
            // 
            // colItemCode
            // 
            this.colItemCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemCode.Caption = "Proses Tarixi";
            this.colItemCode.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.colItemCode.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colItemCode.FieldName = "CreatedDate";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 128;
            // 
            // colItemName
            // 
            this.colItemName.AppearanceHeader.Options.UseTextOptions = true;
            this.colItemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colItemName.Caption = "Status";
            this.colItemName.FieldName = "StatusName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 130;
            // 
            // colGroup1
            // 
            this.colGroup1.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroup1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroup1.Caption = "İstifadəçi";
            this.colGroup1.FieldName = "UserName";
            this.colGroup1.Name = "colGroup1";
            this.colGroup1.OptionsColumn.AllowEdit = false;
            this.colGroup1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colGroup1.Visible = true;
            this.colGroup1.VisibleIndex = 3;
            this.colGroup1.Width = 80;
            // 
            // colGroup2
            // 
            this.colGroup2.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroup2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroup2.Caption = "Proses Başlama Tarixi";
            this.colGroup2.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.colGroup2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGroup2.FieldName = "ProcessBeginDate";
            this.colGroup2.Name = "colGroup2";
            this.colGroup2.OptionsColumn.AllowEdit = false;
            this.colGroup2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colGroup2.Visible = true;
            this.colGroup2.VisibleIndex = 4;
            this.colGroup2.Width = 141;
            // 
            // colGroup3
            // 
            this.colGroup3.AppearanceHeader.Options.UseTextOptions = true;
            this.colGroup3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGroup3.Caption = "Proses Bitmə Tarixi";
            this.colGroup3.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.colGroup3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colGroup3.FieldName = "ProcessEndDate";
            this.colGroup3.Name = "colGroup3";
            this.colGroup3.OptionsColumn.AllowEdit = false;
            this.colGroup3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colGroup3.Visible = true;
            this.colGroup3.VisibleIndex = 5;
            this.colGroup3.Width = 143;
            // 
            // grpTop
            // 
            this.grpTop.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpTop.Appearance.Options.UseFont = true;
            this.grpTop.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpTop.AppearanceCaption.Options.UseFont = true;
            this.grpTop.CaptionImageOptions.Image = global::LecERP.Properties.Resources.groupfieldcollection_16x16;
            this.grpTop.Controls.Add(this.btnRefresh);
            this.grpTop.Controls.Add(this.panelControl2);
            this.grpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTop.Location = new System.Drawing.Point(0, 0);
            this.grpTop.Name = "grpTop";
            this.grpTop.Size = new System.Drawing.Size(1153, 58);
            this.grpTop.TabIndex = 1;
            this.grpTop.Text = "Seçimlər";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.ImageOptions.Image = global::LecERP.Properties.Resources.recurrence_32x32;
            this.btnRefresh.Location = new System.Drawing.Point(1062, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 33);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Yenilə";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.dateBegin);
            this.panelControl2.Controls.Add(this.dateEnd);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 23);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(402, 33);
            this.panelControl2.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Proses Tarixi";
            // 
            // dateBegin
            // 
            this.dateBegin.EditValue = null;
            this.dateBegin.Location = new System.Drawing.Point(93, 8);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBegin.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateBegin.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateBegin.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm:ss";
            this.dateBegin.Size = new System.Drawing.Size(150, 20);
            this.dateBegin.TabIndex = 2;
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(247, 8);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEnd.Properties.EditFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.dateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEnd.Properties.Mask.EditMask = "dd.MM.yyyy HH:mm:ss";
            this.dateEnd.Size = new System.Drawing.Size(150, 20);
            this.dateEnd.TabIndex = 3;
            // 
            // Form_WarehouseProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 472);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.grpTop);
            this.Name = "Form_WarehouseProcess";
            this.Text = "Form_WarehouseProcess";
            this.Load += new System.EventHandler(this.Form_WarehouseProcess_Load);
            this.Shown += new System.EventHandler(this.Form_WarehouseProcess_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTop)).EndInit();
            this.grpTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsViewFiches;
        private System.Windows.Forms.ToolStripMenuItem tsDelete;
        private System.Windows.Forms.ToolStripMenuItem tsExportToExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup2;
        private DevExpress.XtraGrid.Columns.GridColumn colGroup3;
        private DevExpress.XtraEditors.GroupControl grpTop;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateBegin;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private System.Windows.Forms.ToolStripMenuItem tsViewProcess;
        private System.Windows.Forms.ToolStripMenuItem tsBeginProcess;
        private System.Windows.Forms.ToolStripMenuItem tsEndProcess;
    }
}