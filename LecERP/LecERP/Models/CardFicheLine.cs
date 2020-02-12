using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP.Models
{
    public class CardFicheLine
    {
        public int Id { get; set; }
        public int CardFicheId { get; set; }
        public int CardId { get; set; }
        public decimal Total { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrencyRate { get; set; }
        public decimal SignType { get; set; }
    }
}
