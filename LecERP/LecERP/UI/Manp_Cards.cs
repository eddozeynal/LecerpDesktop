using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LecERP.Models;

namespace LecERP
{
    public partial class Manp_Cards : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        Card card = null;
        DataHolder dataHolder = new DataHolder();
        DataObjectBindTool<Card> bindTool = new DataObjectBindTool<Card>();
        public Manp_Cards()
        {
            InitializeComponent();
        }

        private void Manp_Cards_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            lblError.Text = "";
        }

        void OnLoadError(string Message)
        {
            grpCenter.Enabled = false;
            btnOk.Enabled = false;
            if (Message == null) Message = "Unknown Error";
            lblError.Text = "Error : " + Message;
            lblError.BackColor = Color.Red;
        }

        private void Manp_Cards_Shown(object sender, EventArgs e)
        {
            dataHolder.LoadEnumData();
            lookUpCardType.Properties.DataSource = dataHolder.CardTypes;

            
            lookUpCurrency.Properties.DataSource = dataHolder.Currencies;

            if (Id == 0)
            {
                card = new Card();
                chkActive.Checked = true;
            }
            else
            {
                // GET DATA
                Operation<Card> op_card = OperationHandler.GetCardById(Id);
                if (!op_card.Successful)
                {
                    OnLoadError(op_card.Fail);
                    return;
                }
                card = op_card.Value;
                lookUpCardType.Enabled = false;
                lookUpCurrency.Enabled = false;
            }

            bindTool.BindControl(lookUpCardType,nameof(card.CardTypeId));
            bindTool.BindControl(txtCardCode, nameof(card.CardNumber));
            bindTool.BindControl(txtCardName, nameof(card.CardName));
            bindTool.BindControl(lookUpCurrency, nameof(card.CurrencyId));
            bindTool.BindControl(txtTel1, nameof(card.Phone1));
            bindTool.BindControl(txtTel2, nameof(card.Phone2));
            bindTool.BindControl(txtTel3, nameof(card.Phone3));
            bindTool.BindControl(txtTaxCode, nameof(card.TaxCode));
            bindTool.BindControl(txtCountry, nameof(card.Country));
            bindTool.BindControl(txtCity, nameof(card.City));
            bindTool.BindControl(txtTown, nameof(card.Town));
            bindTool.BindControl(txtDistrict, nameof(card.District));
            bindTool.BindControl(txtLocationAddress, nameof(card.LocationAddress));
            bindTool.BindControl(spDebtLimit, nameof(card.DebtLimit));
            bindTool.BindControl(chkActive, nameof(card.IsActive));

            bindTool.DataObject = card;
        }

        private void pnlExecution_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(Handle);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (UIFunctions.CheckCancellation()) Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                card.CreatedDate = DateTime.Now;
                card.CreatedBy = StaticData.CurrentUserId;
            }
            card = bindTool.DataObject;
            //card.CardTypeId = Convert.ToByte(lookUpCardType.EditValue);
            //card.CardNumber = txtCardCode.Text;
            //card.CardName = txtCardName.Text;
            //card.CurrencyId = Convert.ToByte(lookUpCurrency.EditValue);
            //card.Phone1 = txtTel1.Text;
            //card.Phone2 = txtTel2.Text;
            //card.Phone3 = txtTel3.Text;
            //card.TaxCode = txtTaxCode.Text;
            //card.Country = txtCountry.Text;
            //card.City = txtCity.Text;
            //card.Town = txtTown.Text;
            //card.District = txtDistrict.Text;
            //card.LocationAddress = txtLocationAddress.Text;
            //card.DebtLimit = spDebtLimit.Value;
            //card.IsActive = chkActive.Checked;
            Operation<Card> operation = OperationHandler.PostCard(card);
            if (operation.Successful) this.Close();
            lblError.Text = operation.Fail;
        }

        private void lblError_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(this.Handle);
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {

        }
    }
}