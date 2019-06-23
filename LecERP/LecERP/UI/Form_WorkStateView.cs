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
    public partial class Form_WorkStateView : DevExpress.XtraEditors.XtraForm
    {
        public Form_WorkStateView()
        {
            InitializeComponent();
        }

        private void Form_WorkStateView_Load(object sender, EventArgs e)
        {

        }

        private void Form_WorkStateView_Shown(object sender, EventArgs e)
        {
            treeListWorkStateView.DataSource = OperationHandler.GetWorkStates().Value;
            treeListWorkStateView.KeyFieldName = "Id";
            treeListWorkStateView.ParentFieldName = "ParentId";
        }
    }
}