namespace LecERP
{
    partial class Form_Fiches
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpFicheType = new DevExpress.XtraEditors.LookUpEdit();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExecutePayment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrintDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.tsProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBeginProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCompleteProcess = new System.Windows.Forms.ToolStripMenuItem();
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
            this.colFicheno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSourceDocument = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExchangeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWeightTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSourceWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorksCompleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpTop)).BeginInit();
            this.grpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFicheType.Properties)).BeginInit();
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
            this.grpTop.Controls.Add(this.panelControl1);
            this.grpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTop.Location = new System.Drawing.Point(0, 0);
            this.grpTop.Name = "grpTop";
            this.grpTop.Size = new System.Drawing.Size(1198, 58);
            this.grpTop.TabIndex = 0;
            this.grpTop.Text = "Seçimlər";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.ImageOptions.Image = global::LecERP.Properties.Resources.refreshallpivottable_16x16;
            this.btnRefresh.Location = new System.Drawing.Point(1124, 23);
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
            this.panelControl2.Location = new System.Drawing.Point(226, 23);
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
            this.labelControl2.Size = new System.Drawing.Size(73, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Qaimə Tarixi";
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lookUpFicheType);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(224, 33);
            this.panelControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Qaimə Növü";
            // 
            // lookUpFicheType
            // 
            this.lookUpFicheType.Location = new System.Drawing.Point(83, 6);
            this.lookUpFicheType.Name = "lookUpFicheType";
            this.lookUpFicheType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lookUpFicheType.Properties.Appearance.Options.UseFont = true;
            this.lookUpFicheType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpFicheType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Seçin")});
            this.lookUpFicheType.Properties.DisplayMember = "Name";
            this.lookUpFicheType.Properties.NullText = "";
            this.lookUpFicheType.Properties.ValueMember = "Id";
            this.lookUpFicheType.Size = new System.Drawing.Size(134, 22);
            this.lookUpFicheType.TabIndex = 4;
            this.lookUpFicheType.EditValueChanged += new System.EventHandler(this.lookUpFicheType_EditValueChanged);
            // 
            // gcData
            // 
            this.gcData.ContextMenuStrip = this.cmsMain;
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(0, 58);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(1198, 478);
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
            this.btnCreateInvoice,
            this.tsExecutePayment,
            this.tsPrintDocument,
            this.tsProcess});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(140, 202);
            // 
            // tsAddNew
            // 
            this.tsAddNew.Image = global::LecERP.Properties.Resources.newtask_16x16;
            this.tsAddNew.Name = "tsAddNew";
            this.tsAddNew.Size = new System.Drawing.Size(139, 22);
            this.tsAddNew.Text = "Yeni...";
            this.tsAddNew.Click += new System.EventHandler(this.tsAddNew_Click);
            // 
            // tsView
            // 
            this.tsView.Image = global::LecERP.Properties.Resources.show_32x32;
            this.tsView.Name = "tsView";
            this.tsView.Size = new System.Drawing.Size(139, 22);
            this.tsView.Text = "Baxış";
            this.tsView.Click += new System.EventHandler(this.tsView_Click);
            // 
            // tsModify
            // 
            this.tsModify.Image = global::LecERP.Properties.Resources.pagesetup_16x16;
            this.tsModify.Name = "tsModify";
            this.tsModify.Size = new System.Drawing.Size(139, 22);
            this.tsModify.Text = "Düzəliş Et";
            this.tsModify.Click += new System.EventHandler(this.tsModify_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Image = global::LecERP.Properties.Resources.deletetable_16x16;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(139, 22);
            this.tsDelete.Text = "Sil";
            // 
            // tsExportToExcel
            // 
            this.tsExportToExcel.Image = global::LecERP.Properties.Resources.excel_16x16;
            this.tsExportToExcel.Name = "tsExportToExcel";
            this.tsExportToExcel.Size = new System.Drawing.Size(139, 22);
            this.tsExportToExcel.Text = "Excel-ə çıxar";
            this.tsExportToExcel.Click += new System.EventHandler(this.tsExportToExcel_Click);
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.Image = global::LecERP.Properties.Resources.newtablestyle_32x32;
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(139, 22);
            this.btnCreateInvoice.Text = "Fakturalama";
            this.btnCreateInvoice.Click += new System.EventHandler(this.btnCreateInvoice_Click);
            // 
            // tsExecutePayment
            // 
            this.tsExecutePayment.Image = global::LecERP.Properties.Resources.bosale_32x32;
            this.tsExecutePayment.Name = "tsExecutePayment";
            this.tsExecutePayment.Size = new System.Drawing.Size(139, 22);
            this.tsExecutePayment.Text = "Ödəmə Et...";
            this.tsExecutePayment.Click += new System.EventHandler(this.tsExecutePayment_Click);
            // 
            // tsPrintDocument
            // 
            this.tsPrintDocument.Image = global::LecERP.Properties.Resources.printer_16x16;
            this.tsPrintDocument.Name = "tsPrintDocument";
            this.tsPrintDocument.Size = new System.Drawing.Size(139, 22);
            this.tsPrintDocument.Text = "Çap Et";
            this.tsPrintDocument.Click += new System.EventHandler(this.tsPrintDocument_Click);
            // 
            // tsProcess
            // 
            this.tsProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBeginProcess,
            this.tsCompleteProcess});
            this.tsProcess.Image = global::LecERP.Properties.Resources.project_32x32;
            this.tsProcess.Name = "tsProcess";
            this.tsProcess.Size = new System.Drawing.Size(139, 22);
            this.tsProcess.Text = "Proses";
            // 
            // tsBeginProcess
            // 
            this.tsBeginProcess.Name = "tsBeginProcess";
            this.tsBeginProcess.Size = new System.Drawing.Size(123, 22);
            this.tsBeginProcess.Text = "Başlat";
            this.tsBeginProcess.Click += new System.EventHandler(this.tsBeginProcess_Click);
            // 
            // tsCompleteProcess
            // 
            this.tsCompleteProcess.Name = "tsCompleteProcess";
            this.tsCompleteProcess.Size = new System.Drawing.Size(123, 22);
            this.tsCompleteProcess.Text = "Tamamla";
            this.tsCompleteProcess.Click += new System.EventHandler(this.tsCompleteProcess_Click);
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
            this.colFicheno,
            this.colSourceDocument,
            this.colCardNumber,
            this.colCardName,
            this.colTotal,
            this.colExchangeName,
            this.colWeightTotal,
            this.colNote1,
            this.colNote2,
            this.colNote3,
            this.colNote4,
            this.colSourceWarehouse,
            this.colLineCount,
            this.colWorksCompleted,
            this.colStatusName});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            this.gvData.DoubleClick += new System.EventHandler(this.gvData_DoubleClick);
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
            this.colCreatedDate.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm:ss";
            this.colCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.OptionsColumn.AllowEdit = false;
            this.colCreatedDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 0;
            this.colCreatedDate.Width = 120;
            // 
            // colFicheno
            // 
            this.colFicheno.Caption = "Sənəd No";
            this.colFicheno.FieldName = "Ficheno";
            this.colFicheno.Name = "colFicheno";
            this.colFicheno.OptionsColumn.AllowEdit = false;
            this.colFicheno.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colFicheno.Visible = true;
            this.colFicheno.VisibleIndex = 1;
            this.colFicheno.Width = 80;
            // 
            // colSourceDocument
            // 
            this.colSourceDocument.Caption = "Kök Sənəd";
            this.colSourceDocument.FieldName = "SourceDocument";
            this.colSourceDocument.Name = "colSourceDocument";
            this.colSourceDocument.OptionsColumn.AllowEdit = false;
            this.colSourceDocument.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSourceDocument.Visible = true;
            this.colSourceDocument.VisibleIndex = 2;
            this.colSourceDocument.Width = 80;
            // 
            // colCardNumber
            // 
            this.colCardNumber.Caption = "Hesab Kodu";
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.OptionsColumn.AllowEdit = false;
            this.colCardNumber.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 3;
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
            this.colCardName.VisibleIndex = 4;
            this.colCardName.Width = 150;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Məbləğ";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 80;
            // 
            // colExchangeName
            // 
            this.colExchangeName.Caption = "Məzənnə";
            this.colExchangeName.FieldName = "ExchangeName";
            this.colExchangeName.Name = "colExchangeName";
            this.colExchangeName.OptionsColumn.AllowEdit = false;
            this.colExchangeName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colExchangeName.Visible = true;
            this.colExchangeName.VisibleIndex = 6;
            this.colExchangeName.Width = 50;
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
            // colNote1
            // 
            this.colNote1.Caption = "Qeyd 1";
            this.colNote1.FieldName = "Note1";
            this.colNote1.Name = "colNote1";
            this.colNote1.OptionsColumn.AllowEdit = false;
            this.colNote1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colNote1.Visible = true;
            this.colNote1.VisibleIndex = 7;
            this.colNote1.Width = 80;
            // 
            // colNote2
            // 
            this.colNote2.Caption = "Qeyd 2";
            this.colNote2.FieldName = "Note2";
            this.colNote2.Name = "colNote2";
            this.colNote2.OptionsColumn.AllowEdit = false;
            this.colNote2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colNote2.Visible = true;
            this.colNote2.VisibleIndex = 8;
            this.colNote2.Width = 80;
            // 
            // colNote3
            // 
            this.colNote3.Caption = "Qeyd 3";
            this.colNote3.FieldName = "Note3";
            this.colNote3.Name = "colNote3";
            this.colNote3.OptionsColumn.AllowEdit = false;
            this.colNote3.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colNote3.Visible = true;
            this.colNote3.VisibleIndex = 9;
            this.colNote3.Width = 80;
            // 
            // colNote4
            // 
            this.colNote4.Caption = "Qeyd 4";
            this.colNote4.FieldName = "Note4";
            this.colNote4.Name = "colNote4";
            this.colNote4.OptionsColumn.AllowEdit = false;
            this.colNote4.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colNote4.Visible = true;
            this.colNote4.VisibleIndex = 10;
            this.colNote4.Width = 80;
            // 
            // colSourceWarehouse
            // 
            this.colSourceWarehouse.Caption = "Anbar";
            this.colSourceWarehouse.FieldName = "SourceWarehouse";
            this.colSourceWarehouse.Name = "colSourceWarehouse";
            this.colSourceWarehouse.OptionsColumn.AllowEdit = false;
            this.colSourceWarehouse.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colSourceWarehouse.Visible = true;
            this.colSourceWarehouse.VisibleIndex = 11;
            this.colSourceWarehouse.Width = 80;
            // 
            // colLineCount
            // 
            this.colLineCount.Caption = "Sətir Sayı";
            this.colLineCount.FieldName = "LineCount";
            this.colLineCount.Name = "colLineCount";
            this.colLineCount.OptionsColumn.AllowEdit = false;
            this.colLineCount.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colLineCount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colLineCount.Visible = true;
            this.colLineCount.VisibleIndex = 12;
            this.colLineCount.Width = 50;
            // 
            // colWorksCompleted
            // 
            this.colWorksCompleted.Caption = "İşlər bitib";
            this.colWorksCompleted.FieldName = "WorksCompleted";
            this.colWorksCompleted.Name = "colWorksCompleted";
            this.colWorksCompleted.OptionsColumn.AllowEdit = false;
            this.colWorksCompleted.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colWorksCompleted.Visible = true;
            this.colWorksCompleted.VisibleIndex = 13;
            this.colWorksCompleted.Width = 30;
            // 
            // colStatusName
            // 
            this.colStatusName.Caption = "Status";
            this.colStatusName.FieldName = "StatusName";
            this.colStatusName.Name = "colStatusName";
            this.colStatusName.OptionsColumn.AllowEdit = false;
            this.colStatusName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colStatusName.Visible = true;
            this.colStatusName.VisibleIndex = 14;
            this.colStatusName.Width = 50;
            // 
            // Form_Fiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 536);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.grpTop);
            this.Name = "Form_Fiches";
            this.Text = "Form_Fiches";
            this.Load += new System.EventHandler(this.Form_Fiches_Load);
            this.Shown += new System.EventHandler(this.Form_Fiches_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpTop)).EndInit();
            this.grpTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpFicheType.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.DateEdit dateBegin;
        private DevExpress.XtraEditors.LookUpEdit lookUpFicheType;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsAddNew;
        private System.Windows.Forms.ToolStripMenuItem tsModify;
        private System.Windows.Forms.ToolStripMenuItem tsDelete;
        private System.Windows.Forms.ToolStripMenuItem tsExportToExcel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsView;
        private System.Windows.Forms.ToolStripMenuItem btnCreateInvoice;
        private System.Windows.Forms.ToolStripMenuItem tsPrintDocument;
        private System.Windows.Forms.ToolStripMenuItem tsExecutePayment;
        private System.Windows.Forms.ToolStripMenuItem tsProcess;
        private System.Windows.Forms.ToolStripMenuItem tsBeginProcess;
        private System.Windows.Forms.ToolStripMenuItem tsCompleteProcess;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDocTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colCardId;
        private DevExpress.XtraGrid.Columns.GridColumn colDestinationWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus_;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceFicheId;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFicheno;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceDocument;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeName;
        private DevExpress.XtraGrid.Columns.GridColumn colWeightTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private DevExpress.XtraGrid.Columns.GridColumn colNote2;
        private DevExpress.XtraGrid.Columns.GridColumn colNote3;
        private DevExpress.XtraGrid.Columns.GridColumn colNote4;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colLineCount;
        private DevExpress.XtraGrid.Columns.GridColumn colWorksCompleted;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusName;
    }
}