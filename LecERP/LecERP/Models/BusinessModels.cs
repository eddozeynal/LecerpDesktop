using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    public class CardMasterView : CardMaster
    {
        public string CardTypeName { get; set; }
        public string ExchangeName { get; set; }
        public decimal Debt { get; set; }
    }

    public class CardTotalByIntervalView : CardMaster
    {
        public string CardTypeName { get; set; }
        public string ExchangeName { get; set; }
        public decimal RemByBegDate { get; set; }
        public decimal TotalInput { get; set; }
        public decimal TotalOutput { get; set; }
        public decimal RemByEndDate { get; set; }

    }


    public class GridViewInfo
    {
        public GridViewMaster GridViewMaster_ { get; set; }
        public List<GridViewColumn> GridViewColumns_ { get; set; }
    }
    public class Fiche
    {
        public Fiche()
        {
            FicheMaster = new FicheMaster();
            FicheLines = new List<FicheLine>();
        }
        public FicheMaster FicheMaster { get; set; }
        public List<FicheLine> FicheLines { get; set; }
    }
    public class FicheView
    {
        public FicheMasterView FicheMaster { get; set; }
        public List<FicheLineView> FicheLines { get; set; }
    }
    public class FicheMasterView : FicheMaster
    {
        public string ExchangeName { get; set; }
        public decimal Total { get; set; }
        public decimal WeightTotal { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public int LineCount { get; set; }
        public bool WorksCompleted { get; set; }
        public string StatusName { get; set; }
    }
    public class ItemView : Item
    {
        public string ItemTypeName { get; set; }
    }
    public class ItemPriceForCard
    {
        public int CardId { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public decimal? Price { get; set; }
        public bool IsSpecial { get; set; }
    }
    public class ItemPriceOperation : ItemPrice
    {
        public byte OperationType { get; set; }
    }
    public class User
    {
        public BaseUser BaseUser { get; set; }
        public List<PermissionDetail> PermissionDetails { get; set; }
        public LoginSession LoginSession { get; set; }
    }

    public class FicheLineView : FicheLine
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemTypeName { get; set; }
    }
    public class PermissionMasterExt : PermissionMaster
    {
        public bool IsPermitted { get; set; }
    }

    public class CashTransactionView : CashTransaction
    {
        public string SourceCardNumber { get; set; }
        public string SourceCardName { get; set; }
        public string DestCardNumber { get; set; }
        public string DestCardName { get; set; }
        public string ExchangeName { get; set; }
        public string TransactionName { get; set; }
        public string UserName { get; set; }
        public string StatusName { get; set; }
        public int SourceCardTypeId { get; set; }
        public int DestCardTypeId { get; set; }
    }
    public class UserDataPermissionView : DataPermission
    {
        public string PermissionTypeName { get; set; }
        public string PermissionCode { get; set; }
        public string PermissionName { get; set; }
    }
}
