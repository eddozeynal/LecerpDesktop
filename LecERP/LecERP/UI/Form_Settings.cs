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
    public partial class Form_Settings : DevExpress.XtraEditors.XtraForm
    {
        public Form_Settings()
        {
            InitializeComponent();
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinContainerCollection skins = DevExpress.Skins.SkinManager.Default.Skins;
            for (int i = 0; i < skins.Count; i++)
            { cmbTheme.Properties.Items.Add(skins[i].SkinName); }
          
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(cmbTheme.Text);
        }
    }
}