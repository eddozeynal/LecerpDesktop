using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LecERP.Models;

namespace LecERP
{
    public partial class Manp_WarehouseProcess : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        List<FicheMasterView> Fiches = new List<FicheMasterView>();
        WarehouseProcessView processView = new WarehouseProcessView();
        public Manp_WarehouseProcess()
        {
            InitializeComponent();
        }

        private void Manp_WarehouseProcess_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            lblError.Text = "";
            dateBegin.DateTime = DateTime.Today;
            dateEnd.DateTime = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        void OnLoadError(string Message)
        {
            
            btnOk.Enabled = false;
            if (Message == null) Message = "Unknown Error";
            lblError.Text = "Error : " + Message;
        }

        private void Manp_WarehouseProcess_Shown(object sender, EventArgs e)
        {
            if (Id != 0) btnOk.Enabled = false;
            Fiches = OperationHandler.GetFichesByProcessId(Id).Value;
            gcFichesOfProc.DataSource = Fiches;           
        }

        private void pnlExecution_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(this.Handle);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (UIFunctions.CheckCancellation()) Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            processView.CreatedDate = DateTime.Now;
            processView.CreatedBy = StaticData.CurrentUserId;
            processView.Fiches = new List<WarehouseProcessFiche>();
            foreach (var f in Fiches)
            {
                processView.Fiches.Add(new WarehouseProcessFiche { FicheId = f.Id });
            }


            Operation<WarehouseProcessView> operation = OperationHandler.PostWarehouseProcess(processView);
            if (operation.Successful) this.Close();
            lblError.Text = operation.Fail;
        }


        private void lblError_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(this.Handle);
        }

        private void lookUpItemType_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gcData.DataSource = OperationHandler.GetFiches(1, dateBegin.DateTime, dateEnd.DateTime).Value.Where(x=>x.ProcessId == 0);
        }

        private void gcData_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 107 || e.KeyValue == 187)
            {
                if (!(gvData.GetFocusedRow() is FicheMasterView row)) return;
                if (!Fiches.Select(x=>x.Id).Contains(row.Id))
                    Fiches.Add(row);
                gcFichesOfProc.RefreshDataSource();
            }
        }
        //btnCreateInvoice
        void openForInvoicing()
        {
            object objCurrentId = gvFichesOfProc.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            //FicheMasterView fmv = (FicheMasterView)gvData.GetFocusedRow();
            //if (fmv.DocTypeId != 1) return;
            Manp_FichesNew manp = new Manp_FichesNew();
            manp.Id = CurrentId;
            manp.IsEditMode = true;
            manp.CreateInvoiceFromOrderFiche = true;
            manp.ShowDialog();
            //RefreshData();
        }

        private void gcFichesOfProc_DoubleClick(object sender, EventArgs e)
        {
            openForInvoicing();
        }

        private void gcFichesOfProc_Click(object sender, EventArgs e)
        {

        }
    }
}