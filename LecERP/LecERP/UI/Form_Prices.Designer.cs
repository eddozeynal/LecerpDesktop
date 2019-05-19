namespace LecERP
{
    partial class Form_Prices
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
            this.gcByItems = new DevExpress.XtraGrid.GridControl();
            this.gvByItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefaultPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefaultSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcByItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvByItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gcByItems
            // 
            this.gcByItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcByItems.Location = new System.Drawing.Point(0, 0);
            this.gcByItems.MainView = this.gvByItems;
            this.gcByItems.Name = "gcByItems";
            this.gcByItems.Size = new System.Drawing.Size(1013, 589);
            this.gcByItems.TabIndex = 2;
            this.gcByItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvByItems});
            this.gcByItems.DoubleClick += new System.EventHandler(this.gcByItems_DoubleClick);
            // 
            // gvByItems
            // 
            this.gvByItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemId,
            this.colItemTypeName,
            this.colItemCode,
            this.colItemName,
            this.colDefaultPurchasePrice,
            this.colDefaultSalePrice});
            this.gvByItems.GridControl = this.gcByItems;
            this.gvByItems.Name = "gvByItems";
            this.gvByItems.OptionsView.ColumnAutoWidth = false;
            this.gvByItems.OptionsView.ShowFooter = true;
            this.gvByItems.OptionsView.ShowGroupPanel = false;
            // 
            // colItemId
            // 
            this.colItemId.Caption = "ItemId";
            this.colItemId.FieldName = "ItemId";
            this.colItemId.Name = "colItemId";
            this.colItemId.OptionsColumn.AllowEdit = false;
            this.colItemId.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colItemId.Width = 80;
            // 
            // colItemTypeName
            // 
            this.colItemTypeName.Caption = "Növü";
            this.colItemTypeName.FieldName = "ItemTypeName";
            this.colItemTypeName.Name = "colItemTypeName";
            this.colItemTypeName.OptionsColumn.AllowEdit = false;
            this.colItemTypeName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colItemTypeName.Visible = true;
            this.colItemTypeName.VisibleIndex = 0;
            this.colItemTypeName.Width = 80;
            // 
            // colItemCode
            // 
            this.colItemCode.Caption = "Kodu";
            this.colItemCode.FieldName = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.OptionsColumn.AllowEdit = false;
            this.colItemCode.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colItemCode.Visible = true;
            this.colItemCode.VisibleIndex = 1;
            this.colItemCode.Width = 80;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Adı";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.OptionsColumn.AllowEdit = false;
            this.colItemName.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 2;
            this.colItemName.Width = 300;
            // 
            // colDefaultPurchasePrice
            // 
            this.colDefaultPurchasePrice.Caption = "Alış Qiyməti";
            this.colDefaultPurchasePrice.FieldName = "DefaultPurchasePrice";
            this.colDefaultPurchasePrice.Name = "colDefaultPurchasePrice";
            this.colDefaultPurchasePrice.OptionsColumn.AllowEdit = false;
            this.colDefaultPurchasePrice.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDefaultPurchasePrice.Visible = true;
            this.colDefaultPurchasePrice.VisibleIndex = 3;
            this.colDefaultPurchasePrice.Width = 80;
            // 
            // colDefaultSalePrice
            // 
            this.colDefaultSalePrice.Caption = "Satış Qiyməti";
            this.colDefaultSalePrice.FieldName = "DefaultSalePrice";
            this.colDefaultSalePrice.Name = "colDefaultSalePrice";
            this.colDefaultSalePrice.OptionsColumn.AllowEdit = false;
            this.colDefaultSalePrice.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colDefaultSalePrice.Visible = true;
            this.colDefaultSalePrice.VisibleIndex = 4;
            this.colDefaultSalePrice.Width = 80;
            // 
            // Form_Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 589);
            this.Controls.Add(this.gcByItems);
            this.Name = "Form_Prices";
            this.Text = "Form_Prices";
            this.Load += new System.EventHandler(this.Form_Prices_Load);
            this.Shown += new System.EventHandler(this.Form_Prices_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gcByItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvByItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gcByItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvByItems;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colItemTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colDefaultPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDefaultSalePrice;
    }
}