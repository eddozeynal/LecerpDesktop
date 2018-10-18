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
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTop)).BeginInit();
            this.grpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
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
            // 
            // gvData
            // 
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
            this.grpTop.Controls.Add(this.btnRefresh);
            this.grpTop.Controls.Add(this.panelControl2);
            this.grpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTop.Location = new System.Drawing.Point(0, 0);
            this.grpTop.Name = "grpTop";
            this.grpTop.Size = new System.Drawing.Size(1151, 58);
            this.grpTop.TabIndex = 3;
            this.grpTop.Text = "Seçimlər";
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
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.dateEnd);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 23);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(198, 33);
            this.panelControl2.TabIndex = 6;
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
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(41, 8);
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
        private DevExpress.XtraEditors.DateEdit dateEnd;
    }
}