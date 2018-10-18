using System;
using System.Runtime.Serialization;

namespace LecERP
{



    public class BaseUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name_ { get; set; }
        public string PassHash { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
    }


    public class CardMaster
    {
        public int Id { get; set; }
        public byte CardType { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public decimal DebtLimit { get; set; }
        public byte ExchangeId { get; set; }
        public string TaxCode { get; set; }
        public string LocationAddress { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string District { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }



    public class CashTransaction
    {

        public int Id { get; set; }
        public byte TransactionType { get; set; }
        public string Ficheno { get; set; }
        public int SourceCardId { get; set; }
        public int DestCardId { get; set; }
        public decimal Total { get; set; }
        public int ExchangeId { get; set; }
        public byte Status { get; set; }
        public string Note { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class DataPermission
    {
        public int Id { get; set; }
        public byte SourceType { get; set; }
        public int SourceId { get; set; }
        public byte PermissionType { get; set; }
        public int PermissionId { get; set; }
        public bool Level1 { get; set; }
        public bool Level2 { get; set; }
        public bool Level3 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class DocumentMaster
    {
        public int Id { get; set; }
        public string Name_ { get; set; }
        public byte Lenth_ { get; set; }
        public int Value_ { get; set; }
        public bool Category1 { get; set; }
        public bool Category2 { get; set; }
        public bool Category3 { get; set; }
        public bool Category4 { get; set; }
        public byte CardType { get; set; }
        public byte PriceType { get; set; }
    }


    public class EnumMaster
    {
        public byte TypeId { get; set; }
        public string TypeDefinition { get; set; }
        public byte Key_ { get; set; }
        public string Name_ { get; set; }
        public bool AllowsUpdate { get; set; }
    }


    public class ExchangeByDate
    {
        public int Id { get; set; }
        public byte ExchangeId { get; set; }
        public DateTime Date_ { get; set; }
        public decimal ExchangeRate { get; set; }
    }


    public class ExchangeMaster
    {
        public byte Id { get; set; }
        public string Name_ { get; set; }
        public bool IsMainExchange { get; set; }
        public bool IsSecondaryExchange { get; set; }
    }


    public class FicheLine
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public byte ItemTypeId { get; set; }
        public int ItemId { get; set; }
        public int LineNumber { get; set; }
        public string Note { get; set; }
        public decimal Amount { get; set; }
        public decimal ShippedAmount { get; set; }
        public decimal Length_ { get; set; }
        public decimal Width_ { get; set; }
        public decimal Height_ { get; set; }
        public decimal Weight_ { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal LinePrice { get; set; }
        public decimal LineTotal { get; set; }
        public decimal LineNetTotal { get; set; }
    }


    public class FicheMaster
    {
        public int Id { get; set; }
        public byte DocTypeId { get; set; }
        public string Ficheno { get; set; }
        public string SourceDocument { get; set; }
        public int CardId { get; set; }
        public int SourceWarehouse { get; set; }
        public int DestinationWarehouse { get; set; }
        public byte ExchangeId { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public string Note4 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte Status_ { get; set; }
        public int SourceFicheId { get; set; }
    }


    public class GridViewColumn
    {
        public int Id { get; set; }
        public int VIewId { get; set; }
        public string FieldName { get; set; }
        public string Caption { get; set; }
        public int VisibleIndex { get; set; }
        public bool Editable { get; set; }
        public bool ReadOnly_ { get; set; }
        public int Width_ { get; set; }
        public byte FilterPopupMode { get; set; }
        public byte SummaryType { get; set; }
        public byte HorzintalAlign { get; set; }
        public bool ShowInCustomization { get; set; }
        public bool IsActive { get; set; }
        public string DisplayFormat { get; set; }
        public int PermissionId { get; set; }
    }


    public class GridViewMaster
    {
        public int Id { get; set; }
        public string Name_ { get; set; }
        public bool ShowFooter { get; set; }
        public bool ShowGroupPanel { get; set; }
        public bool ShowSearchPanel { get; set; }
    }


    public class Item
    {
        public int Id { get; set; }
        public byte ItemTypeId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Group1 { get; set; }
        public string Group2 { get; set; }
        public string Group3 { get; set; }
        public string Group4 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Length_ { get; set; }
        public decimal Width_ { get; set; }
        public decimal Height_ { get; set; }
        public decimal Weight_ { get; set; }
        public byte PriceCalcTypeId { get; set; }
        public string ShortcutKey { get; set; }
    }


    public class ItemPrice
    {
        public int Id { get; set; }
        public byte PriceTypeId { get; set; }
        public int ItemId { get; set; }
        public int CardId { get; set; }
        public decimal Price { get; set; }
        public byte ExchangeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }


    public class LoginSession
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Guid { get; set; }
    }


    public class Parameter
    {
        public string ParameterKey { get; set; }
        public string ParameterDescription { get; set; }
        public string ParameterValue { get; set; }
        public bool CanAdminChange { get; set; }
        public bool CanUserChange { get; set; }
    }


    public class PermissionDetail
    {
        public int Id { get; set; }
        public int PermissionId { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }


    public class PermissionMaster
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name_ { get; set; }
        public string KeyWord { get; set; }
        public bool IsActive { get; set; }
    }


    public class PriceCalcType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
    }



    public class VW_ItemPricesDefault
    {
        public int ItemId { get; set; }
        public string ItemTypeName { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
    }


    public class WarehouseMaster
    {
        public int Number { get; set; }
        public string Name_ { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }







}
