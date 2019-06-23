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
    public partial class Manp_WarehouseProcessDetail : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        public Manp_WarehouseProcessDetail()
        {
            InitializeComponent();
        }

        private void Manp_WarehouseProcessDetail_Load(object sender, EventArgs e)
        {

        }

        private void Manp_WarehouseProcessDetail_Shown(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            gcLines.DataSource = OperationHandler.GetWarehouseProcessDetails(Id).Value;
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
            //Item = bindTool.DataObject;
            //if (Id == 0)
            //{
            //    Item.CreatedDate = DateTime.Now;
            //    Item.CreatedBy = StaticData.CurrentUserId;
            //}
            //Operation<Item> operation = OperationHandler.PostItem(Item);
            //if (operation.Successful) this.Close();
            //lblError.Text = operation.Fail;
        }


        private void lblError_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(this.Handle);
        }

        private void Manp_WarehouseProcessDetail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (gvLines.GetFocusedRow() is WarehouseProcessDetailView detailView)
                {
                    OperationHandler.CompleteWarehouseProcessDetail(detailView.Id);
                    RefreshData();
                }
            }
        }
    }
}