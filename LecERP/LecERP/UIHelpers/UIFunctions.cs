using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public static void AssignGridView(this DevExpress.XtraGrid.Views.Grid.GridView GridView, int ViewId)
        {
            GridViewDesignHandler gvh = new GridViewDesignHandler();
            gvh.GridView = GridView;
            gvh.GridViewInfo = OperationHandler.GetGridViewInfo(ViewId);
            gvh.SetView();
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            MaskedTextBox textBox = new MaskedTextBox();
            textBox.Text = value;
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "Qəbul";
            buttonCancel.Text = "İmtina";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static void ExportExcell(this GridView gv)
        {
            try
            {
                string filename = string.Empty;
                string value = string.Empty;
                if (InputBox("Fayl", "Faylın adını daxil edin:", ref value) == DialogResult.OK)
                {
                    filename = value;
                }
                else return;
                if (filename.Trim().Length == 0) return;
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Qovluq seçin";

                if (fbd.ShowDialog() == DialogResult.OK)
                {

                    if (fbd.SelectedPath != string.Empty)
                    {
                        filename = fbd.SelectedPath + "\\" + filename + ".xlsx";

                        if (!File.Exists(filename))
                        {
                            if (gv != null)
                            {
                                gv.ExportToXlsx(filename);
                            }

                            DialogResult dr = XtraMessageBox.Show("Faylı indi açmaq istəyirsinizmi?", "",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                if (File.Exists(filename))
                                    System.Diagnostics.Process.Start(filename);
                            }
                            else
                                dr = DialogResult.No;
                        }
                        else
                            XtraMessageBox.Show("Fayl seçdiyiniz qovluqda mövcuddur");

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        public static void ExportExcell( this PivotGridControl pivot)
        {
            try
            {
                string filename = string.Empty;
                string value = string.Empty;
                if (InputBox("Fayl", "Faylın adını daxil edin:", ref value) == DialogResult.OK)
                {
                    filename = value;
                }
                else return;
                if (filename.Trim().Length == 0) return;
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Qovluq seçin";

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    //SetFileNameFrm sfnfrm = new SetFileNameFrm();
                    //sfnfrm.ShowDialog();

                    if (fbd.SelectedPath != string.Empty)
                    {
                        filename = fbd.SelectedPath + "\\" + filename + ".xlsx";

                        if (!File.Exists(filename))
                        {
                           
                            if (pivot != null)
                            {
                                DevExpress.XtraPrinting.XlsxExportOptionsEx o = new DevExpress.XtraPrinting.XlsxExportOptionsEx();
                                o.AllowCellMerge = DevExpress.Utils.DefaultBoolean.False;
                                o.AllowGrouping = DevExpress.Utils.DefaultBoolean.False;
                                o.ApplyFormattingToEntireColumn = DevExpress.Utils.DefaultBoolean.False;
                                o.GroupState = DevExpress.Export.GroupState.Default;
                                o.RawDataMode = false;
                                pivot.ExportToXlsx(filename, o);
                            }

                            DialogResult dr = XtraMessageBox.Show("Faylı indi açmaq istəyirsinizmi?", "",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                if (File.Exists(filename))
                                    System.Diagnostics.Process.Start(filename);
                            }
                            else
                                dr = DialogResult.No;
                        }
                        else
                            XtraMessageBox.Show("Fayl seçdiyiniz qovluqda mövcuddur");

                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
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
