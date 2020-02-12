using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP.Models
{
    public class FicheExpence
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public int CardFicheLineId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
