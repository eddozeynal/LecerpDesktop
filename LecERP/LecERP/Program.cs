using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace LecERP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Export.ExportSettings.DefaultExportType = DevExpress.Export.ExportType.WYSIWYG;
            DevExpress.XtraEditors.Controls.Localizer.Active = new XtraEditorsLocalizer();
            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new XtraGridLocalizer();
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
          //  UserLookAndFeel.Default.SetSkinStyle("DevExpress Dark Style");
            Application.Run(new Form_Main());
        }
    }
}
