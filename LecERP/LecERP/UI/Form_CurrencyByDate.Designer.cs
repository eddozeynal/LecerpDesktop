namespace LecERP
{
    partial class Form_CurrencyByDate
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
            this.tsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestinationWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSourceFicheId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            this.cmsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gcData
            // 
            this.gcData.ContextMenuStrip = this.cmsMain;
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(0, 0);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1115, 550);
            this.gcData.TabIndex = 3;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddNew,
            this.tsDelete,
            this.tsExportToExcel});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(139, 70);
            // 
            // tsAddNew
            // 
            this.tsAddNew.Image = global::LecERP.Properties.Resources.newtask_16x16;
            this.tsAddNew.Name = "tsAddNew";
            this.tsAddNew.Size = new System.Drawing.Size(138, 22);
            this.tsAddNew.Text = "Yeni...";
            this.tsAddNew.Click += new System.EventHandler(this.tsAddNew_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = global::LecERP.Properties.Resources.deletetable_16x16;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(138, 22);
            this.tsDelete.Text = "Sil";
            // 
            // tsExportToExcel
            // 
            this.tsExportToExcel.Image = global::LecERP.Properties.Resources.excel_16x16;
            this.tsExportToExcel.Name = "tsExportToExcel";
            this.tsExportToExcel.Size = new System.Drawing.Size(138, 22);
            this.tsExportToExcel.Text = "Excel-ə çıxar";
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDocTypeId,
            this.colCardId,
            this.colDestinationWarehouse,
            this.colExchangeId,
            this.colCreatedBy,
            this.colStatus_,
            this.colSourceFicheId,
            this.colCreatedDate,
            this.colRate,
            this.colExchangeName,
            this.colWeightTotal});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colId.Width = 80;
            // 
            // colDocTypeId
            // 
            this.colDocTypeId.FieldName = "DocTypeId";
            this.colDocTypeId.Name = "colDocTypeId";
            this.colDocTypeId.OptionsColumn.AllowEdit = false;
            this.colDocTypeId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDocTypeId.Width = 80;
            // 
            // colCardId
            // 
            this.colCardId.FieldName = "CardId";
            this.colCardId.Name = "colCardId";
            this.colCardId.OptionsColumn.AllowEdit = false;
            this.colCardId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCardId.Width = 80;
            // 
            // colDestinationWarehouse
            // 
            this.colDestinationWarehouse.FieldName = "DestinationWarehouse";
            this.colDestinationWarehouse.Name = "colDestinationWarehouse";
            this.colDestinationWarehouse.OptionsColumn.AllowEdit = false;
            this.colDestinationWarehouse.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDestinationWarehouse.Width = 80;
            // 
            // colExchangeId
            // 
            this.colExchangeId.FieldName = "ExchangeId";
            this.colExchangeId.Name = "colExchangeId";
            this.colExchangeId.OptionsColumn.AllowEdit = false;
            this.colExchangeId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colExchangeId.Width = 80;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.OptionsColumn.AllowEdit = false;
            this.colCreatedBy.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCreatedBy.Width = 80;
            // 
            // colStatus_
            // 
            this.colStatus_.FieldName = "Status_";
            this.colStatus_.Name = "colStatus_";
            this.colStatus_.OptionsColumn.AllowEdit = false;
            this.colStatus_.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colStatus_.Width = 80;
            // 
            // colSourceFicheId
            // 
            this.colSourceFicheId.FieldName = "SourceFicheId";
            this.colSourceFicheId.Name = "colSourceFicheId";
            this.colSourceFicheId.OptionsColumn.AllowEdit = false;
            this.colSourceFicheId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSourceFicheId.Width = 80;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.Caption = "Tarix";
            this.colCreatedDate.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.colCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCreatedDate.FieldName = "Date";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.OptionsColumn.AllowEdit = false;
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 0;
            this.colCreatedDate.Width = 120;
            // 
            // colRate
            // 
            this.colRate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRate.Caption = "Nisbət";
            this.colRate.FieldName = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.OptionsColumn.AllowEdit = false;
            this.colRate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colRate.Visible = true;
            this.colRate.VisibleIndex = 2;
            this.colRate.Width = 80;
            // 
            // colExchangeName
            // 
            this.colExchangeName.Caption = "Məzənnə";
            this.colExchangeName.FieldName = "CurrencyName";
            this.colExchangeName.Name = "colExchangeName";
            this.colExchangeName.OptionsColumn.AllowEdit = false;
            this.colExchangeName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colExchangeName.Visible = true;
            this.colExchangeName.VisibleIndex = 1;
            this.colExchangeName.Width = 69;
            // 
            // colWeightTotal
            // 
            this.colWeightTotal.Caption = "Çəki";
            this.colWeightTotal.FieldName = "WeightTotal";
            this.colWeightTotal.Name = "colWeightTotal";
            this.colWeightTotal.OptionsColumn.AllowEdit = false;
            this.colWeightTotal.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colWeightTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colWeightTotal.Width = 80;
            // 
            // Form_CurrencyByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 550);
            this.Controls.Add(this.gcData);
            this.Name = "Form_CurrencyByDate";
            this.Text = "Form_CurrencyByDate";
            this.Load += new System.EventHandler(this.Form_CurrencyByDate_Load);
            this.Shown += new System.EventHandler(this.Form_CurrencyByDate_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDocTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colCardId;
        private DevExpress.XtraGrid.Columns.GridColumn colDestinationWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus_;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceFicheId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRate;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeName;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightTotal;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsDelete;
        private System.Windows.Forms.ToolStripMenuItem tsExportToExcel;
    }
}