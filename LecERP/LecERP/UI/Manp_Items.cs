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
    public partial class Manp_Items : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        Item Item = null;
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
            Operation<List<EnumMaster>> op_ItemTypes = OperationHandler.GetEnums(3);
            if (!op_ItemTypes.Successful)
            {
                OnLoadError(op_ItemTypes.Fail);
                return;
            }
            lookUpItemType.Properties.DataSource = op_ItemTypes.Value;

            Operation<List<PriceCalcType>> op_PriceCalcTypes = OperationHandler.GetPriceCalcTypes();
            if (!op_PriceCalcTypes.Successful)
            {
                OnLoadError(op_PriceCalcTypes.Fail);
                return;
            }
            lookUpItemType.Properties.DataSource = op_ItemTypes.Value;
            lookupPriceCalcType.Properties.DataSource = op_PriceCalcTypes.Value;
            if (Id == 0)
            {
                Item = new Item();
            }
            else
            {
                // GET DATA
                Operation<Item> op_item = OperationHandler.GetItem(Id);
                if (!op_item.Successful)
                {
                    OnLoadError(op_item.Fail);
                    return;
                }
                Item = op_item.Value;
                txtGroup1.Text = Item.Group1;
                txtGroup2.Text = Item.Group2;
                txtGroup3.Text = Item.Group3;
                txtGroup4.Text = Item.Group4;
                txtItemCode.Text = Item.ItemCode;
                txtItemName.Text = Item.ItemName;
                lookUpItemType.EditValue = Item.ItemTypeId;
                lookUpItemType.Enabled = false;
                lookupPriceCalcType.EditValue = Item.PriceCalcTypeId;
                cmbShortcutKey.Text = Item.ShortcutKey;
            }

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
            if (Id == 0)
            {
                Item.CreatedDate = DateTime.Now;
                Item.CreatedBy = StaticData.CurrentUserId;
            }
            Item.Group1 = txtGroup1.Text;
            Item.Group2 = txtGroup2.Text;
            Item.Group3 = txtGroup3.Text;
            Item.Group4 = txtGroup4.Text;
            Item.ItemCode = txtItemCode.Text;
            Item.ItemName = txtItemName.Text;
            Item.ItemTypeId = Convert.ToByte(lookUpItemType.EditValue);
            Item.Height_ = spHeight.Value;
            Item.Length_ = spLength.Value;
            Item.Weight_ = spWeight.Value;
            Item.Width_ = spWidth.Value;
            Item.PriceCalcTypeId = Convert.ToByte(lookupPriceCalcType.EditValue);
            Item.ShortcutKey = cmbShortcutKey.Text ?? string.Empty;
            Operation<Item> operation = OperationHandler.PostItem(Item);
            if (operation.Successful) this.Close();
            lblError.Text = operation.Fail;
        }


        private void lblError_MouseDown(object sender, MouseEventArgs e)
        {
            UIFunctions.ReleaseCaptureSendMessage(this.Handle);
        }
    }
}