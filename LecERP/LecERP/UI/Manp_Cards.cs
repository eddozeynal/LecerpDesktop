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

namespace LecERP
{
    public partial class Manp_Cards : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        CardMaster cardMaster = null;

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
            Operation<List<EnumMaster>> op_CardTypes = OperationHandler.GetEnums(1);
            if (!op_CardTypes.Successful)
            {
                OnLoadError(op_CardTypes.Fail);
                return;
            }
            lookUpCardType.Properties.DataSource = op_CardTypes.Value;

            Operation<List<ExchangeMaster>> op_Exchnages = OperationHandler.GetAllExchanges();
            if (!op_Exchnages.Successful)
            {
                OnLoadError(op_Exchnages.Fail);
                return;
            }
            lookUpExchange.Properties.DataSource = op_Exchnages.Value;

            if (Id == 0)
            {
                cardMaster = new CardMaster();
                chkActive.Checked = true;
            }
            else
            {
                // GET DATA
                Operation<CardMaster> op_cardMaster = OperationHandler.GetCardMaster(Id);
                if (!op_cardMaster.Successful)
                {
                    OnLoadError(op_cardMaster.Fail);
                    return;
                }
                cardMaster = op_cardMaster.Value;
                lookUpCardType.EditValue = cardMaster.CardType;

                txtCardCode.Text = cardMaster.CardNumber;
                txtCardName.Text = cardMaster.CardName;
                lookUpExchange.EditValue = cardMaster.ExchangeId;
                txtTel1.Text = cardMaster.Phone1;
                txtTel2.Text = cardMaster.Phone2;
                txtTel3.Text = cardMaster.Phone3;
                txtTaxCode.Text = cardMaster.TaxCode;
                txtCountry.Text = cardMaster.Country;
                txtCity.Text = cardMaster.City;
                txtTown.Text = cardMaster.Town;
                txtDistrict.Text = cardMaster.District;
                txtLocationAddress.Text = cardMaster.LocationAddress;
                spDebtLimit.Value = cardMaster.DebtLimit;
                lookUpCardType.Enabled = false;
                lookUpExchange.Enabled = false;
                chkActive.Checked = cardMaster.IsActive;
            }

           

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
                cardMaster.CreatedDate = DateTime.Now;
                cardMaster.CreatedBy = StaticData.CurrentUserId;
            }
            cardMaster.CardType = Convert.ToByte(lookUpCardType.EditValue);
            cardMaster.CardNumber = txtCardCode.Text;
            cardMaster.CardName = txtCardName.Text;
            cardMaster.ExchangeId = Convert.ToByte(lookUpExchange.EditValue);
            cardMaster.Phone1 = txtTel1.Text;
            cardMaster.Phone2 = txtTel2.Text;
            cardMaster.Phone3 = txtTel3.Text;
            cardMaster.TaxCode = txtTaxCode.Text;
            cardMaster.Country = txtCountry.Text;
            cardMaster.City = txtCity.Text;
            cardMaster.Town = txtTown.Text;
            cardMaster.District = txtDistrict.Text;
            cardMaster.LocationAddress = txtLocationAddress.Text;
            cardMaster.DebtLimit = spDebtLimit.Value;
            cardMaster.IsActive = chkActive.Checked;
            Operation<CardMaster> operation = OperationHandler.PostCardMaster(cardMaster);
            if (operation.Successful) this.Close();
            lblError.Text = operation.Fail;
        }

        private void lblError_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(this.Handle);
        }
    }
}