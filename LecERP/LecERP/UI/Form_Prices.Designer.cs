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
            this.gvByItems.GridControl = this.gcByItems;
            this.gvByItems.Name = "gvByItems";
            this.gvByItems.OptionsView.ColumnAutoWidth = false;
            this.gvByItems.OptionsView.ShowFooter = true;
            this.gvByItems.OptionsView.ShowGroupPanel = false;
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
    }
}