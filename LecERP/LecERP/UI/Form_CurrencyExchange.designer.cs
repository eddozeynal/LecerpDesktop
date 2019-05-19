﻿namespace LecERP
{
    partial class Form_CurrencyExchange
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
            this.grpTop = new DevExpress.XtraEditors.GroupControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateBegin = new DevExpress.XtraEditors.DateEdit();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrintDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFicheno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSourceCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSourceCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpTop)).BeginInit();
            this.grpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            this.cmsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
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
            this.grpTop.Size = new System.Drawing.Size(1075, 58);
            this.grpTop.TabIndex = 0;
            this.grpTop.Text = "Seçimlər";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.ImageOptions.Image = global::LecERP.Properties.Resources.refreshallpivottable_16x16;
            this.btnRefresh.Location = new System.Drawing.Point(1001, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 33);
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
            this.panelControl2.Size = new System.Drawing.Size(425, 33);
            this.panelControl2.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Əməliyyat Tarixi";
            // 
            // dateBegin
            // 
            this.dateBegin.EditValue = null;
            this.dateBegin.Location = new System.Drawing.Point(110, 8);
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
            this.dateEnd.Location = new System.Drawing.Point(264, 8);
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
            // gcData
            // 
            this.gcData.ContextMenuStrip = this.cmsMain;
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(0, 58);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1075, 373);
            this.gcData.TabIndex = 2;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddNew,
            this.tsView,
            this.tsModify,
            this.tsDelete,
            this.tsExportToExcel,
            this.tsPrintDocument});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(139, 136);
            // 
            // tsAddNew
            // 
            this.tsAddNew.Image = global::LecERP.Properties.Resources.newtask_16x16;
            this.tsAddNew.Name = "tsAddNew";
            this.tsAddNew.Size = new System.Drawing.Size(138, 22);
            this.tsAddNew.Text = "Yeni...";
            this.tsAddNew.Click += new System.EventHandler(this.tsAddNew_Click);
            // 
            // tsView
            // 
            this.tsView.Image = global::LecERP.Properties.Resources.show_32x32;
            this.tsView.Name = "tsView";
            this.tsView.Size = new System.Drawing.Size(138, 22);
            this.tsView.Text = "Baxış";
            this.tsView.Click += new System.EventHandler(this.tsView_Click);
            // 
            // tsModify
            // 
            this.tsModify.Image = global::LecERP.Properties.Resources.pagesetup_16x16;
            this.tsModify.Name = "tsModify";
            this.tsModify.Size = new System.Drawing.Size(138, 22);
            this.tsModify.Text = "Düzəliş Et";
            this.tsModify.Click += new System.EventHandler(this.tsModify_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = global::LecERP.Properties.Resources.deletetable_16x16;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(138, 22);
            this.tsDelete.Text = "Sil";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // tsExportToExcel
            // 
            this.tsExportToExcel.Image = global::LecERP.Properties.Resources.excel_16x16;
            this.tsExportToExcel.Name = "tsExportToExcel";
            this.tsExportToExcel.Size = new System.Drawing.Size(138, 22);
            this.tsExportToExcel.Text = "Excel-ə çıxar";
            this.tsExportToExcel.Click += new System.EventHandler(this.tsExportToExcel_Click);
            // 
            // tsPrintDocument
            // 
            this.tsPrintDocument.Image = global::LecERP.Properties.Resources.printer_16x16;
            this.tsPrintDocument.Name = "tsPrintDocument";
            this.tsPrintDocument.Size = new System.Drawing.Size(138, 22);
            this.tsPrintDocument.Text = "Çap Et";
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFicheno,
            this.colSourceCardNumber,
            this.colSourceCardName,
            this.colDestCardNumber,
            this.colDestCardName,
            this.colTotal,
            this.colExchangeName,
            this.colUserName,
            this.colNote,
            this.colCreatedDate,
            this.gridColumn1});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colId.Width = 80;
            // 
            // colFicheno
            // 
            this.colFicheno.AppearanceHeader.Options.UseTextOptions = true;
            this.colFicheno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFicheno.Caption = "Əməliyyat No";
            this.colFicheno.FieldName = "Ficheno";
            this.colFicheno.Name = "colFicheno";
            this.colFicheno.OptionsColumn.AllowEdit = false;
            this.colFicheno.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFicheno.Visible = true;
            this.colFicheno.VisibleIndex = 0;
            this.colFicheno.Width = 80;
            // 
            // colSourceCardNumber
            // 
            this.colSourceCardNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colSourceCardNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSourceCardNumber.Caption = "Hesab Koddan";
            this.colSourceCardNumber.FieldName = "SourceCardNumber";
            this.colSourceCardNumber.Name = "colSourceCardNumber";
            this.colSourceCardNumber.OptionsColumn.AllowEdit = false;
            this.colSourceCardNumber.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSourceCardNumber.Visible = true;
            this.colSourceCardNumber.VisibleIndex = 1;
            this.colSourceCardNumber.Width = 80;
            // 
            // colSourceCardName
            // 
            this.colSourceCardName.AppearanceHeader.Options.UseTextOptions = true;
            this.colSourceCardName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSourceCardName.Caption = "Hesab Addan";
            this.colSourceCardName.FieldName = "SourceCardName";
            this.colSourceCardName.Name = "colSourceCardName";
            this.colSourceCardName.OptionsColumn.AllowEdit = false;
            this.colSourceCardName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSourceCardName.Visible = true;
            this.colSourceCardName.VisibleIndex = 2;
            this.colSourceCardName.Width = 80;
            // 
            // colDestCardNumber
            // 
            this.colDestCardNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.colDestCardNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDestCardNumber.Caption = "Hesab Koda";
            this.colDestCardNumber.FieldName = "DestCardNumber";
            this.colDestCardNumber.Name = "colDestCardNumber";
            this.colDestCardNumber.OptionsColumn.AllowEdit = false;
            this.colDestCardNumber.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDestCardNumber.Visible = true;
            this.colDestCardNumber.VisibleIndex = 4;
            this.colDestCardNumber.Width = 80;
            // 
            // colDestCardName
            // 
            this.colDestCardName.AppearanceHeader.Options.UseTextOptions = true;
            this.colDestCardName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDestCardName.Caption = "Hesab Ada";
            this.colDestCardName.FieldName = "DestCardName";
            this.colDestCardName.Name = "colDestCardName";
            this.colDestCardName.OptionsColumn.AllowEdit = false;
            this.colDestCardName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDestCardName.Visible = true;
            this.colDestCardName.VisibleIndex = 5;
            this.colDestCardName.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.Caption = "X.O. Məbləğ";
            this.colTotal.FieldName = "SourceTotal";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            this.colTotal.Width = 80;
            // 
            // colExchangeName
            // 
            this.colExchangeName.AppearanceHeader.Options.UseTextOptions = true;
            this.colExchangeName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colExchangeName.Caption = "Nisbət";
            this.colExchangeName.FieldName = "CurrencyRate";
            this.colExchangeName.Name = "colExchangeName";
            this.colExchangeName.OptionsColumn.AllowEdit = false;
            this.colExchangeName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colExchangeName.Visible = true;
            this.colExchangeName.VisibleIndex = 7;
            this.colExchangeName.Width = 66;
            // 
            // colUserName
            // 
            this.colUserName.AppearanceHeader.Options.UseTextOptions = true;
            this.colUserName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUserName.Caption = "İstifadəçi";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 8;
            this.colUserName.Width = 80;
            // 
            // colNote
            // 
            this.colNote.AppearanceHeader.Options.UseTextOptions = true;
            this.colNote.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNote.Caption = "Qeyd";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsColumn.AllowEdit = false;
            this.colNote.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 9;
            this.colNote.Width = 80;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colCreatedDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCreatedDate.Caption = "Tarix";
            this.colCreatedDate.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.colCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.OptionsColumn.AllowEdit = false;
            this.colCreatedDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 10;
            this.colCreatedDate.Width = 120;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "D.O. Məbləğ";
            this.gridColumn1.FieldName = "DestTotal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // Form_CurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 431);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.grpTop);
            this.Name = "Form_CurrencyExchange";
            this.Text = "Form_CurrencyExchange";
            this.Load += new System.EventHandler(this.Form_CurrencyExchange_Load);
            this.Shown += new System.EventHandler(this.Form_CurrencyExchange_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpTop)).EndInit();
            this.grpTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpTop;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.DateEdit dateBegin;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsModify;
        private System.Windows.Forms.ToolStripMenuItem tsDelete;
        private System.Windows.Forms.ToolStripMenuItem tsExportToExcel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsView;
        private System.Windows.Forms.ToolStripMenuItem tsPrintDocument;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFicheno;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colDestCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDestCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}