namespace LecERP
{
    partial class Manp_CurrencyByDate
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
            this.grpCurrencyInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.spRate = new DevExpress.XtraEditors.SpinEdit();
            this.lookUpCurrency = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pnlExecution = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.dateOfCurrency = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCurrencyInfo)).BeginInit();
            this.grpCurrencyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlExecution)).BeginInit();
            this.pnlExecution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfCurrency.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfCurrency.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCurrencyInfo
            // 
            this.grpCurrencyInfo.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.grpCurrencyInfo.AppearanceCaption.Options.UseFont = true;
            this.grpCurrencyInfo.Controls.Add(this.dateOfCurrency);
            this.grpCurrencyInfo.Controls.Add(this.lookUpCurrency);
            this.grpCurrencyInfo.Controls.Add(this.labelControl9);
            this.grpCurrencyInfo.Controls.Add(this.labelControl10);
            this.grpCurrencyInfo.Controls.Add(this.labelControl4);
            this.grpCurrencyInfo.Controls.Add(this.spRate);
            this.grpCurrencyInfo.Location = new System.Drawing.Point(6, 10);
            this.grpCurrencyInfo.Name = "grpCurrencyInfo";
            this.grpCurrencyInfo.Size = new System.Drawing.Size(389, 85);
            this.grpCurrencyInfo.TabIndex = 20;
            this.grpCurrencyInfo.Text = "Məlumatlar";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(23, 26);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(30, 16);
            this.labelControl10.TabIndex = 12;
            this.labelControl10.Text = "Tarix";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(291, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Nisbət";
            // 
            // spRate
            // 
            this.spRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spRate.Location = new System.Drawing.Point(291, 48);
            this.spRate.Name = "spRate";
            this.spRate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spRate.Properties.Appearance.Options.UseFont = true;
            this.spRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spRate.Size = new System.Drawing.Size(93, 22);
            this.spRate.TabIndex = 11;
            // 
            // lookUpCurrency
            // 
            this.lookUpCurrency.Location = new System.Drawing.Point(159, 48);
            this.lookUpCurrency.Name = "lookUpCurrency";
            this.lookUpCurrency.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lookUpCurrency.Properties.Appearance.Options.UseFont = true;
            this.lookUpCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCurrency.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CurrencyName", "Seçin")});
            this.lookUpCurrency.Properties.DisplayMember = "CurrencyName";
            this.lookUpCurrency.Properties.NullText = "Seçin";
            this.lookUpCurrency.Properties.ValueMember = "Id";
            this.lookUpCurrency.Size = new System.Drawing.Size(106, 22);
            this.lookUpCurrency.TabIndex = 19;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(159, 26);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(51, 16);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Məzənnə";
            // 
            // pnlExecution
            // 
            this.pnlExecution.Controls.Add(this.btnCancel);
            this.pnlExecution.Controls.Add(this.btnOk);
            this.pnlExecution.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExecution.Location = new System.Drawing.Point(0, 101);
            this.pnlExecution.Name = "pnlExecution";
            this.pnlExecution.Size = new System.Drawing.Size(400, 43);
            this.pnlExecution.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::LecERP.Properties.Resources.cancel_16x161;
            this.btnCancel.Location = new System.Drawing.Point(282, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "İmtina Et";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.ImageOptions.Image = global::LecERP.Properties.Resources.apply_16x161;
            this.btnOk.Location = new System.Drawing.Point(163, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 32);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Yaddaşa Yaz";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dateOfCurrency
            // 
            this.dateOfCurrency.EditValue = null;
            this.dateOfCurrency.Location = new System.Drawing.Point(23, 48);
            this.dateOfCurrency.Name = "dateOfCurrency";
            this.dateOfCurrency.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOfCurrency.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateOfCurrency.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dateOfCurrency.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateOfCurrency.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            this.dateOfCurrency.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateOfCurrency.Properties.Mask.EditMask = "dd.MM.yyyy";
            this.dateOfCurrency.Size = new System.Drawing.Size(112, 20);
            this.dateOfCurrency.TabIndex = 20;
            // 
            // Manp_CurrencyByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 144);
            this.Controls.Add(this.pnlExecution);
            this.Controls.Add(this.grpCurrencyInfo);
            this.Name = "Manp_CurrencyByDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manp_CurrencyByDate";
            this.Load += new System.EventHandler(this.Manp_CurrencyByDate_Load);
            this.Shown += new System.EventHandler(this.Manp_CurrencyByDate_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpCurrencyInfo)).EndInit();
            this.grpCurrencyInfo.ResumeLayout(false);
            this.grpCurrencyInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlExecution)).EndInit();
            this.pnlExecution.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateOfCurrency.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfCurrency.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCurrencyInfo;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spRate;
        private DevExpress.XtraEditors.LookUpEdit lookUpCurrency;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PanelControl pnlExecution;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.DateEdit dateOfCurrency;
    }
}