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
    public partial class Form_CardHistory : DevExpress.XtraEditors.XtraForm
    {
        public int CardId { get; set; }
        public Form_CardHistory()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            gvData.ExportExcell();
        }

        private void Form_CardHistory_Load(object sender, EventArgs e)
        {
            dateEnd.DateTime = DateTime.Now;
            dateBegin.DateTime = DateTime.Today.AddMonths(-6);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        void RefreshData()
        {
            var dataOper = OperationHandler.GetCardTransactionViewByCardId(CardId, dateBegin.DateTime, dateEnd.DateTime);
            if (dataOper.Successful) gcData.DataSource = dataOper.Value;
        }

        private void Form_CardHistory_Shown(object sender, EventArgs e)
        {
            gvData.AssignGridView(19);
            var cardData = OperationHandler.GetCardMaster(CardId).Value;
            this.Text = cardData.CardName;
            RefreshData();
        }
    }
}