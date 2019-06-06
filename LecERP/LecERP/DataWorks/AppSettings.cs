using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    public static class AppSettings
    {
        public static string CompanyName { get; set; }
        public static int DBVersion { get; set; }
        public static bool FichesManpServiceLinesClearCheckedRowsOnAddLine { get; set; }
    }
}
