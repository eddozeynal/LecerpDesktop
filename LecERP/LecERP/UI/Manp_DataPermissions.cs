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
    public partial class Manp_DataPermissions : DevExpress.XtraEditors.XtraForm
    {
        public int UserId { get; set; }

        List<CardView> AllCards = new List<CardView> ();
        
        List<CardPermission> cardPermissions = new List<CardPermission>();
        public Manp_DataPermissions( )
        {
            InitializeComponent();
        }

        List<CardView> PermittedCards
        {
            get
            {
                List<CardView> cardViews = AllCards.DeepClone();
                cardPermissions = OperationHandler.GetCardPermissions(UserId).Value;
                foreach (var card in cardViews.Reverse<CardView>())
                {
                    if (!cardPermissions.Select(x => x.CardId).Contains(card.Id)) cardViews.Remove(card);
                }
                return cardViews;
            }
        }

        void refreshLines()
        {
            
            gcLines.DataSource = PermittedCards;
        }
        private void Manp_DataPermissions_Load(object sender, EventArgs e)
        {

        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            object objValue = searchLookUpCard.EditValue;
            if (objValue == null) return;
            CardPermission cardPermission = new CardPermission();
            cardPermission.CreatedBy = StaticData.CurrentUserId;
            cardPermission.CreatedDate = DateTime.Now;
            cardPermission.UserId = UserId;
            cardPermission.CardId = Convert.ToInt32(objValue);
            Operation<CardPermission> operation = OperationHandler.PostCardPermission(cardPermission);
            if (!operation.Successful)
            {
                MessageBox.Show(operation.Fail);
            }
            refreshLines();
        }

        private void Manp_DataPermissions_Shown(object sender, EventArgs e)
        {
            var op_CardMaster = OperationHandler.GetCards();
            if (op_CardMaster.Successful)
            {
                AllCards = op_CardMaster.Value.Where(x => x.ByPermission).ToList();
                searchLookUpCard.Properties.DataSource = AllCards;
            }
            User user = OperationHandler.GetUserById(UserId).Value;
            txtUserName.Text = user.UserName;
            refreshLines();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            object objId = gvLines.GetFocusedRow();
            if (objId == null) return;
            int cardViewId = (objId as CardView).Id;
            int cardPermissionId = cardPermissions.Where(x => x.CardId == cardViewId).FirstOrDefault().Id;
            Operation<string> operation = OperationHandler.DeleObjectById(nameof(CardPermission), cardPermissionId);
            if (!operation.Successful)
            {
                MessageBox.Show(operation.Fail);
            }
            refreshLines();
        }
    }
}