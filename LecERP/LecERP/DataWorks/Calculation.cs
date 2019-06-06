using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LecERP.Models;
namespace LecERP
{
    public class Calculation
    {
        public decimal CalculateLineTotal(byte LineCalType, decimal Price, decimal Quantity, decimal Width, decimal Lenght)
        {
            decimal total = 0;
            if (LineCalType == 1) total= Math.Round(Price * Quantity, 2);
            if (LineCalType == 2) total = Math.Round(Price * Quantity * Width * Lenght / 1000000, 2);
            return total;
        }
        public decimal CalculateLinePrice(ItemView item, DocumentMaster documentType, List<ItemPrice> itemPrices)
        {
            byte priceType = PriceTypeByDocumentType(documentType);

            decimal price = 0;

            ItemPrice priceOfCard = itemPrices.Where(x => x.ItemId == item.Id && x.PriceTypeId == priceType).FirstOrDefault();
            if (priceOfCard != null)
            {
                price = priceOfCard.Price;
            }
            else
            {
                price = GetItemDefaultPriceByDocumentType(item,documentType);
            }
            return price;

            //if (priceType == 2) return item.DefaultSalePrice;
            //if (priceType == 1) return item.DefaultPurchasePrice;

            //decimal itemPrice = 0;
            //byte priceType = 0;
            //if (DocumentType.Id == 1 || DocumentType.Id == 2)
            //{
            //    itemPrice = item.DefaultSalePrice;
            //    priceType = 2;
            //}
            //else
            //{
            //    itemPrice = item.DefaultPurchasePrice;
            //    priceType = 1;
            //}

            //decimal linePrice = itemPrice;
            //ItemPrice priceOfCard = itemPrices.Where(x => x.ItemId == line.ItemId && x.PriceTypeId == priceType).FirstOrDefault();
            //if (priceOfCard != null) linePrice = priceOfCard.Price;
            //if (isNew && updateLinePrice) line.LinePrice = linePrice;
            //decimal price = 0;
            //if (LineCalType == 1) price = Math.Round(Price * Quantity, 2);
            //if (LineCalType == 2) price = Math.Round(Price * Quantity * Width * Lenght / 1000000, 2);
            //return price;
        }

        public decimal GetItemDefaultPriceByDocumentType(ItemView item, DocumentMaster DocumentType)
        {
            if (item == null) return 0;
            byte priceType = PriceTypeByDocumentType(DocumentType);
            if (priceType == 2) return item.DefaultSalePrice;
            if (priceType == 1) return item.DefaultPurchasePrice;
            return 0;
            //decimal itemPrice = 0;
            //byte priceType = 0;
            //if (DocumentType.Id == 1 || DocumentType.Id == 2)
            //{
            //    itemPrice = item.DefaultSalePrice;
            //    priceType = 2;
            //}
            //else
            //{
            //    itemPrice = item.DefaultPurchasePrice;
            //    priceType = 1;
            //}

            //decimal linePrice = itemPrice;
            //ItemPrice priceOfCard = itemPrices.Where(x => x.ItemId == line.ItemId && x.PriceTypeId == priceType).FirstOrDefault();
            //if (priceOfCard != null) linePrice = priceOfCard.Price;
            //if (isNew && updateLinePrice) line.LinePrice = linePrice;
            //decimal price = 0;
            //if (LineCalType == 1) price = Math.Round(Price * Quantity, 2);
            //if (LineCalType == 2) price = Math.Round(Price * Quantity * Width * Lenght / 1000000, 2);
            //return price;
        }

        public byte PriceTypeByDocumentType(DocumentMaster DocumentType)
        {
            if (DocumentType.Id == 1 || DocumentType.Id == 2)
            {
                return 2;
            }
            if (DocumentType.Id == 3 || DocumentType.Id == 4) 
            {
                return 1;
            }
            return 0;
        }

    }
}
