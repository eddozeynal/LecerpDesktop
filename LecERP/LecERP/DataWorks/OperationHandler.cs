using ERPService.Models;
using LecERP.Models;
using LecERP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    public static class OperationHandler
    {
        public static Operation<string> DeleteObjectById(string TableName, int Id)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["TableName"] = TableName;
            prms["Id"] = Id;
            Operation<string> operation = client.Post<string>("DeleteObjectById", prms);
            return operation;
        }
        public static Operation<string> PostUserPermissions(int UserId, List<PermissionDetail> Details)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["UserId"] = UserId;
            prms["Details"] = Details;
            Operation<string> operation = client.Post<string>("PostUserPermissions", prms);
            return operation;
        }
        public static Operation<UserView> LoginUser(LoginData loginData)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["loginData"] = loginData;
           // prms["PassHash"] = PassHash;
            Operation<UserView> operation = client.Post<UserView>("LoginUser", prms);
            return operation;
        }
        public static Operation<WarehouseProcessDetail> CompleteWarehouseProcessDetail(int Id)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["Id"] = Id;
            prms["UserId"] = StaticData.CurrentUserId;
            Operation<WarehouseProcessDetail> operation = client.Post<WarehouseProcessDetail>("CompleteWarehouseProcessDetail", prms);
            return operation;
        }
        public static Operation<List<User>> GetUsers()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetUsers";
            Operation<List<User>> operation = client.Get<List<User>>(method);
            return operation;
        }
        public static Operation<List<DocumentStatusType>> GetDocumentStatusTypes()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetDocumentStatusTypes";
            Operation<List<DocumentStatusType>> operation = client.Get<List<DocumentStatusType>>(method);
            return operation;
        }
        public static Operation<User> GetUserById(int UserId)
        {
            string method = "GetUserById/{0}";
            method = string.Format(method, UserId);
            ServiceClient client = new ServiceClient();
            Operation<User> operation = client.Get<User>(method);
            return operation;
        }

        internal static Operation<WarehouseProcessView> PostWarehouseProcess(WarehouseProcessView warehouseProcess)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["warehouseProcess"] = warehouseProcess;
            Operation<WarehouseProcessView> operation = client.Post<WarehouseProcessView>("PostWarehouseProcess", prms);
            return operation;
        }

        public static Operation<Card> GetCardById(int cardId)
        {
            string method = "GetCardById/{0}";
            method = string.Format(method, cardId);
            ServiceClient client = new ServiceClient();
            Operation<Card> operation = client.Get<Card>(method);
            return operation;
        }
        public static Operation<User> PostUser(User user)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["user"] = user;
            Operation<User> operation = client.Post<User>("PostUser", prms);
            return operation;
        }
        public static Operation<WarehouseProcessView> WarehouseProcessBegin(int ProcessId)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["ProcessId"] = ProcessId;
            Operation<WarehouseProcessView> operation = client.Post<WarehouseProcessView>("WarehouseProcessBegin", prms);
            return operation;
        }
        public static Operation<WarehouseProcessView> WarehouseProcessEnd(int ProcessId)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["ProcessId"] = ProcessId;
            Operation<WarehouseProcessView> operation = client.Post<WarehouseProcessView>("WarehouseProcessEnd", prms);
            return operation;
        }
        public static Operation<Card> PostCard(Card card)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["card"] = card;
            Operation<Card> operation = client.Post<Card>("PostCard", prms);
            return operation;
        }

        public static Operation<List<PermissionMasterView>> GetUserPermissions(int UserId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetUserPermissions/" + UserId.ToString();
            Operation<List<PermissionMasterView>> operation = client.Get<List<PermissionMasterView>>(method);
            return operation;
        }
        public static Operation<List<ItemPrice>> GetItemPrices(int ItemId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetItemPrices/" + ItemId.ToString();
            Operation<List<ItemPrice>> operation = client.Get<List<ItemPrice>>(method);
            return operation;
        }
        public static Operation<List<ItemPrice>> GetItemPricesByCard(int CardId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetItemPricesByCard/" + CardId.ToString();
            Operation<List<ItemPrice>> operation = client.Get<List<ItemPrice>>(method);
            return operation;
        }
        public static Operation<List<WarehouseProcessDetailView>> GetWarehouseProcessDetails(int ProcessId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetWarehouseProcessDetails/" + ProcessId.ToString();
            Operation<List<WarehouseProcessDetailView>> operation = client.Get<List<WarehouseProcessDetailView>>(method);
            return operation;
        }
        public static Operation<List<CardPermission>> GetCardPermissions(int UserId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetCardPermissions/" + UserId.ToString();
            Operation<List<CardPermission>> operation = client.Get<List<CardPermission>>(method);
            return operation;
        }
        public static Operation<List<CardView>> GetCards()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetCards";
            Operation<List<CardView>> operation = client.Get<List<CardView>>(method);
            return operation;
        }

        public static Operation<CardPermission> PostCardPermission(CardPermission cardPermission)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["cardPermission"] = cardPermission;
            Operation<CardPermission> operation = client.Post<CardPermission>("PostCardPermission", prms);
            return operation;
        }

        public static Operation<List<ItemView>> GetItems()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetItems";
            Operation<List<ItemView>> operation = client.Get<List<ItemView>>(method);
            return operation;
        }

        public static Operation<List<ItemType>> GetItemTypes()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetItemTypes";
            Operation<List<ItemType>> operation = client.Get<List<ItemType>>(method);
            return operation;
        }
        public static Operation<List<LineCalcType>> GetLineCalcTypes()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetLineCalcTypes";
            Operation<List<LineCalcType>> operation = client.Get<List<LineCalcType>>(method);
            return operation;
        }
        public static Operation<List<CardType>> GetCardTypes()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetCardTypes";
            Operation<List<CardType>> operation = client.Get<List<CardType>>(method);
            return operation;
        }
        public static Operation<List<CashType>> GetCashTypes()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetCashTypes";
            Operation<List<CashType>> operation = client.Get<List<CashType>>(method);
            return operation;
        }
        public static Operation<List<WorkStateView>> GetWorkStates()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetWorkStates";
            Operation<List<WorkStateView>> operation = client.Get<List<WorkStateView>>(method);
            return operation;
        }
        public static Operation<List<CurrencyByDateView>> GetCurrenciesByDate()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetCurrenciesByDate";
            Operation<List<CurrencyByDateView>> operation = client.Get<List<CurrencyByDateView>>(method);
            return operation;
        }
        public static Operation<List<Warehouse>> GetWarehouses()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetWarehouses";
            Operation<List<Warehouse>> operation = client.Get<List<Warehouse>>(method);
            return operation;
        }
        public static Operation<Item> GetItemById(int Id)
        {
            string method = "GetItemById/{0}";
            method = string.Format(method, Id);
            ServiceClient client = new ServiceClient();
            Operation<Item> operation = client.Get<Item>(method);
            return operation;
        }

        public static Operation<Item> PostItem(Item item)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["item"] = item;
            Operation<Item> operation = client.Post<Item>("PostItem", prms);
            return operation;
        }

        public static Operation<List<Currency>> GetCurrencies()
        {
            ServiceClient client = new ServiceClient();
            string method = "GetCurrencies";
            Operation<List<Currency>> operation = client.Get<List<Currency>>(method);
            return operation;
        }

        public static Operation<string> PostItemPrices(int ItemId, List<ItemPrice> Details)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["ItemId"] = ItemId;
            prms["Details"] = Details;
            Operation<string> operation = client.Post<string>("PostItemPrices", prms);
            return operation;
        }

        public static Operation<CurrencyByDate> GetCurrencyLastValue(int Id)
        {
            string method = "GetCurrencyLastValue/{0}";
            method = string.Format(method, Id);
            ServiceClient client = new ServiceClient();
            Operation<CurrencyByDate> operation = client.Get<CurrencyByDate>(method);
            return operation;
        }
        //public static Operation<List<EnumMaster>> GetEnums(byte EnumNumber)
        //{
        //    IServiceGate<List<EnumMaster>> sw = GateHandler.GetServiceGate<List<EnumMaster>>();
        //    Operation<List<EnumMaster>> op_item = sw.Get("GetEnums/"+ EnumNumber.ToString());
        //    return op_item;
        //}
        public static Operation<List<Parameter>> GetParameters()
        {
            ServiceClient client = new ServiceClient();
            Operation<List<Parameter>> operation = client.Get<List<Parameter>>("GetParameters");
            return operation;
        }
        //public static GridViewInfo GetGridViewInfo(int Id)
        //{
        //    IServiceGate<GridViewInfo> sw = GateHandler.GetServiceGate<GridViewInfo>();
        //    Operation<GridViewInfo> op_item = sw.Get("GetGridViewInfo/" + Id.ToString() + "/" + StaticData.CurrentUserId);
        //    return op_item.Value;
        //}
        //public static Operation<List<ItemView>> GetAllItems()
        //{
        //    IServiceGate<List<ItemView>> sw = GateHandler.GetServiceGate<List<ItemView>>();
        //    Operation<List<ItemView>> op_item = sw.Get("GetAllItems");
        //    return op_item;
        //}
        //public static Operation<List<CardMasterView>> GetAllCards()
        //{
        //    IServiceGate<List<CardMasterView>> sw = GateHandler.GetServiceGate<List<CardMasterView>>();
        //    Operation<List<CardMasterView>> op_ = sw.Get("GetAllCards");
        //    return op_;
        //}
        //public static Operation<List<ExchangeMaster>> GetAllExchanges()
        //{
        //    IServiceGate<List<ExchangeMaster>> sw = GateHandler.GetServiceGate<List<ExchangeMaster>>();
        //    Operation<List<ExchangeMaster>> op_ = sw.Get("GetAllExchanges");
        //    return op_;
        //}
        //public static Operation<CardMaster> GetCardMaster(int Id)
        //{
        //    IServiceGate<CardMaster> sw = GateHandler.GetServiceGate<CardMaster>();
        //    Operation<CardMaster> op_card = sw.Get("GetCardMaster/" + Id.ToString());
        //    return op_card;
        //}
        //public static Operation<CardMaster> PostCardMaster(CardMaster cardMaster)
        //{
        //    IServiceGate<CardMaster> sw = GateHandler.GetServiceGate<CardMaster>();
        //    Dictionary<string, object> prms = new Dictionary<string, object>();
        //    prms["cardMaster"] = cardMaster;
        //    Operation<CardMaster> op_item = sw.Post("PostCardMaster", prms);
        //    return op_item;
        //}
        //public static Operation<List<ExchangeByDate>> GetExchangesFromBankByDate(DateTime Date_)
        //{
        //    IServiceGate<List<ExchangeByDate>> sw = GateHandler.GetServiceGate<List<ExchangeByDate>>();
        //    Operation<List<ExchangeByDate>> op_item = sw.Get("GetExchangesFromBankByDate/" + Date_.ToString("yyyy-MM-dd"));
        //    return op_item;
        //}

        //public static Operation<List<ItemPriceForCard>> GetItemPriceForCards(int ItemId)
        //{
        //    IServiceGate<List<ItemPriceForCard>> sw = GateHandler.GetServiceGate<List<ItemPriceForCard>>();
        //    Operation<List<ItemPriceForCard>> op_item = sw.Get("GetItemPriceForCards/" + ItemId.ToString());
        //    return op_item;
        //}
        //public static Operation<bool> PostItemPrices(List<ItemPriceOperation> ItemPrices)
        //{
        //    IServiceGate<bool> sw = GateHandler.GetServiceGate<bool>();
        //    Dictionary<string, object> prms = new Dictionary<string, object>();
        //    prms["ItemPrices"] = ItemPrices;
        //    Operation<bool> op_ = sw.Post("PostItemPrices", prms);
        //    return op_;
        //}
        //public static Operation<UserView> LoginUser(string Login, string PassHash)
        //{
        //    ServiceClient client = new ServiceClient();
        //    Dictionary<string, object> prms = new Dictionary<string, object>();
        //    prms["Login"] = Login;
        //    prms["PassHash"] = PassHash;
        //    Operation<UserView> op_ = client.Post<UserView>("LoginUser", prms);
        //    return op_;
        //}
        //public static Operation<CashTransaction> AcceptCashTransaction(int CashTransactionId)
        //{
        //    IServiceGate<CashTransaction> sw = GateHandler.GetServiceGate<CashTransaction>();
        //    Dictionary<string, object> prms = new Dictionary<string, object>();
        //    prms["CashTransactionId"] = CashTransactionId;
        //    prms["UserId"] = StaticData.CurrentUserId;
        //    Operation<CashTransaction> op_ = sw.Post("AcceptCashTransaction", prms);
        //    return op_;
        //}
        public static Operation<List<DocumentMaster>> GetDocumentMasters()
        {
            ServiceClient client = new ServiceClient();
            Operation<List<DocumentMaster>> operation = client.Get<List<DocumentMaster>>("GetDocumentMasters");
            return operation;
        }
        //public static Operation<List<WarehouseMaster>> GetWarehouses()
        //{
        //    IServiceGate<List<WarehouseMaster>> sw = GateHandler.GetServiceGate<List<WarehouseMaster>>();
        //    Operation<List<WarehouseMaster>> op_ = sw.Get("GetWarehouses");
        //    return op_;
        //}
        //public static Operation<List<ItemPrice>> GetItemPricesList()
        //{
        //    IServiceGate<List<ItemPrice>> sw = GateHandler.GetServiceGate<List<ItemPrice>>();
        //    Operation<List<ItemPrice>> op_ = sw.Get("GetItemPricesList");
        //    return op_;
        //}
        public static Operation<FicheMasterView> PostFiche(FicheMasterView fiche)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["fiche"] = fiche;
            Operation<FicheMasterView> operation = client.Post<FicheMasterView>("PostFiche", prms);
            return operation;
        }
        public static Operation<CurrencyByDate> PostCurrencyByDate(CurrencyByDate currencyByDate)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["currencyByDate"] = currencyByDate;
            Operation<CurrencyByDate> operation = client.Post<CurrencyByDate>("PostCurrencyByDate", prms);
            return operation;
        }
        //public static Operation<FicheMasterView> PostFiche2(FicheMasterView fiche)
        //{
        //    IServiceGate<FicheMasterView> sw = GateHandler.GetServiceGate<FicheMasterView>();
        //    Dictionary<string, object> prms = new Dictionary<string, object>();
        //    prms["fiche"] = fiche;
        //    Operation<FicheMasterView> op_ = sw.Post("PostFiche2", prms);
        //    return op_;
        //}
        //public static Operation<TestClassView> PostTest()
        //{
        //    IServiceGate<TestClassView> sw = GateHandler.GetServiceGate<TestClassView>();
        //    Dictionary<string, object> prms = new Dictionary<string, object>();
        //    prms["data"] = new TestClassView { Id = 5, Name = "NESE" };
        //    Operation<TestClassView> op_ = sw.Post("PostTest2", prms);
        //    return op_;
        //}
        public static Operation<List<FicheMasterView>> GetFiches(byte DocType, DateTime dateBegin, DateTime dateEnd)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetFiches/{0}/{1}/{2}";
            method = string.Format(method, DocType, dateBegin.GetFormattedStringFromDate(), dateEnd.GetFormattedStringFromDate());
            Operation<List<FicheMasterView>> operation = client.Get<List<FicheMasterView>>(method);
            return operation;
        }
        public static Operation<List<FicheReportLineViewLC>> GetFicheReportLines(DateTime dateBegin, DateTime dateEnd)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetFicheReportLines/{0}/{1}";
            method = string.Format(method, dateBegin.GetFormattedStringFromDate(), dateEnd.GetFormattedStringFromDate());
            Operation<List<FicheReportLineViewLC>> operation = client.Get<List<FicheReportLineViewLC>>(method);
            return operation;
        }
        public static Operation<List<FicheMasterView>> GetFichesByProcessId(int ProcessId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetFichesByProcessId/{0}";
            method = string.Format(method, ProcessId);
            Operation<List<FicheMasterView>> operation = client.Get<List<FicheMasterView>>(method);
            return operation;
        }
        public static Operation<List<WarehouseProcessView>> GetWarehouseProcesses(DateTime dateBegin, DateTime dateEnd)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetWarehouseProcesses/{0}/{1}";
            method = string.Format(method, dateBegin.GetFormattedStringFromDate(), dateEnd.GetFormattedStringFromDate());
            Operation<List<WarehouseProcessView>> operation = client.Get<List<WarehouseProcessView>>(method);
            return operation;
        }
        //public static Operation<List<PriceCalcType>> GetPriceCalcTypes()
        //{
        //    IServiceGate<List<PriceCalcType>> sw = GateHandler.GetServiceGate<List<PriceCalcType>>();
        //    string method = "GetPriceCalcTypes";
        //    Operation<List<PriceCalcType>> op_ = sw.Get(method);
        //    return op_;
        //}
        public static Operation<FicheMasterView> GetFicheById(int Id)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetFicheById/{0}";
            method = string.Format(method, Id);
            Operation<FicheMasterView> operation = client.Get<FicheMasterView>(method);
            return operation;
        }
        //public static Operation<List<PermissionMaster>> GetPermissionMasters()
        //{
        //    IServiceGate<List<PermissionMaster>> sw = GateHandler.GetServiceGate<List<PermissionMaster>>();
        //    string method = "GetPermissionMasters";
        //    Operation<List<PermissionMaster>> op_ = sw.Get(method);
        //    return op_;
        //}
        //public static Operation<List<PermissionDetail>> GetPermissionDetailsByUserId(int UserId)
        //{
        //    IServiceGate<List<PermissionDetail>> sw = GateHandler.GetServiceGate<List<PermissionDetail>>();
        //    string method = "GetPermissionDetailsByUserId/{0}";
        //    method = string.Format(method, UserId);
        //    Operation<List<PermissionDetail>> op_ = sw.Get(method);
        //    return op_;
        //}
        public static Operation<CashTransaction> GetCashTransactionById(int CashTransactionId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetCashTransactionById/{0}";
            method = string.Format(method, CashTransactionId);
            Operation<CashTransaction> operation = client.Get<CashTransaction>(method);
            return operation;
        }
        public static Operation<ExchangeTransaction> GetExchangeTransactionById(int CashTransactionId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetExchangeTransactionById/{0}";
            method = string.Format(method, CashTransactionId);
            Operation<ExchangeTransaction> operation = client.Get<ExchangeTransaction>(method);
            return operation;
        }
        public static Operation<CashTransaction> PostCashTransaction(CashTransaction cashTransaction)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["cashTransaction"] = cashTransaction;
            Operation<CashTransaction> operation = client.Post<CashTransaction>("PostCashTransaction", prms);
            return operation;
        }
        public static Operation<ExchangeTransaction> PostExchangeTransaction(ExchangeTransaction exchangeTransaction)
        {
            ServiceClient client = new ServiceClient();
            Dictionary<string, object> prms = new Dictionary<string, object>();
            prms["exchangeTransaction"] = exchangeTransaction;
            Operation<ExchangeTransaction> operation = client.Post<ExchangeTransaction>("PostExchangeTransaction", prms);
            return operation;
        }
        public static Operation<List<CashTransactionView>> GetCashTransactionsView(DateTime dateBegin, DateTime dateEnd, int userId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetCashTransactionsView/{0}/{1}/{2}";
            method = string.Format(method, dateBegin.GetFormattedStringFromDate(), dateEnd.GetFormattedStringFromDate(), userId);
            Operation<List<CashTransactionView>> operation = client.Get<List<CashTransactionView>>(method);
            return operation;
        }
        public static Operation<List<ExchangeTransactionView>> GetExchangeTransactionsView(DateTime dateBegin, DateTime dateEnd, int userId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetExchangeTransactionsView/{0}/{1}/{2}";
            method = string.Format(method, dateBegin.GetFormattedStringFromDate(), dateEnd.GetFormattedStringFromDate(), userId);
            Operation<List<ExchangeTransactionView>> operation = client.Get<List<ExchangeTransactionView>>(method);
            return operation;
        }
        //public static Operation<List<CardTransactionView>> GetCardTransactionViewByCardId(int cardId, DateTime dateBegin, DateTime dateEnd)
        //{
        //    IServiceGate<List<CardTransactionView>> sw = GateHandler.GetServiceGate<List<CardTransactionView>>();
        //    string method = "GetCardTransactionViewByCardId/{0}/{1}/{2}";
        //    method = string.Format(method,cardId, dateBegin.GetFormattedStringFromDate(), dateEnd.GetFormattedStringFromDate());
        //    Operation<List<CardTransactionView>> op_ = sw.Get(method);
        //    return op_;
        //}
        public static Operation<List<CardTotalByIntervalView>> GetCardTotalsByInterval(int userId, DateTime dateBegin, DateTime dateEnd)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetCardTotalsByInterval/{0}/{1}/{2}";
            method = string.Format(method, userId, dateBegin.GetFormattedStringFromDate(), dateEnd.GetFormattedStringFromDate());
            Operation<List<CardTotalByIntervalView>> operation = client.Get<List<CardTotalByIntervalView>>(method);
            return operation;
        }

        //public static Operation<List<UserDataPermissionView>> GetUserDataPermissionView(int userId)
        //{
        //    IServiceGate<List<UserDataPermissionView>> sw = GateHandler.GetServiceGate<List<UserDataPermissionView>>();
        //    string method = "GetUserDataPermissionView/{0}";
        //    method = string.Format(method, userId);
        //    Operation<List<UserDataPermissionView>> op_ = sw.Get(method);
        //    return op_;
        //}

        //public static Operation<DataPermission> PostDataPermission(DataPermission dataPermission)
        //{
        //    IServiceGate<DataPermission> sw = GateHandler.GetServiceGate<DataPermission>();
        //    Dictionary<string, object> prms = new Dictionary<string, object>();
        //    prms["dataPermission"] = dataPermission;
        //    Operation<DataPermission> op_item = sw.Post("PostDataPermission", prms);
        //    return op_item;
        //}

        //public static Operation<int> DeleteDataPermission(int dataPermissionId)
        //{
        //    IServiceGate<int> sw = GateHandler.GetServiceGate<int>();
        //    Dictionary<string, object> prms = new Dictionary<string, object>();
        //    prms["dataPermissionId"] = dataPermissionId;
        //    Operation<int> op_item = sw.Post("DeleteDataPermission", prms);
        //    return op_item;
        //}

        //public static Operation<FicheMasterView> ChangeFicheStatus(int Id,byte StatusId)
        //{
        //    IServiceGate<FicheMasterView> sw = GateHandler.GetServiceGate<FicheMasterView>();
        //    string method = "ChangeFicheStatus/{0}/{1}";
        //    method = string.Format(method, Id, StatusId);
        //    Operation<FicheMasterView> op_ = sw.Get(method);
        //    return op_;
        //}

        //public static Operation<List<CardType>> GetCardTypes()
        //{
        //    IServiceGate<List<CardType>> sw = GateHandler.GetServiceGate<List<CardType>>();
        //    string method = "GetCardTypes";
        //    Operation<List<CardType>> op_ = sw.Get(method);
        //    return op_;
        //}

        //public static Operation<List<ItemViewAcc>> GetItemTotalsByInterval(int userId, DateTime dateBegin, DateTime dateEnd)
        //{
        //    IServiceGate<List<ItemViewAcc>> sw = GateHandler.GetServiceGate<List<ItemViewAcc>>();
        //    string method = "GetItemTotalsByInterval/{0}/{1}/{2}";
        //    method = string.Format(method, userId, dateBegin.GetFormattedStringFromDate(), dateEnd.GetFormattedStringFromDate());
        //    Operation<List<ItemViewAcc>> op_ = sw.Get(method);
        //    return op_;
        //}

        public static Operation<List<CashTransactionView>> GetCashTransactionsViewByFiche(int FicheId)
        {
            ServiceClient client = new ServiceClient();
            string method = "GetCashTransactionsViewByFiche/{0}";
            method = string.Format(method, FicheId);
            Operation<List<CashTransactionView>> op_ = client.Get<List<CashTransactionView>>(method);
            return op_;
        }
    }
}
