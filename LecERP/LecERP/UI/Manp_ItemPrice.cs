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
using LecERP.ViewModels;

namespace LecERP
{
    public partial class Manp_ItemPrice : DevExpress.XtraEditors.XtraForm
    {
        public ItemView item { get; set; }
        
        public Manp_ItemPrice()
        {
            InitializeComponent();
        }

        private void Manp_ItemPriceByItem_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            lblError.Text = string.Empty;
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

            List<CardView> cards = OperationHandler.GetCards().Value.Where(x=>x.CardTypeId == 1 || x.CardTypeId ==2).ToList();
            List<ItemPrice> ItemPrices = OperationHandler.GetItemPrices(item.Id).Value;
            List<ItemPriceView> priceView = new List<ItemPriceView>();
            foreach (CardView card in cards)
            {
                ItemPriceView price = new ItemPriceView();
                price.CardId = card.Id;
                price.CardName = card.CardName;
                price.CardNumber = card.CardNumber;
                ItemPrice priceForCard = ItemPrices.Where(x=>x.CardId == card.Id).FirstOrDefault();
                if (priceForCard != null)
                {
                    price.IsSpecial = true;
                    price.Price = priceForCard.Price;
                }
                priceView.Add(price);
            }
            gcCards.DataSource = priceView;
            txtItemCode.Text = item.ItemCode;
            txtItemName.Text = item.ItemName;
            txtItemType.Text = item.ItemTypeName;
            spPurchasePrice.Value = item.DefaultPurchasePrice;
            spSalePrice.Value = item.DefaultSalePrice;



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
            List<ItemPrice> list = new List<ItemPrice>();

            ItemPrice itemPrice = null;

            itemPrice = new ItemPrice();
            itemPrice.CardId = 0;
            itemPrice.CreatedBy = StaticData.CurrentUserId;
            itemPrice.CreatedDate = DateTime.Now;
            itemPrice.ItemId = item.Id;
            itemPrice.Price = spPurchasePrice.Value;
            itemPrice.PriceTypeId = 1;
            list.Add(itemPrice);

            itemPrice = new ItemPrice();
            itemPrice.CardId = 0;
            itemPrice.CreatedBy = StaticData.CurrentUserId;
            itemPrice.CreatedDate = DateTime.Now;
            itemPrice.ItemId = item.Id;
            itemPrice.Price = spSalePrice.Value;
            itemPrice.PriceTypeId = 2;
            list.Add(itemPrice);


            foreach (ItemPriceView itc in (gcCards.DataSource as List<ItemPriceView>).Where(x=>x.IsSpecial))
            {
                itemPrice = new ItemPrice();
                itemPrice.CardId = itc.CardId;
                itemPrice.CreatedBy = StaticData.CurrentUserId;
                itemPrice.CreatedDate = DateTime.Now;
                itemPrice.ItemId = item.Id;
                itemPrice.Price = Convert.ToDecimal(itc.Price);
                itemPrice.PriceTypeId = 2;
                list.Add(itemPrice);
            }

            Operation<string> operation = OperationHandler.PostItemPrices(item.Id,list);
            if (operation.Successful) this.Close();
            lblError.Text = operation.Fail;
        }
    }
}