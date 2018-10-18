using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    class XtraEditorsLocalizer : DevExpress.XtraEditors.Controls.Localizer
    {
        public override string GetLocalizedString(DevExpress.XtraEditors.Controls.StringId id)
        {
            switch (id)
            {
                case DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxYesButtonText:

                    return "Bəli";
                case DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxNoButtonText:

                    return "Xeyr";
                case DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxOkButtonText:

                    return "Oldu";
                case DevExpress.XtraEditors.Controls.StringId.XtraMessageBoxCancelButtonText:

                    return "Imtina et";
                case DevExpress.XtraEditors.Controls.StringId.TextEditMenuCopy:

                    return "Kopyala";
                case DevExpress.XtraEditors.Controls.StringId.TextEditMenuCut:

                    return "Kəs";
                case DevExpress.XtraEditors.Controls.StringId.TextEditMenuDelete:

                    return "Sil";
                case DevExpress.XtraEditors.Controls.StringId.TextEditMenuPaste:

                    return "Yapışdır";
                case DevExpress.XtraEditors.Controls.StringId.TextEditMenuSelectAll:

                    return "Hamısını seç";
                case DevExpress.XtraEditors.Controls.StringId.TextEditMenuUndo:

                    return "Qaytar";
                case DevExpress.XtraEditors.Controls.StringId.DateEditClear:

                    return "Təmizlə";
                case DevExpress.XtraEditors.Controls.StringId.DateEditToday:

                    return "Bu gün";
                case DevExpress.XtraEditors.Controls.StringId.Apply:

                    return "Tətbiq et";
                case DevExpress.XtraEditors.Controls.StringId.Cancel:

                    return "Imtina et";
                case DevExpress.XtraEditors.Controls.StringId.OK:

                    return "Oldu";

            }
            return base.GetLocalizedString(id);
        }
    }
}
