using LecERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    public class DataHolder
    {
        public List<ItemView> Items {get; private set;}
        public List<Currency> Currencies { get; private set;}
        public List<CardView> Cards {get; private set;}
        public List<Warehouse> Warehouses {get; private set;}
        public List<ItemPrice> ItemPrices {get; private set;}
        public List<DocumentMaster> DocumentMasters {get; private set;}
        public List<LineCalcType> LineCalcTypes {get; private set;}
        public List<ItemType> ItemTypes { get; private set; }
        public List<CardType> CardTypes { get; private set; }
        public List<CashType> CashTypes { get; private set; }
        public List<DocumentStatusType> DocumentStatusTypes { get; private set; }

        public IBaseOperation LoadEnumData()
        {
            List<IBaseOperation> loadOperations = new List<IBaseOperation>();

            Operation<List<LineCalcType>> op_LineCalcType = OperationHandler.GetLineCalcTypes();
            loadOperations.Add(op_LineCalcType);
            Operation<List<ItemType>> op_ItemTypes = OperationHandler.GetItemTypes();
            loadOperations.Add(op_ItemTypes);
            Operation<List<CardType>> op_CardTypes = OperationHandler.GetCardTypes();
            loadOperations.Add(op_CardTypes);
            Operation<List<Currency>> op_Currencies = OperationHandler.GetCurrencies();
            loadOperations.Add(op_Currencies);
            Operation<List<CashType>> op_CashTypes = OperationHandler.GetCashTypes();
            loadOperations.Add(op_CashTypes);
            Operation<List<DocumentStatusType>> op_DocumentStatusTypes = OperationHandler.GetDocumentStatusTypes();
            loadOperations.Add(op_DocumentStatusTypes);
            Operation<List<DocumentMaster>> op_DocumentMasters = OperationHandler.GetDocumentMasters();
            loadOperations.Add(op_DocumentMasters);

            foreach (IBaseOperation ibop in loadOperations)
            {
                if (!ibop.Successful)
                {
                    return ibop;
                }
            }


            LineCalcTypes = op_LineCalcType.Value;
            ItemTypes = op_ItemTypes.Value;
            CardTypes = op_CardTypes.Value;
            Currencies = op_Currencies.Value;
            CashTypes = op_CashTypes.Value;
            DocumentStatusTypes = op_DocumentStatusTypes.Value;
            DocumentMasters = op_DocumentMasters.Value;
            return new BaseOperation { Successful = true };
        }

        public IBaseOperation LoadMasterData()
        {
            List<IBaseOperation> loadOperations = new List<IBaseOperation>();
            //Operation<List<EnumMaster>> op_ItemTypes = OperationHandler.GetEnums(3);
            //loadOperations.Add(op_ItemTypes);
            Operation<List<ItemView>> op_Items = OperationHandler.GetItems();
            loadOperations.Add(op_Items);
            //Operation<List<ExchangeMaster>> op_ExchangeMaster = OperationHandler.GetAllExchanges();
            //loadOperations.Add(op_ExchangeMaster);
            Operation<List<CardView>> op_CardMaster = OperationHandler.GetCards();
            loadOperations.Add(op_CardMaster);
            Operation<List<Warehouse>> op_Warehouses = OperationHandler.GetWarehouses();
            loadOperations.Add(op_Warehouses);

            //Operation<List<WarehouseMaster>> op_Warehouses = OperationHandler.GetWarehouses();
            //loadOperations.Add(op_Warehouses);
            //Operation<List<ItemPrice>> op_ItemPrices = OperationHandler.GetItemPricesList();
            //loadOperations.Add(op_ItemPrices);
            //Operation<List<DocumentMaster>> op_DocumentMasters = OperationHandler.GetDocumentMasters();
            //loadOperations.Add(op_DocumentMasters);


            //foreach (IBaseOperation ibop in loadOperations)
            //{
            //    if (!ibop.Successful)
            //    {
            //        return ibop;
            //    }
            //}

            Items = op_Items.Value;
            Cards = op_CardMaster.Value;
            Warehouses = op_Warehouses.Value;
            //ItemPrices = op_ItemPrices.Value;
            //DocumentMasters = op_DocumentMasters.Value;
            //PriceCalcTypes = op_PriceCalcTypes.Value;




            return new BaseOperation { Successful = true };
        }

        //public List<FicheLineServiceView> GetFicheLineServicesView(int cardId)
        //{
        //    List<FicheLineServiceView> lines = new List<FicheLineServiceView>();
        //    foreach (var itemSrv in Items.Where(x => x.ItemTypeId == 2))
        //    {
        //        FicheLineServiceView srv = new FicheLineServiceView();
        //        srv.ServiceItemId = itemSrv.Id;
        //        srv.Amount = 1;
        //        srv.ItemCode = itemSrv.ItemCode;
        //        srv.ItemName = itemSrv.ItemName;
        //        srv.ItemPrice = itemSrv.DefaultSalePrice;
        //        srv.LinePrice = srv.ItemPrice;
        //        ItemPrice itemPrice = ItemPrices.Where (x => x.ItemId == srv.Id && x.PriceTypeId == 2 && x.CardId == cardId).FirstOrDefault();
                
        //        if (itemPrice != null)
        //        {
        //            srv.LinePrice = itemPrice.Price;
        //        }
        //        lines.Add(srv);
        //    }
        //    return lines;
        //}
    }
}
