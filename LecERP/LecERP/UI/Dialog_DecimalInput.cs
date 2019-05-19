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
    public partial class Dialog_DecimalInput : DevExpress.XtraEditors.XtraForm
    {
        private bool Accepted;

        public Dialog_DecimalInput()
        {
            InitializeComponent();
        }

        public string Caption
        {
            get
            {
                return grpMain.Text;
            }
            set
            {
                grpMain.Text = value;
            }
        }

        public decimal Value
        {
            get
            {
                return spnValue.Value; ;
            }
            set
            {
                spnValue.Value = value;
            }
        }

        public bool IsOk { get { return Accepted; } }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Accepted = true;
            Close();
        }

        private void Dialog_DecimalInput_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}