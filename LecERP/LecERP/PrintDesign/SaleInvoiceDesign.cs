using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace LecERP.PrintDesign
{
    public partial class SaleInvoiceDesign : DevExpress.XtraReports.UI.XtraReport
    {
        public bool ShowPrices { get; set; } = true;
        public SaleInvoiceDesign()
        {
            InitializeComponent();
        }

        private void SaleInvoiceDesign_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xCellPrice.Visible = ShowPrices;
            xCellTotal.Visible = ShowPrices;
            xLabelTotalSum.Visible = ShowPrices;
            xLabelTotalWord.Visible = ShowPrices;
        }
    }
}
