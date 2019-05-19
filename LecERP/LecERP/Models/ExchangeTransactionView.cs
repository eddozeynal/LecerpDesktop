using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP.Models
{
    public class ExchangeTransactionView
    {
       
        public int Id { get; set; }

       
        public string Ficheno { get; set; }

       
        public int SourceCardId { get; set; }

       
        public int DestCardId { get; set; }

       
        public decimal Total { get; set; }

       
        public decimal CurrencyRate { get; set; }

       
        public string Note { get; set; }

       
        public int CreatedBy { get; set; }

       
        public DateTime CreatedDate { get; set; }

       
        public bool SourceCardByPermission { get; set; }

       
        public string SourceCardNumber { get; set; }

       
        public string SourceCardName { get; set; }

       
        public bool DestCardByPermission { get; set; }

       
        public string DestCardNumber { get; set; }

       
        public string DestCardName { get; set; }

       
        public decimal SourceTotal { get; set; }

       
        public decimal DestTotal { get; set; }

        public string UserName { get; set; }

    }
}
