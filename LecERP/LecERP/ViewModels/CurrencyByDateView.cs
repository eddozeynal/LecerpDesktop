using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP.ViewModels
{
    public class CurrencyByDateView
    {
        public int Id { get; set; }
        public byte CurrencyId { get; set; }
        public DateTime Date { get; set; }
        public decimal Rate { get; set; }
        public string CurrencyName { get; set; }
    }
}
