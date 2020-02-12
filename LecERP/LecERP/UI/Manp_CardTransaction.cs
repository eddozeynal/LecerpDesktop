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
using System.Collections.ObjectModel;
using DevExpress.XtraGrid.Views.Base;
using LecERP.Models;

namespace LecERP
{
    public partial class Manp_CardTransaction : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        public bool IsEditMode { get; set; }

        CardFiche cardFiche = null;
        CardFicheLine creditLine = null;
        CardFicheLine debitLine = null;
        List<CardView> Cards = null;
        List<CashType> CashTypes = null;
        public byte DocTypeId { get; set; }
        DataHolder dataHolder = new DataHolder();
        DataObjectBindTool<CardFiche> ficheBindTool = new DataObjectBindTool<CardFiche>();
        DataObjectBindTool<CardFicheLine> creditLineBindTool = new DataObjectBindTool<CardFicheLine>();
        DataObjectBindTool<CardFicheLine> debitLineBindTool = new DataObjectBindTool<CardFicheLine>();
        //bool injected = false;
        //int sourceCardId; int destCardId; decimal amount; string note = string.Empty; int connectedInvoiceId; byte cashCategoryId;

        public Manp_CardTransaction()
        {
            InitializeComponent();
        }

        //public Manp_CardTransaction(int _sourceCardId,int _destCardId,decimal _amount, string _note, int _connectedInvoiceId, byte _cashCategoryId)
        //{
        //    InitializeComponent();
        //    sourceCardId = _sourceCardId;
        //    destCardId = _destCardId;
        //    amount = _amount;
        //    note = _note;
        //    connectedInvoiceId = _connectedInvoiceId;
        //    cashCategoryId = _cashCategoryId;
        //    IsEditMode = true;
        //    injected = true;
        //}

        private void Manp_CardTransaction_Load(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void Manp_CardTransaction_Shown(object sender, EventArgs e)
        {
            if (!IsEditMode)
            {
                foreach (Control c in grpCenter.Controls) c.Enabled = false;
                btnOk.Enabled = false;
            }
            List<IBaseOperation> loadOperations = new List<IBaseOperation>();

            IBaseOperation baseOperation = dataHolder.LoadEnumData();
            loadOperations.Add(baseOperation);

            Operation<List<CardView>> op_CardMaster = OperationHandler.GetCardsByUserId(StaticData.CurrentUserId);
            loadOperations.Add(op_CardMaster);

            if (Id != 0)
            {
                Operation<CardFiche> op_ExistingCardFiche = OperationHandler.GetCardFicheById(Id);
                loadOperations.Add(op_ExistingCardFiche);
                cardFiche = op_ExistingCardFiche.Value;
                creditLine = cardFiche.Lines.Where(x => x.SignType < 0).FirstOrDefault();
                debitLine = cardFiche.Lines.Where(x => x.SignType > 0).FirstOrDefault();
            }
            else
            {
                cardFiche = new CardFiche();
                cardFiche.CreatedDate = DateTime.Now;
                cardFiche.CreatedBy = StaticData.CurrentUserId;
                cardFiche.StatusId = 11;
            }

            foreach (IBaseOperation ibop in loadOperations)
            {
                if (!ibop.Successful)
                {
                    SetError(ibop.Fail);
                    return;
                }
            }

            Cards = op_CardMaster.Value;
            CashTypes = dataHolder.CashTypes;
            lookUpCashType.Properties.DataSource = CashTypes;
            searchLookUpSourceCard.Properties.DataSource = Cards;
            searchLookUpDestCard.Properties.DataSource = Cards;

            
            ficheBindTool.BindControl(lookUpCashType, nameof(cardFiche.CashTypeId));
            ficheBindTool.BindControl(txtNote, nameof(cardFiche.Note));
            ficheBindTool.BindControl(txtFicheno, nameof(cardFiche.Ficheno));

            if (creditLine == null) creditLine = new CardFicheLine();
            creditLineBindTool.BindControl(searchLookUpSourceCard, nameof(creditLine.CardId));
            creditLineBindTool.BindControl(sourceCurrencyRate, nameof(creditLine.CurrencyRate));
            creditLineBindTool.BindControl(sourceAmount, nameof(creditLine.Total));

            if (debitLine == null) debitLine = new CardFicheLine();
            debitLineBindTool.BindControl(searchLookUpDestCard, nameof(debitLine.CardId));
            debitLineBindTool.BindControl(destCurrencyRate, nameof(debitLine.CurrencyRate));
            debitLineBindTool.BindControl(destAmount, nameof(debitLine.Total));

            ficheBindTool.DataObject = cardFiche;
            creditLineBindTool.DataObject = creditLine;
            debitLineBindTool.DataObject = debitLine;

            txtDate.Text = cardFiche.CreatedDate.ToString(StaticData.DateTimeFromatStr);

            ControlCurrencies();
            //if (injected)
            //{


            //    //CardView sourceCard = Cards.Where(x => x.Id == sourceCardId).FirstOrDefault();
            //    //lookUpCurrency.EditValue = sourceCard?.CurrencyId;
            //    //searchLookUpSourceCard.EditValue = sourceCard?.Id;
            //    //searchLookUpDestCard.EditValue = destCardId;
            //    //sourceAmount.EditValue = amount;
            //    //txtNote.Text = note;
            //    ////lookUpCurrency.ReadOnly = true;
            //    //cashTransaction.ConnectedFicheId = connectedInvoiceId;
            //}
        }


        private void SetError(string fail,bool disableControls = true)
        {
            if (disableControls)
            {
                grpCenter.Enabled = false;
                btnOk.Enabled = false;
            }
            if (fail == null) fail = "Unknown Error";
            lblError.Text = "Error : " + fail;
            lblError.BackColor = Color.Red;
        }

        void ControlCurrencies()
        {
            if (searchLookUpSourceCard.EditValue != null)
            {
                CardView cardView = Cards.Find(x => x.Id == Convert.ToInt32(searchLookUpSourceCard.EditValue));
                if (cardView != null)
                {
                    lblSourceCurrName.Text = cardView.CurrencyName;
                    if (cardView.CurrencyId == StaticData.MainCurrency.Id)
                    {
                        sourceCurrencyRate.EditValue = 1;
                        sourceCurrencyRate.Enabled = false;
                    }
                    else
                    {
                        sourceCurrencyRate.Enabled = true;
                    }
                }
            }
            if (searchLookUpDestCard.EditValue != null)
            {
                CardView cardView = Cards.Find(x => x.Id == Convert.ToInt32(searchLookUpDestCard.EditValue));
                if (cardView != null)
                {
                    lblDestCurrName.Text = cardView.CurrencyName;
                    if (cardView.CurrencyId == StaticData.MainCurrency.Id)
                    {
                        destCurrencyRate.EditValue = 1;
                        destCurrencyRate.Enabled = false;
                    }
                    else
                    {
                        destCurrencyRate.Enabled = true;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!IsEditMode) { Close(); return; }
            
            if (UIFunctions.CheckCancellation()) Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            cardFiche = ficheBindTool.DataObject;
            creditLine = creditLineBindTool.DataObject;
            debitLine = debitLineBindTool.DataObject;
            creditLine.SignType = -1;
            debitLine.SignType = 1;
            cardFiche.Lines = new List<CardFicheLine> { creditLine, debitLine };
            Operation<CardFiche> postedCashTransaction = OperationHandler.PostCardFiche(cardFiche);
            if (postedCashTransaction.Successful) this.Close();
            SetError(postedCashTransaction.Fail, false);
        }

        private void searchLookUpSourceCard_EditValueChanged(object sender, EventArgs e)
        {
            ControlCurrencies();
        }

        private void searchLookUpDestCard_EditValueChanged(object sender, EventArgs e)
        {
            ControlCurrencies();
        }
    }
}