namespace LecERP
{
    partial class Manp_CashTransaction
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpTransactionType = new DevExpress.XtraEditors.LookUpEdit();
            this.searchLookUpDestCard = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpExchange = new DevExpress.XtraEditors.LookUpEdit();
            this.searchLookUpSourceCard = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFicheno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spAmount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtNote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pnlExecution = new DevExpress.XtraEditors.PanelControl();
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpCenter)).BeginInit();
            this.grpCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTransactionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpDestCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpExchange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpSourceCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFicheno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
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
            this.grpCenter.Controls.Add(this.labelControl3);
            this.grpCenter.Controls.Add(this.lookUpTransactionType);
            this.grpCenter.Controls.Add(this.searchLookUpDestCard);
            this.grpCenter.Controls.Add(this.labelControl9);
            this.grpCenter.Controls.Add(this.txtDate);
            this.grpCenter.Controls.Add(this.labelControl10);
            this.grpCenter.Controls.Add(this.lookUpExchange);
            this.grpCenter.Controls.Add(this.searchLookUpSourceCard);
            this.grpCenter.Controls.Add(this.labelControl4);
            this.grpCenter.Controls.Add(this.labelControl2);
            this.grpCenter.Controls.Add(this.txtFicheno);
            this.grpCenter.Controls.Add(this.labelControl1);
            this.grpCenter.Controls.Add(this.spAmount);
            this.grpCenter.Controls.Add(this.labelControl13);
            this.grpCenter.Controls.Add(this.txtNote);
            this.grpCenter.Controls.Add(this.labelControl5);
            this.grpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCenter.Location = new System.Drawing.Point(0, 0);
            this.grpCenter.Name = "grpCenter";
            this.grpCenter.Size = new System.Drawing.Size(509, 235);
            this.grpCenter.TabIndex = 2;
            this.grpCenter.Text = "Tranzaksiya";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(21, 16);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Tipi";
            // 
            // lookUpTransactionType
            // 
            this.lookUpTransactionType.Location = new System.Drawing.Point(80, 38);
            this.lookUpTransactionType.Name = "lookUpTransactionType";
            this.lookUpTransactionType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lookUpTransactionType.Properties.Appearance.Options.UseFont = true;
            this.lookUpTransactionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpTransactionType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_", "Seçin")});
            this.lookUpTransactionType.Properties.DisplayMember = "Name_";
            this.lookUpTransactionType.Properties.NullText = "";
            this.lookUpTransactionType.Properties.ValueMember = "Key_";
            this.lookUpTransactionType.Size = new System.Drawing.Size(143, 22);
            this.lookUpTransactionType.TabIndex = 41;
            // 
            // searchLookUpDestCard
            // 
            this.searchLookUpDestCard.Location = new System.Drawing.Point(114, 199);
            this.searchLookUpDestCard.Name = "searchLookUpDestCard";
            this.searchLookUpDestCard.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchLookUpDestCard.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpDestCard.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpDestCard.Properties.DisplayMember = "CardName";
            this.searchLookUpDestCard.Properties.NullText = "Seçin";
            this.searchLookUpDestCard.Properties.ValueMember = "Id";
            this.searchLookUpDestCard.Properties.View = this.gridView1;
            this.searchLookUpDestCard.Size = new System.Drawing.Size(386, 22);
            this.searchLookUpDestCard.TabIndex = 39;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(17, 200);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 16);
            this.labelControl9.TabIndex = 38;
            this.labelControl9.Text = "Hesaba";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(80, 111);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDate.Properties.Appearance.Options.UseFont = true;
            this.txtDate.Properties.MaxLength = 15;
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(143, 22);
            this.txtDate.TabIndex = 31;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(261, 41);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(51, 16);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "Məzənnə";
            // 
            // lookUpExchange
            // 
            this.lookUpExchange.Location = new System.Drawing.Point(390, 38);
            this.lookUpExchange.Name = "lookUpExchange";
            this.lookUpExchange.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lookUpExchange.Properties.Appearance.Options.UseFont = true;
            this.lookUpExchange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpExchange.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_", "Seçin")});
            this.lookUpExchange.Properties.DisplayMember = "Name_";
            this.lookUpExchange.Properties.NullText = "";
            this.lookUpExchange.Properties.ValueMember = "Id";
            this.lookUpExchange.Size = new System.Drawing.Size(110, 22);
            this.lookUpExchange.TabIndex = 30;
            this.lookUpExchange.EditValueChanged += new System.EventHandler(this.lookUpExchange_EditValueChanged);
            // 
            // searchLookUpSourceCard
            // 
            this.searchLookUpSourceCard.Location = new System.Drawing.Point(114, 160);
            this.searchLookUpSourceCard.Name = "searchLookUpSourceCard";
            this.searchLookUpSourceCard.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchLookUpSourceCard.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpSourceCard.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpSourceCard.Properties.DisplayMember = "CardName";
            this.searchLookUpSourceCard.Properties.NullText = "Seçin";
            this.searchLookUpSourceCard.Properties.ValueMember = "Id";
            this.searchLookUpSourceCard.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpSourceCard.Size = new System.Drawing.Size(386, 22);
            this.searchLookUpSourceCard.TabIndex = 27;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 161);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 16);
            this.labelControl4.TabIndex = 25;
            this.labelControl4.Text = "Hesabdan";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 16);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Tarix";
            // 
            // txtFicheno
            // 
            this.txtFicheno.Location = new System.Drawing.Point(80, 79);
            this.txtFicheno.Name = "txtFicheno";
            this.txtFicheno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFicheno.Properties.Appearance.Options.UseFont = true;
            this.txtFicheno.Properties.MaxLength = 15;
            this.txtFicheno.Properties.ReadOnly = true;
            this.txtFicheno.Size = new System.Drawing.Size(143, 22);
            this.txtFicheno.TabIndex = 20;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 82);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 16);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Nömrə";
            // 
            // spAmount
            // 
            this.spAmount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spAmount.Location = new System.Drawing.Point(422, 117);
            this.spAmount.Name = "spAmount";
            this.spAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spAmount.Size = new System.Drawing.Size(78, 20);
            this.spAmount.TabIndex = 37;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(261, 120);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(34, 13);
            this.labelControl13.TabIndex = 36;
            this.labelControl13.Text = "Məbləğ";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(296, 79);
            this.txtNote.Name = "txtNote";
            this.txtNote.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNote.Properties.Appearance.Options.UseFont = true;
            this.txtNote.Properties.MaxLength = 30;
            this.txtNote.Size = new System.Drawing.Size(204, 22);
            this.txtNote.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(261, 82);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Qeyd";
            // 
            // pnlExecution
            // 
            this.pnlExecution.Controls.Add(this.lblError);
            this.pnlExecution.Controls.Add(this.btnCancel);
            this.pnlExecution.Controls.Add(this.btnOk);
            this.pnlExecution.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExecution.Location = new System.Drawing.Point(0, 235);
            this.pnlExecution.Name = "pnlExecution";
            this.pnlExecution.Size = new System.Drawing.Size(509, 43);
            this.pnlExecution.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblError.Location = new System.Drawing.Point(12, 15);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(254, 16);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "Error :";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::LecERP.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(391, 5);
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
            this.btnOk.Location = new System.Drawing.Point(272, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 32);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Yaddaşa Yaz";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Manp_CashTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 278);
            this.Controls.Add(this.grpCenter);
            this.Controls.Add(this.pnlExecution);
            this.Name = "Manp_CashTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Manp_CashTransaction_Load);
            this.Shown += new System.EventHandler(this.Manp_CashTransaction_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grpCenter)).EndInit();
            this.grpCenter.ResumeLayout(false);
            this.grpCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpTransactionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpDestCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpExchange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpSourceCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFicheno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlExecution)).EndInit();
            this.pnlExecution.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpCenter;
        private DevExpress.XtraEditors.TextEdit txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl pnlExecution;
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.TextEdit txtFicheno;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpSourceCard;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LookUpEdit lookUpExchange;
        private DevExpress.XtraEditors.SpinEdit spAmount;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpDestCard;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpTransactionType;
    }
}