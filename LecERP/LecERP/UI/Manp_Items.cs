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
    public partial class Manp_Items : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        Item Item = null;
        DataObjectBindTool<Item> bindTool = new DataObjectBindTool<Item>();
        public Manp_Items()
        {
            InitializeComponent();
        }

        private void Manp_Items_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            lblError.Text = "";
        }

        void OnLoadError(string Message)
        {
            grpCenter.Enabled = false;
            btnOk.Enabled = false;
            if (Message == null) Message = "Unknown Error";
            lblError.Text = "Error : " + Message;
        }

        private void Manp_Items_Shown(object sender, EventArgs e)
        {
            DataHolder dataHolder = new DataHolder();
            IBaseOperation loadOperation = dataHolder.LoadEnumData();
            if (!loadOperation.Successful)
            {
                OnLoadError(loadOperation.Fail);
                return;
            }
            lookUpItemType.Properties.DataSource = dataHolder.ItemTypes;
            lookupPriceCalcType.Properties.DataSource = dataHolder.LineCalcTypes;
            
            if (Id == 0)
            {
                Item = new Item();
            }
            else
            {
                // GET DATA
                Operation<Item> op_item = OperationHandler.GetItemById(Id);
                if (!op_item.Successful)
                {
                    OnLoadError(op_item.Fail);
                    return;
                }
                Item = op_item.Value;
                lookUpItemType.Enabled = false;
            }
            bindTool.BindControl(txtGroup1, nameof(Item.Group1));
            bindTool.BindControl(txtGroup2, nameof(Item.Group2));
            bindTool.BindControl(txtGroup3, nameof(Item.Group3));
            bindTool.BindControl(txtGroup4, nameof(Item.Group4));
            bindTool.BindControl(txtItemCode, nameof(Item.ItemCode));
            bindTool.BindControl(txtItemName, nameof(Item.ItemName));
            bindTool.BindControl(lookUpItemType, nameof(Item.ItemTypeId));
            bindTool.BindControl(lookupPriceCalcType, nameof(Item.LineCalcTypeId));
            bindTool.BindControl(spLength, nameof(Item.Length));
            bindTool.BindControl(spWidth, nameof(Item.Width));
            bindTool.BindControl(chkIsLineService, nameof(Item.IsLineService));
            bindTool.DataObject = Item;

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
            Item = bindTool.DataObject;
            if (Id == 0)
            {
                Item.CreatedDate = DateTime.Now;
                Item.CreatedBy = StaticData.CurrentUserId;
            }
            Operation<Item> operation = OperationHandler.PostItem(Item);
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
    }
}