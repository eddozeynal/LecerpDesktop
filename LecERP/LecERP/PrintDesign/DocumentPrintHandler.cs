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
            Operation<FicheView> op_Fiche = OperationHandler.GetFicheViewById(Id);
            FicheView fiche = op_Fiche.Value;
            SaleInvoiceDesign saleInvoice = new SaleInvoiceDesign();
            saleInvoice.DataSource = fiche.FicheLines;
            saleInvoice.prmCompanyName.Value = AppSettings.CompanyName;
            saleInvoice.prmCustomer.Value = fiche.FicheMaster.CardNumber + " - " + fiche.FicheMaster.CardName;
            saleInvoice.prmInvoiceDate.Value = fiche.FicheMaster.CreatedDate.ToString("dd.MM.yyyy");
            saleInvoice.prmFicheno.Value = fiche.FicheMaster.Ficheno;
            saleInvoice.prmInvoiceNetTotal.Value = fiche.FicheMaster.Total;
            saleInvoice.ShowPreview();
        }
    }
}
