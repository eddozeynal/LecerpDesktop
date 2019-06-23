namespace LecERP
{
    partial class Form_WorkStateView
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
            this.treeListWorkStateView = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeListWorkStateView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListWorkStateView
            // 
            this.treeListWorkStateView.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeListWorkStateView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListWorkStateView.Location = new System.Drawing.Point(0, 0);
            this.treeListWorkStateView.Name = "treeListWorkStateView";
            this.treeListWorkStateView.Size = new System.Drawing.Size(887, 525);
            this.treeListWorkStateView.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Vəzifə";
            this.treeListColumn1.FieldName = "JobName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "İşçi";
            this.treeListColumn2.FieldName = "PersonnelName";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // Form_WorkStateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 525);
            this.Controls.Add(this.treeListWorkStateView);
            this.Name = "Form_WorkStateView";
            this.Text = "Form_WorkStateView";
            this.Load += new System.EventHandler(this.Form_WorkStateView_Load);
            this.Shown += new System.EventHandler(this.Form_WorkStateView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.treeListWorkStateView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListWorkStateView;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
    }
}