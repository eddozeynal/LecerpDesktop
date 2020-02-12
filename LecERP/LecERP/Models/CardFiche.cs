using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP.Models
{
    public class CardFiche
    {
        public int Id { get; set; }
        public byte CashTypeId { get; set; }
        public string Ficheno { get; set; }
        public byte StatusId { get; set; }
        public string Note { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<CardFicheLine> Lines { get; set; }
    }
}
