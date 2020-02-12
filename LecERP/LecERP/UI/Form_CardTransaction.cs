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
    public partial class Form_CardTransaction : DevExpress.XtraEditors.XtraForm
    {
        public Form_CardTransaction()
        {
            InitializeComponent();
        }

        private void Form_CashTransaction_Load(object sender, EventArgs e)
        {
            dateBegin.DateTime = DateTime.Today;
            dateEnd.DateTime = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            tsAddNew.Enabled = StaticData.IsPermitted(29);
            tsModify.Enabled = StaticData.IsPermitted(30);
            tsDelete.Enabled = StaticData.IsPermitted(31);
            tsAcceptCashTran.Enabled = StaticData.IsPermitted(36);
            tsReserveCash.Enabled = StaticData.IsPermitted(37);
        }

        private void Form_CashTransaction_Shown(object sender, EventArgs e)
        {

        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            Manp_CardTransaction manp = new Manp_CardTransaction();
            manp.IsEditMode = true;
            manp.ShowDialog();
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        void RefreshData()
        {
            Operation<List<CardFicheLineView>> op_CashTransactions = OperationHandler.GetCardFicheLinesView(dateBegin.DateTime, dateEnd.DateTime,StaticData.CurrentUserId);
            gcData.DataSource = op_CashTransactions.Value;
        }

        private void lookUpFicheType_EditValueChanged(object sender, EventArgs e)
        {
            gcData.DataSource = null;
        }

        private void tsModify_Click(object sender, EventArgs e)
        {
            if (gvData.GetFocusedRow() is CardFicheLineView lineView)
            {
                Manp_CardTransaction manp = new Manp_CardTransaction();
                manp.Id = lineView.CardFicheId;
                manp.IsEditMode = true;
                manp.ShowDialog();
                RefreshData();
            }
           
        }

        private void tsView_Click(object sender, EventArgs e)
        {
            if (gvData.GetFocusedRow() is CardFicheLineView lineView)
            {
                Manp_CardTransaction manp = new Manp_CardTransaction();
                manp.Id = lineView.CardFicheId;
                manp.IsEditMode = false;
                manp.ShowDialog();
                RefreshData();
            }
        }

        

        private void tsExportToExcel_Click(object sender, EventArgs e)
        {
            gvData.ExportExcell();
        }

        

        private void tsAcceptCashTran_Click(object sender, EventArgs e)
        {

            if (gvData.GetFocusedRow() is CardFicheLineView lineView)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Əminsinizmi?", "Kassa Tranzaksiya", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CardFiche cardFiche = OperationHandler.GetCardFicheById(lineView.CardFicheId).Value;
                    cardFiche.StatusId = 12;
                    var oper = OperationHandler.PostCardFiche(cardFiche);
                    if (oper.Successful)
                    {
                        XtraMessageBox.Show("Təhvil alındı");
                    }
                    else
                    {
                        XtraMessageBox.Show("Səhvlik oldu " + oper.Fail);
                    }
                }
            }
            RefreshData();
        }

        private void tsReserveCash_Click(object sender, EventArgs e)
        {
            if (gvData.GetFocusedRow() is CardFicheLineView lineView)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Əminsinizmi?", "Kassa Tranzaksiya", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CardFiche cardFiche = OperationHandler.GetCardFicheById(lineView.CardFicheId).Value;
                    cardFiche.StatusId = 10;
                    var oper = OperationHandler.PostCardFiche(cardFiche);
                    if (oper.Successful)
                    {
                        XtraMessageBox.Show("Rezervə alındı");
                    }
                    else
                    {
                        XtraMessageBox.Show("Səhvlik oldu " + oper.Fail);
                    }
                }
            }
            RefreshData();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            if (gvData.GetFocusedRow() is CardFicheLineView lineView)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Əminsinizmi?", "Kassa Tranzaksiya", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    CardFiche cardFiche = OperationHandler.GetCardFicheById(lineView.CardFicheId).Value;
                    cardFiche.StatusId = 13;
                    var oper = OperationHandler.PostCardFiche(cardFiche);
                    if (oper.Successful)
                    {
                        XtraMessageBox.Show("Ləğv olundu");
                    }
                    else
                    {
                        XtraMessageBox.Show("Səhvlik oldu " + oper.Fail);
                    }
                }
            }
            RefreshData();
        }
    }
}