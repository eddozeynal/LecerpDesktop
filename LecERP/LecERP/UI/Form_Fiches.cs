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

namespace LecERP
{
    public partial class Form_Fiches : DevExpress.XtraEditors.XtraForm
    {
        public Form_Fiches()
        {
            InitializeComponent();
        }

        private void Form_Fiches_Load(object sender, EventArgs e)
        {
            dateBegin.DateTime = DateTime.Today;
            dateEnd.DateTime = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        private void Form_Fiches_Shown(object sender, EventArgs e)
        {
            GridViewDesignHandler gvh = new GridViewDesignHandler();
            gvh.GridView = gvData;
            gvh.GridViewInfo = OperationHandler.GetGridViewInfo(15);
            gvh.SetView();

            Operation<List<DocumentMaster>> op_DocumentMasters = OperationHandler.GetDocumentMasters();

            if (!op_DocumentMasters.Successful)
            {
                

            }

            lookUpFicheType.Properties.DataSource = op_DocumentMasters.Value;
            if (op_DocumentMasters.Value.Count > 0) lookUpFicheType.ItemIndex = 0;



        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            Manp_FichesNew manp = new Manp_FichesNew();
            manp.DocTypeId = Convert.ToByte(lookUpFicheType.EditValue);
            manp.IsEditMode = true;
            manp.ShowDialog();
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        void RefreshData()
        {
            Operation<List<VW_FicheMaster>> op_Fiches = OperationHandler.GetFiches(Convert.ToByte(lookUpFicheType.EditValue), dateBegin.DateTime, dateEnd.DateTime);
            gcData.DataSource = op_Fiches.Value;
        }

        private void lookUpFicheType_EditValueChanged(object sender, EventArgs e)
        {
            gcData.DataSource = null;
        }

        private void tsModify_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            Manp_FichesNew manp = new Manp_FichesNew();
            manp.Id = CurrentId;
            manp.IsEditMode = true;
            manp.ShowDialog();
            RefreshData();
        }

        private void tsView_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            Manp_FichesNew manp = new Manp_FichesNew();
            manp.Id = CurrentId;
          
            manp.ShowDialog();
            RefreshData();
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            object objCurrentId = gvData.GetFocusedRowCellValue("Id");
            if (objCurrentId == null) return;
            int CurrentId = Convert.ToInt32(objCurrentId);
            Manp_FichesNew manp = new Manp_FichesNew();
            manp.Id = CurrentId;
            manp.IsEditMode = true;
            manp.CreateInvoiceFromOrderFiche = true;
            manp.ShowDialog();
            RefreshData();
        }
    }
}