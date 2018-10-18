using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LecERP
{
    public static class UIFunctions
    {
        public static bool AssignDictionary(LookUpEdit lookUpEdit, Dictionary<int, string> data)
        {
            lookUpEdit.Properties.DataSource = data;
            lookUpEdit.Properties.ValueMember = "Key";
            lookUpEdit.Properties.DisplayMember = "Value";
            return true;
        }

        public static bool CheckCancellation()
        {
            return (XtraMessageBox.Show("İmtina etmək istədiyinizdən əminsinizmi? Dəyişiklikləriniz ləğv olunacaqdır.", "İmtina etmək", MessageBoxButtons.YesNo) == DialogResult.Yes);
        }
        #region WindowsAPI
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public static void ReleaseCaptureSendMessage(IntPtr hWnd)
        {
            ReleaseCapture();
            SendMessage(hWnd, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        #endregion
    }
}
