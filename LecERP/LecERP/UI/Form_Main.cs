using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LecERP
{
    public partial class Form_Main : DevExpress.XtraEditors.XtraForm
    {
        public Form_Main()
        {
            InitializeComponent();
            FormHolder.MdiParent = this;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //FicheMasterView fm = new FicheMasterView();
            //fm.Id = 5;
            //fm.SourceDocument = "SOURCE DOC 2";
            //fm.ExchangeName = "NESNE";
            //fm.CreatedDate = DateTime.Now;
            //fm.Status_ = 4;
            //fm.CardId = 7;
            ////fm.CreatedDate = DateTime.Now;
            //var v2 = OperationHandler.PostFiche2(fm).Value;

        }

        private void nvItems_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormHolder.Populate(typeof(Form_Items), e.Link.Caption);
        }

        private void nvTest_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //FormHolder.Populate(typeof(Form_Test), e.Link.Caption);
        }

        private void nvCards_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormHolder.Populate(typeof(Form_Cards), e.Link.Caption);
        }

        private void Form_Main_Shown(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.ShowDialog();
            StaticData.RetrieveAppSettings();
            nvItems.Enabled = StaticData.IsPermitted(2);
            nvCards.Enabled = StaticData.IsPermitted(6);
            nvPrices.Enabled = StaticData.IsPermitted(10);
            nvFiches.Enabled = StaticData.IsPermitted(12);
            nvCashTransaction.Enabled = StaticData.IsPermitted(13);
            nv_CardDebtReport.Enabled = StaticData.IsPermitted(15);
            nvUsers.Enabled = StaticData.CurrentUser.IsAdmin;
            nvUsers.Enabled = StaticData.CurrentUser.IsAdmin; 
        }

        private void nvPrices_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormHolder.Populate(typeof(Form_Prices), e.Link.Caption);
        }

        private void nvFiches_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormHolder.Populate(typeof(Form_Fiches), e.Link.Caption);
        }

        private void nvUsers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormHolder.Populate(typeof(Form_Users), e.Link.Caption);
        }

        private void nvCashTransaction_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormHolder.Populate(typeof(Form_CashTransaction), e.Link.Caption);
        }

        private void nv_CardDebtReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //FormHolder.Populate(typeof(Form_CardDebtReport), e.Link.Caption);
        }

        private void nv_ItemReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           // FormHolder.Populate(typeof(Form_ItemReport), e.Link.Caption);
        }

        private void nvCurrencyExchanges_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormHolder.Populate(typeof(Form_CurrencyExchange), e.Link.Caption);
        }

        private void nvSettings_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FormHolder.Populate(typeof(Form_Settings), e.Link.Caption);
        }
    }
}
