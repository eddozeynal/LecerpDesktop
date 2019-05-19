namespace LecERP
{
    partial class Form_Cards
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
            this.tsModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebtLimit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrencyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocationAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTown = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gcData.Size = new System.Drawing.Size(1049, 571);
            this.gcData.TabIndex = 1;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddNew,
            this.tsModify,
            this.tsDelete,
            this.tsExportToExcel});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(139, 92);
            // 
            // tsAddNew
            // 
            this.tsAddNew.Image = global::LecERP.Properties.Resources.newtask_16x16;
            this.tsAddNew.Name = "tsAddNew";
            this.tsAddNew.Size = new System.Drawing.Size(138, 22);
            this.tsAddNew.Text = "Yeni...";
            this.tsAddNew.Click += new System.EventHandler(this.tsAddNew_Click);
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
            // 
            // tsExportToExcel
            // 
            this.tsExportToExcel.Image = global::LecERP.Properties.Resources.excel_16x16;
            this.tsExportToExcel.Name = "tsExportToExcel";
            this.tsExportToExcel.Size = new System.Drawing.Size(138, 22);
            this.tsExportToExcel.Text = "Excel-ə çıxar";
            this.tsExportToExcel.Click += new System.EventHandler(this.tsExportToExcel_Click);
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCardTypeName,
            this.colCardNumber,
            this.colCardName,
            this.colDebtLimit,
            this.colCurrencyName,
            this.colTaxCode,
            this.colLocationAddress,
            this.colPhone1,
            this.colPhone2,
            this.colPhone3,
            this.colCountry,
            this.colCity,
            this.colTown,
            this.colDistrict,
            this.colIsActive});
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
            // colCardTypeName
            // 
            this.colCardTypeName.Caption = "Hesab Növü";
            this.colCardTypeName.FieldName = "CardTypeName";
            this.colCardTypeName.Name = "colCardTypeName";
            this.colCardTypeName.OptionsColumn.AllowEdit = false;
            this.colCardTypeName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCardTypeName.Visible = true;
            this.colCardTypeName.VisibleIndex = 0;
            this.colCardTypeName.Width = 80;
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
            this.colCardName.Width = 80;
            // 
            // colDebtLimit
            // 
            this.colDebtLimit.Caption = "Borc Limiti";
            this.colDebtLimit.FieldName = "DebtLimit";
            this.colDebtLimit.Name = "colDebtLimit";
            this.colDebtLimit.OptionsColumn.AllowEdit = false;
            this.colDebtLimit.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDebtLimit.Visible = true;
            this.colDebtLimit.VisibleIndex = 3;
            this.colDebtLimit.Width = 80;
            // 
            // colCurrencyName
            // 
            this.colCurrencyName.Caption = "Məzənnə";
            this.colCurrencyName.FieldName = "CurrencyName";
            this.colCurrencyName.Name = "colCurrencyName";
            this.colCurrencyName.OptionsColumn.AllowEdit = false;
            this.colCurrencyName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCurrencyName.Visible = true;
            this.colCurrencyName.VisibleIndex = 4;
            this.colCurrencyName.Width = 80;
            // 
            // colTaxCode
            // 
            this.colTaxCode.Caption = "VÖEN";
            this.colTaxCode.FieldName = "TaxCode";
            this.colTaxCode.Name = "colTaxCode";
            this.colTaxCode.OptionsColumn.AllowEdit = false;
            this.colTaxCode.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTaxCode.Visible = true;
            this.colTaxCode.VisibleIndex = 5;
            this.colTaxCode.Width = 80;
            // 
            // colLocationAddress
            // 
            this.colLocationAddress.Caption = "Ünvan";
            this.colLocationAddress.FieldName = "LocationAddress";
            this.colLocationAddress.Name = "colLocationAddress";
            this.colLocationAddress.OptionsColumn.AllowEdit = false;
            this.colLocationAddress.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colLocationAddress.Visible = true;
            this.colLocationAddress.VisibleIndex = 6;
            this.colLocationAddress.Width = 80;
            // 
            // colPhone1
            // 
            this.colPhone1.Caption = "Tel 1";
            this.colPhone1.FieldName = "Phone1";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.OptionsColumn.AllowEdit = false;
            this.colPhone1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPhone1.Visible = true;
            this.colPhone1.VisibleIndex = 7;
            this.colPhone1.Width = 80;
            // 
            // colPhone2
            // 
            this.colPhone2.Caption = "Tel 2";
            this.colPhone2.FieldName = "Phone2";
            this.colPhone2.Name = "colPhone2";
            this.colPhone2.OptionsColumn.AllowEdit = false;
            this.colPhone2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPhone2.Visible = true;
            this.colPhone2.VisibleIndex = 8;
            this.colPhone2.Width = 80;
            // 
            // colPhone3
            // 
            this.colPhone3.Caption = "Tel 3";
            this.colPhone3.FieldName = "Phone3";
            this.colPhone3.Name = "colPhone3";
            this.colPhone3.OptionsColumn.AllowEdit = false;
            this.colPhone3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPhone3.Visible = true;
            this.colPhone3.VisibleIndex = 9;
            this.colPhone3.Width = 80;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "Ölkə";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.OptionsColumn.AllowEdit = false;
            this.colCountry.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 10;
            this.colCountry.Width = 80;
            // 
            // colCity
            // 
            this.colCity.Caption = "Şəhər";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.AllowEdit = false;
            this.colCity.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 11;
            this.colCity.Width = 80;
            // 
            // colTown
            // 
            this.colTown.Caption = "Rayon";
            this.colTown.FieldName = "Town";
            this.colTown.Name = "colTown";
            this.colTown.OptionsColumn.AllowEdit = false;
            this.colTown.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTown.Visible = true;
            this.colTown.VisibleIndex = 12;
            this.colTown.Width = 80;
            // 
            // colDistrict
            // 
            this.colDistrict.Caption = "Qəsəbə";
            this.colDistrict.FieldName = "District";
            this.colDistrict.Name = "colDistrict";
            this.colDistrict.OptionsColumn.AllowEdit = false;
            this.colDistrict.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDistrict.Visible = true;
            this.colDistrict.VisibleIndex = 13;
            this.colDistrict.Width = 80;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "Aktiv";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.OptionsColumn.AllowEdit = false;
            this.colIsActive.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 14;
            this.colIsActive.Width = 80;
            // 
            // Form_Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 571);
            this.Controls.Add(this.gcData);
            this.Name = "Form_Cards";
            this.Text = "Form_Cards";
            this.Load += new System.EventHandler(this.Form_Cards_Load);
            this.Shown += new System.EventHandler(this.Form_Cards_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            this.cmsMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsModify;
        private System.Windows.Forms.ToolStripMenuItem tsDelete;
        private System.Windows.Forms.ToolStripMenuItem tsExportToExcel;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCardTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colDebtLimit;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyName;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone3;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colTown;
        private DevExpress.XtraGrid.Columns.GridColumn colDistrict;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
    }
}