namespace LecERP
{
    partial class Dialog_DecimalInput
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
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.spnValue = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.grpMain.AppearanceCaption.Options.UseFont = true;
            this.grpMain.Controls.Add(this.spnValue);
            this.grpMain.Controls.Add(this.btnOK);
            this.grpMain.Controls.Add(this.btnCancel);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.Location = new System.Drawing.Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(196, 112);
            this.grpMain.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.Image = global::LecERP.Properties.Resources.apply_16x16;
            this.btnOK.Location = new System.Drawing.Point(12, 80);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 27);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Qəbul Et";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.ImageOptions.Image = global::LecERP.Properties.Resources.cancel_16x16;
            this.btnCancel.Location = new System.Drawing.Point(101, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "İmtina et";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // spnValue
            // 
            this.spnValue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnValue.Location = new System.Drawing.Point(63, 42);
            this.spnValue.Name = "spnValue";
            this.spnValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.spnValue.Properties.Appearance.Options.UseFont = true;
            this.spnValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnValue.Size = new System.Drawing.Size(121, 26);
            this.spnValue.TabIndex = 6;
            // 
            // Dialog_DecimalInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 112);
            this.Controls.Add(this.grpMain);
            this.Name = "Dialog_DecimalInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dialog_DecimalInput";
            this.Load += new System.EventHandler(this.Dialog_DecimalInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spnValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMain;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SpinEdit spnValue;
    }
}