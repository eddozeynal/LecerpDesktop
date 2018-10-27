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
    public partial class Manp_ItemPriceByItem : DevExpress.XtraEditors.XtraForm
    {
        public VW_ItemPricesDefault itemDef { get; set; }
        List<ItemPriceForCard> ItemPriceForCards = null;
        public Manp_ItemPriceByItem()
        {
            InitializeComponent();
        }

        private void Manp_ItemPriceByItem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void pnlExecution_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(Handle);
        }

        private void Manp_ItemPriceByItem_Shown(object sender, EventArgs e)
        {
            spPurchasePrice.Visible = StaticData.IsPermitted(16);
            spSalePrice.Visible = StaticData.IsPermitted(17);
            gcCards.Visible = StaticData.IsPermitted(18);
            btnOk.Visible = StaticData.IsPermitted(19);

            gvCards.AssignGridView(13);

            Operation<List<ItemPriceForCard>> op_ItemPriceForCards = OperationHandler.GetItemPriceForCards(itemDef.ItemId);

            if (op_ItemPriceForCards.Successful)
            {
                ItemPriceForCards = op_ItemPriceForCards.Value;
                gcCards.DataSource = ItemPriceForCards;
            }
            else
            {
                //
            }
            txtItemCode.Text = itemDef.ItemCode;
            txtItemName.Text = itemDef.ItemName;
            txtItemType.Text = itemDef.ItemTypeName;
            spPurchasePrice.Value = itemDef.PurchasePrice;
            spSalePrice.Value = itemDef.SalePrice;



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (UIFunctions.CheckCancellation()) Close();
        }
     
        private void lblError_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(Handle);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<ItemPriceOperation> lst = new List<ItemPriceOperation>();

            ItemPriceOperation itemPrice = null;

            itemPrice = new ItemPriceOperation();
            itemPrice.CardId = 0;
            itemPrice.CreatedBy = StaticData.CurrentUserId;
            itemPrice.CreatedDate = DateTime.Now;
            itemPrice.ItemId = itemDef.ItemId;
            itemPrice.Price = spPurchasePrice.Value;
            itemPrice.PriceTypeId = 1;
            itemPrice.OperationType = 1;
            lst.Add(itemPrice);

            itemPrice = new ItemPriceOperation();
            itemPrice.CardId = 0;
            itemPrice.CreatedBy = StaticData.CurrentUserId;
            itemPrice.CreatedDate = DateTime.Now;
            itemPrice.ItemId = itemDef.ItemId;
            itemPrice.Price = spSalePrice.Value;
            itemPrice.PriceTypeId = 2;
            itemPrice.OperationType = 1;
            lst.Add(itemPrice);


            foreach (ItemPriceForCard itc in ItemPriceForCards)
            {
                itemPrice = new ItemPriceOperation();
                itemPrice.CardId = itc.CardId;
                itemPrice.CreatedBy = StaticData.CurrentUserId;
                itemPrice.CreatedDate = DateTime.Now;
                itemPrice.ItemId = itemDef.ItemId;
                itemPrice.Price = Convert.ToDecimal(itc.Price);
                itemPrice.PriceTypeId = 2;
                if (itc.IsSpecial)
                {
                    itemPrice.OperationType = 1;
                }
                else
                {
                    itemPrice.OperationType = 0;
                }
                lst.Add(itemPrice);
            }

            Operation<bool> operation = OperationHandler.PostItemPrices(lst);
            if (operation.Successful) this.Close();
            lblError.Text = operation.Fail;
        }
    }
}