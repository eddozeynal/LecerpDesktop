namespace LecERP
{
    partial class Form_Main
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
            this.xtraTDMain = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.navbarMain = new DevExpress.XtraNavBar.NavBarControl();
            this.nvAdministration = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvUsers = new DevExpress.XtraNavBar.NavBarItem();
            this.nvDeclarations = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvItems = new DevExpress.XtraNavBar.NavBarItem();
            this.nvCards = new DevExpress.XtraNavBar.NavBarItem();
            this.nvPrices = new DevExpress.XtraNavBar.NavBarItem();
            this.nvProcesses = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvFiches = new DevExpress.XtraNavBar.NavBarItem();
            this.nvCashTransaction = new DevExpress.XtraNavBar.NavBarItem();
            this.nvReports = new DevExpress.XtraNavBar.NavBarGroup();
            this.nv_CardDebtReport = new DevExpress.XtraNavBar.NavBarItem();
            this.nvCompanyParameters = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTDMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarMain)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTDMain
            // 
            this.xtraTDMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTDMain.MdiParent = this;
            // 
            // navbarMain
            // 
            this.navbarMain.ActiveGroup = this.nvReports;
            this.navbarMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.navbarMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvDeclarations,
            this.nvProcesses,
            this.nvReports,
            this.nvAdministration});
            this.navbarMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nvItems,
            this.nvCards,
            this.nvPrices,
            this.nvFiches,
            this.nvUsers,
            this.nvCashTransaction,
            this.nv_CardDebtReport,
            this.nvCompanyParameters});
            this.navbarMain.Location = new System.Drawing.Point(0, 0);
            this.navbarMain.Name = "navbarMain";
            this.navbarMain.OptionsNavPane.ExpandedWidth = 166;
            this.navbarMain.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navbarMain.Size = new System.Drawing.Size(166, 532);
            this.navbarMain.TabIndex = 1;
            this.navbarMain.Text = "navBarControl1";
            // 
            // nvAdministration
            // 
            this.nvAdministration.Caption = "Administrasiya";
            this.nvAdministration.Expanded = true;
            this.nvAdministration.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvUsers),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvCompanyParameters)});
            this.nvAdministration.Name = "nvAdministration";
            this.nvAdministration.SmallImage = global::LecERP.Properties.Resources.bouser_16x16;
            // 
            // nvUsers
            // 
            this.nvUsers.Caption = "İstifadəçilər";
            this.nvUsers.Name = "nvUsers";
            this.nvUsers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvUsers_LinkClicked);
            // 
            // nvDeclarations
            // 
            this.nvDeclarations.Caption = "Tanımlar";
            this.nvDeclarations.Expanded = true;
            this.nvDeclarations.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvItems),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvCards),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvPrices)});
            this.nvDeclarations.LargeImage = global::LecERP.Properties.Resources.withtextwrapping_topcenter_16x16;
            this.nvDeclarations.Name = "nvDeclarations";
            // 
            // nvItems
            // 
            this.nvItems.Caption = "Məhsullar";
            this.nvItems.Name = "nvItems";
            this.nvItems.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvItems_LinkClicked);
            // 
            // nvCards
            // 
            this.nvCards.Caption = "Hesablar";
            this.nvCards.Name = "nvCards";
            this.nvCards.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvCards_LinkClicked);
            // 
            // nvPrices
            // 
            this.nvPrices.Caption = "Qiymətlər";
            this.nvPrices.Name = "nvPrices";
            this.nvPrices.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvPrices_LinkClicked);
            // 
            // nvProcesses
            // 
            this.nvProcesses.Caption = "Proseslər";
            this.nvProcesses.Expanded = true;
            this.nvProcesses.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvFiches),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nvCashTransaction)});
            this.nvProcesses.Name = "nvProcesses";
            this.nvProcesses.SmallImage = global::LecERP.Properties.Resources.properties_16x16;
            // 
            // nvFiches
            // 
            this.nvFiches.Caption = "Qaimələr";
            this.nvFiches.Name = "nvFiches";
            this.nvFiches.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvFiches_LinkClicked);
            // 
            // nvCashTransaction
            // 
            this.nvCashTransaction.Caption = "Kassa Tranzaksiya";
            this.nvCashTransaction.Name = "nvCashTransaction";
            this.nvCashTransaction.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nvCashTransaction_LinkClicked);
            // 
            // nvReports
            // 
            this.nvReports.Caption = "Raportlar";
            this.nvReports.Expanded = true;
            this.nvReports.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nv_CardDebtReport)});
            this.nvReports.Name = "nvReports";
            this.nvReports.SmallImage = global::LecERP.Properties.Resources.boreport2_16x16;
            // 
            // nv_CardDebtReport
            // 
            this.nv_CardDebtReport.Caption = "Hesab Qalıqları";
            this.nv_CardDebtReport.Name = "nv_CardDebtReport";
            this.nv_CardDebtReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nv_CardDebtReport_LinkClicked);
            // 
            // nvCompanyParameters
            // 
            this.nvCompanyParameters.Caption = "Şirkət Parametrləri";
            this.nvCompanyParameters.Name = "nvCompanyParameters";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 532);
            this.Controls.Add(this.navbarMain);
            this.IsMdiContainer = true;
            this.Name = "Form_Main";
            this.Text = "LecERP";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Shown += new System.EventHandler(this.Form_Main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTDMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navbarMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTDMain;
        private DevExpress.XtraNavBar.NavBarControl navbarMain;
        private DevExpress.XtraNavBar.NavBarGroup nvDeclarations;
        private DevExpress.XtraNavBar.NavBarItem nvItems;
        private DevExpress.XtraNavBar.NavBarItem nvCards;
        private DevExpress.XtraNavBar.NavBarGroup nvProcesses;
        private DevExpress.XtraNavBar.NavBarItem nvPrices;
        private DevExpress.XtraNavBar.NavBarItem nvFiches;
        private DevExpress.XtraNavBar.NavBarGroup nvAdministration;
        private DevExpress.XtraNavBar.NavBarItem nvUsers;
        private DevExpress.XtraNavBar.NavBarItem nvCashTransaction;
        private DevExpress.XtraNavBar.NavBarGroup nvReports;
        private DevExpress.XtraNavBar.NavBarItem nv_CardDebtReport;
        private DevExpress.XtraNavBar.NavBarItem nvCompanyParameters;
    }
}

