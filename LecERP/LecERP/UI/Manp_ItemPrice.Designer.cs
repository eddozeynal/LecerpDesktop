namespace LecERP
{
    partial class Manp_ItemPrice
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
            this.grpCards = new DevExpress.XtraEditors.GroupControl();
            this.gcCards = new DevExpress.XtraGrid.GridControl();
            this.gvCards = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.spSalePrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtItemType = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.spPurchasePrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtItemCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtItemName = new DevExpress.XtraEditors.TextEdit();
            this.pnlExecution = new DevExpress.XtraEditors.PanelControl();
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.colCardId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSpecial = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpCenter)).BeginInit();
            this.grpCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpCards)).BeginInit();
            this.grpCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
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
            this.grpCenter.Controls.Add(this.grpCards);
            this.grpCenter.Controls.Add(this.groupControl1);
            this.grpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCenter.Location = new System.Drawing.Point(0, 0);
            this.grpCenter.Name = "grpCenter";
            this.grpCenter.Size = new System.Drawing.Size(780, 505);
            this.grpCenter.TabIndex = 2;
            this.grpCenter.Text = "Qiymətlər";
            // 
            // grpCards
            // 
            this.grpCards.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpCards.AppearanceCaption.Options.UseFont = true;
            this.grpCards.Controls.Add(this.gcCards);
            this.grpCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCards.Location = new System.Drawing.Point(2, 110);
            this.grpCards.Name = "grpCards";
            this.grpCards.Size = new System.Drawing.Size(776, 393);
            this.grpCards.TabIndex = 17;
            this.grpCards.Text = "Hesablar";
            // 
            // gcCards
            // 
            this.gcCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCards.Location = new System.Drawing.Point(2, 23);
            this.gcCards.MainView = this.gvCards;
            this.gcCards.Name = "gcCards";
            this.gcCards.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3,
            this.repositoryItemSpinEdit4,
            this.repositoryItemSpinEdit5});
            this.gcCards.Size = new System.Drawing.Size(772, 368);
            this.gcCards.TabIndex = 16;
            this.gcCards.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCards});
            // 
            // gvCards
            // 
            this.gvCards.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCardId,
            this.colCardNumber,
            this.colCardName,
            this.colPrice,
            this.colIsSpecial});
            this.gvCards.GridControl = this.gcCards;
            this.gvCards.Name = "gvCards";
            this.gvCards.OptionsView.ColumnAutoWidth = false;
            this.gvCards.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // repositoryItemSpinEdit4
            // 
            this.repositoryItemSpinEdit4.AutoHeight = false;
            this.repositoryItemSpinEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit4.Name = "repositoryItemSpinEdit4";
            // 
            // repositoryItemSpinEdit5
            // 
            this.repositoryItemSpinEdit5.AutoHeight = false;
            this.repositoryItemSpinEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit5.Name = "repositoryItemSpinEdit5";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.spSalePrice);
            this.groupControl1.Controls.Add(this.txtItemType);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.spPurchasePrice);
            this.groupControl1.Controls.Add(this.txtItemCode);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtItemName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 23);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(776, 87);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Məhsul";
            // 
            // spSalePrice
            // 
            this.spSalePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spSalePrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSalePrice.Location = new System.Drawing.Point(666, 57);
            this.spSalePrice.Name = "spSalePrice";
            this.spSalePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spSalePrice.Properties.Appearance.Options.UseFont = true;
            this.spSalePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spSalePrice.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spSalePrice.Size = new System.Drawing.Size(100, 22);
            this.spSalePrice.TabIndex = 20;
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(416, 27);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtItemType.Properties.Appearance.Options.UseFont = true;
            this.txtItemType.Properties.ReadOnly = true;
            this.txtItemType.Size = new System.Drawing.Size(141, 22);
            this.txtItemType.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(578, 60);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 16);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Satış Qiyməti";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(298, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Məhsulun Növü";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Məhsulun Kodu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Məhsulun Adı";
            // 
            // spPurchasePrice
            // 
            this.spPurchasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spPurchasePrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPurchasePrice.Location = new System.Drawing.Point(666, 26);
            this.spPurchasePrice.Name = "spPurchasePrice";
            this.spPurchasePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spPurchasePrice.Properties.Appearance.Options.UseFont = true;
            this.spPurchasePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPurchasePrice.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spPurchasePrice.Size = new System.Drawing.Size(100, 22);
            this.spPurchasePrice.TabIndex = 11;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(127, 30);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtItemCode.Properties.Appearance.Options.UseFont = true;
            this.txtItemCode.Properties.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(141, 22);
            this.txtItemCode.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(578, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Alış Qiyməti";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(127, 58);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtItemName.Properties.Appearance.Options.UseFont = true;
            this.txtItemName.Properties.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(430, 22);
            this.txtItemName.TabIndex = 10;
            // 
            // pnlExecution
            // 
            this.pnlExecution.Controls.Add(this.lblError);
            this.pnlExecution.Controls.Add(this.btnCancel);
            this.pnlExecution.Controls.Add(this.btnOk);
            this.pnlExecution.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExecution.Location = new System.Drawing.Point(0, 505);
            this.pnlExecution.Name = "pnlExecution";
            this.pnlExecution.Size = new System.Drawing.Size(780, 43);
            this.pnlExecution.TabIndex = 3;
            this.pnlExecution.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlExecution_MouseDown);
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblError.Location = new System.Drawing.Point(12, 15);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(525, 16);
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
            this.btnCancel.Location = new System.Drawing.Point(662, 5);
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
            this.btnOk.Location = new System.Drawing.Point(543, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 32);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Yaddaşa Yaz";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // colCardId
            // 
            this.colCardId.Caption = "CardId";
            this.colCardId.FieldName = "CardId";
            this.colCardId.Name = "colCardId";
            this.colCardId.OptionsColumn.AllowEdit = false;
            this.colCardId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCardId.Width = 80;
            // 
            // colCardNumber
            // 
            this.colCardNumber.Caption = "Hesab Kodu";
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.OptionsColumn.AllowEdit = false;
            this.colCardNumber.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 0;
            this.colCardNumber.Width = 110;
            // 
            // colCardName
            // 
            this.colCardName.Caption = "Hesab Adı";
            this.colCardName.FieldName = "CardName";
            this.colCardName.Name = "colCardName";
            this.colCardName.OptionsColumn.AllowEdit = false;
            this.colCardName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colCardName.Visible = true;
            this.colCardName.VisibleIndex = 1;
            this.colCardName.Width = 300;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Qiymət";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 80;
            // 
            // colIsSpecial
            // 
            this.colIsSpecial.Caption = "Xüsusi";
            this.colIsSpecial.FieldName = "IsSpecial";
            this.colIsSpecial.Name = "colIsSpecial";
            this.colIsSpecial.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colIsSpecial.Visible = true;
            this.colIsSpecial.VisibleIndex = 3;
            this.colIsSpecial.Width = 80;
            // 
            // Manp_ItemPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 548);
            this.Controls.Add(this.grpCenter);
            this.Controls.Add(this.pnlExecution);
            this.Name = "Manp_ItemPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manp_ItemPriceByItem";
            this.Load += new System.EventHandler(this.Manp_ItemPriceByItem_Load);
            this.Shown += new System.EventHandler(this.Manp_ItemPriceByItem_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpCenter)).EndInit();
            this.grpCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpCards)).EndInit();
            this.grpCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlExecution)).EndInit();
            this.pnlExecution.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCenter;
        private DevExpress.XtraEditors.GroupControl grpCards;
        private DevExpress.XtraGrid.GridControl gcCards;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCards;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit4;
        private DevExpress.XtraEditors.SpinEdit spPurchasePrice;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.TextEdit txtItemCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pnlExecution;
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtItemType;
        private DevExpress.XtraEditors.SpinEdit spSalePrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn colCardId;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colCardName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSpecial;
    }
}