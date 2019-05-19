using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;

namespace LecERP.PrintDesign
{
    public static class DocumentPrintHandler
    {
        public static void PrintSaleInvoice(int Id)
        {
            //Operation<FicheMasterView> op_Fiche = OperationHandler.GetFicheById(Id);
            //FicheMasterView fiche = op_Fiche.Value;
            //SaleInvoiceDesign saleInvoice = new SaleInvoiceDesign();
            //List<FicheLine> lines = new List<FicheLine>();

            ////lines.AddRange(fiche.FicheLines);
            //foreach (var line in fiche.FicheLines)
            //{
            //    lines.Add(line);
            //    foreach (var srvLine in line.Services)
            //    {
            //        FicheLineView ln = new FicheLineView();
            //        ln.LineNumber = line.LineNumber;
            //        ln.ItemName = srvLine.ItemName;
            //        ln.Height_ = line.Height_;
            //        ln.Width_ = line.Width_;
            //        ln.Length_ = line.Length_;
            //        ln.Amount = srvLine.Amount;
            //        ln.LinePrice = srvLine.LinePrice;
            //        ln.LineNetTotal = srvLine.LineNetTotal;
            //        lines.Add(ln);
            //    }
            //}

            //saleInvoice.DataSource = lines;
            //saleInvoice.prmCompanyName.Value = AppSettings.CompanyName;
            //saleInvoice.prmCustomer.Value = fiche.CardNumber + " - " + fiche.CardName;
            //saleInvoice.prmInvoiceDate.Value = fiche.CreatedDate.ToString("dd.MM.yyyy");
            //saleInvoice.prmFicheno.Value = fiche.Ficheno;
            //saleInvoice.prmInvoiceNetTotal.Value = fiche.Total;
            //saleInvoice.ShowPreview();
        }
    }
}
