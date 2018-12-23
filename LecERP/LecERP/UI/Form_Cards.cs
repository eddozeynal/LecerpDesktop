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
    public partial class Form_Cards : DevExpress.XtraEditors.XtraForm
    {
        public Form_Cards()
        {
            InitializeComponent();
        }
        private void RefreshData()
        {
            Operation<List<CardMasterView>> op_CardMaster = OperationHandler.GetAllCards();
            if (op_CardMaster.Successful)
            {
                gcData.DataSource = op_CardMaster.Value;
            }
            else
            {
                // Show Error
            }
        }



        private void Form_Cards_Shown(object sender, EventArgs e)
        {
            gvData.AssignGridView(11);
            RefreshData();
        }

        private void Form_Cards_Load(object sender, EventArgs e)
        {
            tsAddNew.Enabled = StaticData.IsPermitted(7);
            tsModify.Enabled = StaticData.IsPermitted(8);
            tsDelete.Enabled = StaticData.IsPermitted(9);
        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            new Manp_Cards().ShowDialog();
            RefreshData();
        }

        private void tsModify_Click(object sender, EventArgs e)
        {
            object objValue = gvData.GetFocusedRowCellValue("Id");
            if (objValue == null) return;
            Manp_Cards mp_cards = new Manp_Cards();
            mp_cards.Id = Convert.ToInt32(objValue);
            mp_cards.ShowDialog();
            RefreshData();
        }

        private void tsExportToExcel_Click(object sender, EventArgs e)
        {
            gvData.ExportExcell();
        }
    }
}