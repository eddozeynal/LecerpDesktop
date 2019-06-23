using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using LecERP.Models;
using LecERP.ViewModels;

namespace LecERP.Printing
{
    public static class DocumentPrintHandler
    {
        public static void PrintSaleInvoice(int Id)
        {
            Operation<FicheMasterView> op_Fiche = OperationHandler.GetFicheById(Id);
            FicheMasterView fiche = op_Fiche.Value;
            SaleInvoiceDesign saleInvoice = new SaleInvoiceDesign();
            List<FicheLineView> lines = new List<FicheLineView>();

            //lines.AddRange(fiche.FicheLines);
            foreach (var line in fiche.Lines)
            {
                lines.Add(line);
                foreach (var srvLine in line.LineServices)
                {
                    FicheLineView ln = new FicheLineView();
                    ln.LineNumber = line.LineNumber;
                    ln.ItemName = srvLine.ItemName;
                    ln.Width = line.Width;
                    ln.Length = line.Length;
                    ln.Quantity = srvLine.Quantity;
                    ln.LinePrice = srvLine.LinePrice;
                    ln.LineNetTotal = srvLine.LineTotal;
                    lines.Add(ln);
                }
            }

            saleInvoice.DataSource = lines;
            saleInvoice.prmCompanyName.Value = AppSettings.CompanyName;
            saleInvoice.prmCustomer.Value = fiche.CardNumber + " - " + fiche.CardName;
            saleInvoice.prmInvoiceDate.Value = fiche.CreatedDate.ToString("dd.MM.yyyy");
            saleInvoice.prmFicheno.Value = fiche.Ficheno;
            saleInvoice.prmInvoiceNetTotal.Value = fiche.FicheNetTotal;
            saleInvoice.ShowPreview();
        }
    }
}
