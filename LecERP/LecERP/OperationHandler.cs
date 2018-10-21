using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    public static class OperationHandler
    {
        public static Operation<Item> PostItem(Item item)
        {
            IServiceGate<Item> sw = GateHandler.GetServiceGate<Item>();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["item"] = item;
            Operation<Item> op_item = sw.Post("PostItem", prms);
            return op_item;
        }
        public static Operation<Item> GetItem(int Id)
        {
            IServiceGate<Item> sw = GateHandler.GetServiceGate<Item>();
            Operation<Item> op_item = sw.Get("GetItem/" + Id.ToString());
            return op_item;
        }
        public static Operation<List<EnumMaster>> GetEnums(byte EnumNumber)
        {
            IServiceGate<List<EnumMaster>> sw = GateHandler.GetServiceGate<List<EnumMaster>>();
            Operation<List<EnumMaster>> op_item = sw.Get("GetEnums/"+ EnumNumber.ToString());
            return op_item;
        }
        public static Operation<List<Parameter>> GetParameters()
        {
            IServiceGate<List<Parameter>> sw = GateHandler.GetServiceGate<List<Parameter>>();
            Operation<List<Parameter>> op_item = sw.Get("GetParameters");
            return op_item;
        }
        public static GridViewInfo GetGridViewInfo(int Id)
        {
            IServiceGate<GridViewInfo> sw = GateHandler.GetServiceGate<GridViewInfo>();
            Operation<GridViewInfo> op_item = sw.Get("GetGridViewInfo/" + Id.ToString() + "/" + StaticData.CurrentUserId);
            return op_item.Value;
        }
        public static Operation<List<VW_Item>> GetAllItems()
        {
            IServiceGate<List<VW_Item>> sw = GateHandler.GetServiceGate<List<VW_Item>>();
            Operation<List<VW_Item>> op_item = sw.Get("GetAllItems");
            return op_item;
        }
        public static Operation<List<VW_CardMaster>> GetAllCards()
        {
            IServiceGate<List<VW_CardMaster>> sw = GateHandler.GetServiceGate<List<VW_CardMaster>>();
            Operation<List<VW_CardMaster>> op_ = sw.Get("GetAllCards");
            return op_;
        }
        public static Operation<List<ExchangeMaster>> GetAllExchanges()
        {
            IServiceGate<List<ExchangeMaster>> sw = GateHandler.GetServiceGate<List<ExchangeMaster>>();
            Operation<List<ExchangeMaster>> op_ = sw.Get("GetAllExchanges");
            return op_;
        }
        public static Operation<CardMaster> GetCardMaster(int Id)
        {
            IServiceGate<CardMaster> sw = GateHandler.GetServiceGate<CardMaster>();
            Operation<CardMaster> op_card = sw.Get("GetCardMaster/" + Id.ToString());
            return op_card;
        }
        public static Operation<CardMaster> PostCardMaster(CardMaster cardMaster)
        {
            IServiceGate<CardMaster> sw = GateHandler.GetServiceGate<CardMaster>();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["cardMaster"] = cardMaster;
            Operation<CardMaster> op_item = sw.Post("PostCardMaster", prms);
            return op_item;
        }
        public static Operation<List<ExchangeByDate>> GetExchangesFromBankByDate(DateTime Date_)
        {
            IServiceGate<List<ExchangeByDate>> sw = GateHandler.GetServiceGate<List<ExchangeByDate>>();
            Operation<List<ExchangeByDate>> op_item = sw.Get("GetExchangesFromBankByDate/" + Date_.ToString("yyyy-MM-dd"));
            return op_item;
        }

        public static Operation<List<VW_ItemPricesDefault>> GetItemDefaultPricesView()
        {
            IServiceGate<List<VW_ItemPricesDefault>> sw = GateHandler.GetServiceGate<List<VW_ItemPricesDefault>>();
            Operation<List<VW_ItemPricesDefault>> op_item = sw.Get("GetItemDefaultPricesView");
            return op_item;
        }
        public static Operation<List<ItemPriceForCard>> GetItemPriceForCards(int ItemId)
        {
            IServiceGate<List<ItemPriceForCard>> sw = GateHandler.GetServiceGate<List<ItemPriceForCard>>();
            Operation<List<ItemPriceForCard>> op_item = sw.Get("GetItemPriceForCards/" + ItemId.ToString());
            return op_item;
        }
        public static Operation<bool> PostItemPrices(List<ItemPriceOperation> ItemPrices)
        {
            IServiceGate<bool> sw = GateHandler.GetServiceGate<bool>();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["ItemPrices"] = ItemPrices;
            Operation<bool> op_ = sw.Post("PostItemPrices", prms);
            return op_;
        }

        public static Operation<User> LoginUser(string UserName, string Password)
        {
            IServiceGate<User> sw = GateHandler.GetServiceGate<User>();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["UserName"] = UserName;
            prms["Password"] = Password;
            Operation<User> op_ = sw.Post("LoginUser",prms);
            return op_;
        }
        public static Operation<List<DocumentMaster>> GetDocumentMasters()
        {
            IServiceGate<List<DocumentMaster>> sw = GateHandler.GetServiceGate<List<DocumentMaster>>();
            Operation<List<DocumentMaster>> op_ = sw.Get("GetDocumentMasters");
            return op_;
        }
        public static Operation<List<WarehouseMaster>> GetWarehouses()
        {
            IServiceGate<List<WarehouseMaster>> sw = GateHandler.GetServiceGate<List<WarehouseMaster>>();
            Operation<List<WarehouseMaster>> op_ = sw.Get("GetWarehouses");
            return op_;
        }
        public static Operation<List<ItemPrice>> GetItemPricesList()
        {
            IServiceGate<List<ItemPrice>> sw = GateHandler.GetServiceGate<List<ItemPrice>>();
            Operation<List<ItemPrice>> op_ = sw.Get("GetItemPricesList");
            return op_;
        }
        public static Operation<Fiche> PostFiche(Fiche fiche)
        {
            IServiceGate<Fiche> sw = GateHandler.GetServiceGate<Fiche>();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["fiche"] = fiche;
            Operation<Fiche> op_ = sw.Post("PostFiche", prms);
            return op_;
        }
        public static Operation<List<VW_FicheMaster>> GetFiches(byte DocType, DateTime dateBegin, DateTime dateEnd)
        {
            IServiceGate<List<VW_FicheMaster>> sw = GateHandler.GetServiceGate<List<VW_FicheMaster>>();
            string method = "GetFiches/{0}/{1}/{2}";
            method = string.Format(method, DocType, dateBegin.GetFormattedStringFromDate(), dateEnd.GetFormattedStringFromDate());
            Operation<List<VW_FicheMaster>> op_ = sw.Get(method);
            return op_;
        }
        public static Operation<List<PriceCalcType>> GetPriceCalcTypes()
        {
            IServiceGate<List<PriceCalcType>> sw = GateHandler.GetServiceGate<List<PriceCalcType>>();
            string method = "GetPriceCalcTypes";
            Operation<List<PriceCalcType>> op_ = sw.Get(method);
            return op_;
        }
        public static Operation<Fiche> GetFicheById(int Id)
        {
            IServiceGate<Fiche> sw = GateHandler.GetServiceGate<Fiche>();
            string method = "GetFicheById/{0}";
            method = string.Format(method, Id);
            Operation<Fiche> op_ = sw.Get(method);
            return op_;
        }
        public static Operation<List<PermissionMaster>> GetPermissionMasters()
        {
            IServiceGate<List<PermissionMaster>> sw = GateHandler.GetServiceGate<List<PermissionMaster>>();
            string method = "GetPermissionMasters";
            Operation<List<PermissionMaster>> op_ = sw.Get(method);
            return op_;
        }
        public static Operation<List<PermissionDetail>> GetPermissionDetailsByUserId(int UserId)
        {
            IServiceGate<List<PermissionDetail>> sw = GateHandler.GetServiceGate<List<PermissionDetail>>();
            string method = "GetPermissionDetailsByUserId/{0}";
            method = string.Format(method, UserId);
            Operation<List<PermissionDetail>> op_ = sw.Get(method);
            return op_;
        }
        public static Operation<List<BaseUser>> GetUsers()
        {
            IServiceGate<List<BaseUser>> sw = GateHandler.GetServiceGate<List<BaseUser>>();
            string method = "GetUsers";
            Operation<List<BaseUser>> op_ = sw.Get(method);
            return op_;
        }
        public static Operation<User> GetUserById(int UserId)
        {
            IServiceGate<User> sw = GateHandler.GetServiceGate<User>();
            string method = "GetUserById/{0}";
            method = string.Format(method, UserId);
            Operation<User> op_ = sw.Get(method);
            return op_;
        }

        public static Operation<User> PostUser(User user)
        {
            IServiceGate<User> sw = GateHandler.GetServiceGate<User>();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["user"] = user;
            Operation<User> op_item = sw.Post("PostUser", prms);
            return op_item;
        }
        public static Operation<CashTransaction> GetCashTransactionById(int CashTransactionId)
        {
            IServiceGate<CashTransaction> sw = GateHandler.GetServiceGate<CashTransaction>();
            string method = "GetCashTransactionById/{0}";
            method = string.Format(method, CashTransactionId);
            Operation<CashTransaction> op_ = sw.Get(method);
            return op_;
        }
        public static Operation<CashTransaction> PostCashTransaction(CashTransaction cashTransaction)
        {
            IServiceGate<CashTransaction> sw = GateHandler.GetServiceGate<CashTransaction>();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["cashTransaction"] = cashTransaction;
            Operation<CashTransaction> op_item = sw.Post("PostCashTransaction", prms);
            return op_item;
        }
        public static Operation<List<CashTransactionView>> GetCashTransactionsView(DateTime dateBegin, DateTime dateEnd, int userId)
        {
            IServiceGate<List<CashTransactionView>> sw = GateHandler.GetServiceGate<List<CashTransactionView>>();
            string method = "GetCashTransactionsView/{0}/{1}/{2}";
            method = string.Format(method, dateBegin.GetFormattedStringFromDate(), dateEnd.GetFormattedStringFromDate(),userId);
            Operation<List<CashTransactionView>> op_ = sw.Get(method);
            return op_;
        }

        public static Operation<List<VW_CardMaster>> GetAllCardsExt(DateTime date, int userId)
        {
            IServiceGate<List<VW_CardMaster>> sw = GateHandler.GetServiceGate<List<VW_CardMaster>>();
            string method = "GetAllCardsExt/{0}/{1}";
            method = string.Format(method, date.GetFormattedStringFromDate(), userId);
            Operation<List<VW_CardMaster>> op_ = sw.Get(method);
            return op_;
        }
        public static Operation<List<UserDataPermissionView>> GetUserDataPermissionView(int userId)
        {
            IServiceGate<List<UserDataPermissionView>> sw = GateHandler.GetServiceGate<List<UserDataPermissionView>>();
            string method = "GetUserDataPermissionView/{0}";
            method = string.Format(method, userId);
            Operation<List<UserDataPermissionView>> op_ = sw.Get(method);
            return op_;
        }
    }
}
