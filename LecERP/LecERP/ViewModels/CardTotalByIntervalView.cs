using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LecERP.ViewModels
{
    public class CardTotalByIntervalView 
    {
        
        public int Id { get; set; }
        
        public byte CardTypeId { get; set; }
        
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
        
        public string CardTypeName { get; set; }
        
        public string ExchangeName { get; set; }
        
        public decimal RemByBegDate { get; set; }
        
        public decimal TotalInput { get; set; }
        
        public decimal TotalOutput { get; set; }
        
        public decimal RemByEndDate { get; set; }

        public decimal RemDebitByBegDate { get; set; }
        public decimal RemCreditByBegDate { get; set; }
        public decimal RemDebitByEndDate { get; set; }
        public decimal RemCreditByEndDate { get; set; }

    }
}