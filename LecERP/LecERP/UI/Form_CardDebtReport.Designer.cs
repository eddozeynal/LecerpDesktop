namespace LecERP
{
    partial class Form_CardDebtReport
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
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grpTop = new DevExpress.XtraEditors.GroupControl();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dateBegin = new DevExpress.XtraEditors.DateEdit();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebtLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocationAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTown = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemDebitByBegDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemCreditByBegDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalInput = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalOutput = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemDebitByEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemCreditByEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
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
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(0, 58);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1151, 561);
            this.gcData.TabIndex = 4;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            this.gcData.DoubleClick += new System.EventHandler(this.gcData_DoubleClick);
            this.gcData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcData_KeyDown);
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDebtLimit,
            this.colTaxCode,
            this.colLocationAddress,
            this.colPhone2,
            this.colPhone3,
            this.colCountry,
            this.colCity,
            this.colTown,
            this.colDistrict,
            this.colIsActive,
            this.colCardTypeName,
            this.colCardNumber,
            this.colCardName,
            this.colExchangeName,
            this.colPhone1,
            this.colRemDebitByBegDate,
            this.colRemCreditByBegDate,
            this.colTotalInput,
            this.colTotalOutput,
            this.colRemDebitByEndDate,
            this.colRemCreditByEndDate});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // grpTop
            // 
            this.grpTop.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpTop.Appearance.Options.UseFont = true;
            this.grpTop.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpTop.AppearanceCaption.Options.UseFont = true;
            this.grpTop.CaptionImageOptions.Image = global::LecERP.Properties.Resources.groupfieldcollection_16x16;
            this.grpTop.Controls.Add(this.btnExcel);
            this.grpTop.Controls.Add(this.btnRefresh);
            this.grpTop.Controls.Add(this.panelControl2);
            this.grpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTop.Location = new System.Drawing.Point(0, 0);
            this.grpTop.Name = "grpTop";
            this.grpTop.Size = new System.Drawing.Size(1151, 58);
            this.grpTop.TabIndex = 3;
            this.grpTop.Text = "Seçimlər";
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExcel.ImageOptions.Image = global::LecERP.Properties.Resources.excel_16x16;
            this.btnExcel.Location = new System.Drawing.Point(1005, 23);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(72, 33);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.ImageOptions.Image = global::LecERP.Properties.Resources.refreshallpivottable_16x16;
            this.btnRefresh.Location = new System.Drawing.Point(1077, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 33);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Yenilə";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dateBegin);
            this.panelControl2.Controls.Add(this.dateEnd);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 23);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(352, 33);
            this.panelControl2.TabIndex = 6;
            // 
            // dateBegin
            // 
            this.dateBegin.EditValue = null;
            this.dateBegin.Location = new System.Drawing.Point(41, 8);
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
            this.dateBegin.TabIndex = 4;
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(195, 8);
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
            this.dateEnd.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tarix";
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
            // colDebtLimit
            // 
            this.colDebtLimit.Caption = "Borc Limiti";
            this.colDebtLimit.FieldName = "DebtLimit";
            this.colDebtLimit.Name = "colDebtLimit";
            this.colDebtLimit.OptionsColumn.AllowEdit = false;
            this.colDebtLimit.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDebtLimit.Width = 80;
            // 
            // colTaxCode
            // 
            this.colTaxCode.Caption = "VÖEN";
            this.colTaxCode.FieldName = "TaxCode";
            this.colTaxCode.Name = "colTaxCode";
            this.colTaxCode.OptionsColumn.AllowEdit = false;
            this.colTaxCode.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTaxCode.Width = 80;
            // 
            // colLocationAddress
            // 
            this.colLocationAddress.Caption = "Ünvan";
            this.colLocationAddress.FieldName = "LocationAddress";
            this.colLocationAddress.Name = "colLocationAddress";
            this.colLocationAddress.OptionsColumn.AllowEdit = false;
            this.colLocationAddress.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colLocationAddress.Width = 80;
            // 
            // colPhone2
            // 
            this.colPhone2.Caption = "Tel 2";
            this.colPhone2.FieldName = "Phone2";
            this.colPhone2.Name = "colPhone2";
            this.colPhone2.OptionsColumn.AllowEdit = false;
            this.colPhone2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPhone2.Width = 80;
            // 
            // colPhone3
            // 
            this.colPhone3.Caption = "Tel 3";
            this.colPhone3.FieldName = "Phone3";
            this.colPhone3.Name = "colPhone3";
            this.colPhone3.OptionsColumn.AllowEdit = false;
            this.colPhone3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPhone3.Width = 80;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "Ölkə";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.OptionsColumn.AllowEdit = false;
            this.colCountry.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCountry.Width = 80;
            // 
            // colCity
            // 
            this.colCity.Caption = "Şəhər";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.AllowEdit = false;
            this.colCity.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCity.Width = 80;
            // 
            // colTown
            // 
            this.colTown.Caption = "Rayon";
            this.colTown.FieldName = "Town";
            this.colTown.Name = "colTown";
            this.colTown.OptionsColumn.AllowEdit = false;
            this.colTown.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTown.Width = 80;
            // 
            // colDistrict
            // 
            this.colDistrict.Caption = "Qəsəbə";
            this.colDistrict.FieldName = "District";
            this.colDistrict.Name = "colDistrict";
            this.colDistrict.OptionsColumn.AllowEdit = false;
            this.colDistrict.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDistrict.Width = 80;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Aktiv";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.OptionsColumn.AllowEdit = false;
            this.colIsActive.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colIsActive.Width = 80;
            // 
            // colCardTypeName
            // 
            this.colCardTypeName.Caption = "Hesab Növü";
            this.colCardTypeName.FieldName = "CardTypeName";
            this.colCardTypeName.Name = "colCardTypeName";
            this.colCardTypeName.OptionsColumn.AllowEdit = false;
            this.colCardTypeName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCardTypeName.Visible = true;
            this.colCardTypeName.VisibleIndex = 0;
            this.colCardTypeName.Width = 90;
            // 
            // colCardNumber
            // 
            this.colCardNumber.Caption = "Hesab Kodu";
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.OptionsColumn.AllowEdit = false;
            this.colCardNumber.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 1;
            this.colCardNumber.Width = 80;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Hesab Adı";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 2;
            this.colCardName.Width = 150;
            // 
            // colExchangeName
            // 
            this.colExchangeName.Caption = "Məzənnə";
            this.colExchangeName.FieldName = "ExchangeName";
            this.colExchangeName.Name = "colExchangeName";
            this.colExchangeName.OptionsColumn.AllowEdit = false;
            this.colExchangeName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colExchangeName.Visible = true;
            this.colExchangeName.VisibleIndex = 3;
            this.colExchangeName.Width = 80;
            // 
            // colPhone1
            // 
            this.colPhone1.Caption = "Tel 1";
            this.colPhone1.FieldName = "Phone1";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.OptionsColumn.AllowEdit = false;
            this.colPhone1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPhone1.Visible = true;
            this.colPhone1.VisibleIndex = 4;
            this.colPhone1.Width = 80;
            // 
            // colRemDebitByBegDate
            // 
            this.colRemDebitByBegDate.Caption = "Əvvəlki Debit";
            this.colRemDebitByBegDate.FieldName = "RemDebitByBegDate";
            this.colRemDebitByBegDate.Name = "colRemDebitByBegDate";
            this.colRemDebitByBegDate.OptionsColumn.AllowEdit = false;
            this.colRemDebitByBegDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colRemDebitByBegDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colRemDebitByBegDate.Visible = true;
            this.colRemDebitByBegDate.VisibleIndex = 5;
            this.colRemDebitByBegDate.Width = 90;
            // 
            // colRemCreditByBegDate
            // 
            this.colRemCreditByBegDate.Caption = "Əvvəlki Kredit";
            this.colRemCreditByBegDate.FieldName = "RemCreditByBegDate";
            this.colRemCreditByBegDate.Name = "colRemCreditByBegDate";
            this.colRemCreditByBegDate.OptionsColumn.AllowEdit = false;
            this.colRemCreditByBegDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colRemCreditByBegDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colRemCreditByBegDate.Visible = true;
            this.colRemCreditByBegDate.VisibleIndex = 6;
            this.colRemCreditByBegDate.Width = 90;
            // 
            // colTotalInput
            // 
            this.colTotalInput.Caption = "Giriş Cəmi";
            this.colTotalInput.FieldName = "TotalInput";
            this.colTotalInput.Name = "colTotalInput";
            this.colTotalInput.OptionsColumn.AllowEdit = false;
            this.colTotalInput.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTotalInput.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalInput.Visible = true;
            this.colTotalInput.VisibleIndex = 7;
            this.colTotalInput.Width = 90;
            // 
            // colTotalOutput
            // 
            this.colTotalOutput.Caption = "Çıxış Cəmi";
            this.colTotalOutput.FieldName = "TotalOutput";
            this.colTotalOutput.Name = "colTotalOutput";
            this.colTotalOutput.OptionsColumn.AllowEdit = false;
            this.colTotalOutput.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTotalOutput.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalOutput.Visible = true;
            this.colTotalOutput.VisibleIndex = 8;
            this.colTotalOutput.Width = 90;
            // 
            // colRemDebitByEndDate
            // 
            this.colRemDebitByEndDate.Caption = "Son Debit";
            this.colRemDebitByEndDate.FieldName = "RemDebitByEndDate";
            this.colRemDebitByEndDate.Name = "colRemDebitByEndDate";
            this.colRemDebitByEndDate.OptionsColumn.AllowEdit = false;
            this.colRemDebitByEndDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colRemDebitByEndDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colRemDebitByEndDate.Visible = true;
            this.colRemDebitByEndDate.VisibleIndex = 9;
            this.colRemDebitByEndDate.Width = 90;
            // 
            // colRemCreditByEndDate
            // 
            this.colRemCreditByEndDate.Caption = "Son Kredit";
            this.colRemCreditByEndDate.FieldName = "RemCreditByEndDate";
            this.colRemCreditByEndDate.Name = "colRemCreditByEndDate";
            this.colRemCreditByEndDate.OptionsColumn.AllowEdit = false;
            this.colRemCreditByEndDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colRemCreditByEndDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colRemCreditByEndDate.Visible = true;
            this.colRemCreditByEndDate.VisibleIndex = 10;
            this.colRemCreditByEndDate.Width = 90;
            // 
            // Form_CardDebtReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 619);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.grpTop);
            this.Name = "Form_CardDebtReport";
            this.Text = "Form_CardDebtReport";
            this.Load += new System.EventHandler(this.Form_CardDebtReport_Load);
            this.Shown += new System.EventHandler(this.Form_CardDebtReport_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl grpTop;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.DateEdit dateBegin;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDebtLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone3;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colTown;
        private DevExpress.XtraGrid.Columns.GridColumn colDistrict;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colCardTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn colRemDebitByBegDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRemCreditByBegDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalInput;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalOutput;
        private DevExpress.XtraGrid.Columns.GridColumn colRemDebitByEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRemCreditByEndDate;
    }
}