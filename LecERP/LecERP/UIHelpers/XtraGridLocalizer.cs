using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    class XtraGridLocalizer : DevExpress.XtraGrid.Localization.GridLocalizer
    {
        public override string GetLocalizedString(DevExpress.XtraGrid.Localization.GridStringId id)
        {
            switch (id)
            {
                case DevExpress.XtraGrid.Localization.GridStringId.FindControlFindButton:

                    return "Axtar";
                case DevExpress.XtraGrid.Localization.GridStringId.FindControlClearButton:

                    return "Təmizlə";
                case DevExpress.XtraGrid.Localization.GridStringId.FindNullPrompt:

                    return "Axtarış etmək üçün buraya yazın";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnSortAscending:

                    return "Düzülüş A-Z";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnSortDescending:

                    return "Düzülüş Z-A";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnGroup:

                    return "Bu sütuna görə qruplaşdır";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuGroupPanelShow:

                    return "Qrup panelini göstər";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuGroupPanelHide:

                    return "Qrup panelini gizlət";
                case DevExpress.XtraGrid.Localization.GridStringId.GridGroupPanelText:

                    return "Sütunlara görə qruplaşdırmaq üçün buraya əlavə edin";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnRemoveColumn:

                    return "Bu sütunu gizlət";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnColumnCustomization:

                    return "Sütunların siyahısı";

                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnBestFit:

                    return "Avtomatik en";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnBestFitAllColumns:

                    return "Avtomatik en (hamısı)";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnFilterEditor:

                    return "Filter tənzimləyici";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnFindFilterHide:

                    return "Axtarış panelini gizlət";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnFindFilterShow:

                    return "Axtarış panelini göstər";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnAutoFilterRowHide:

                    return "Başlıq filterini gizlət";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnAutoFilterRowShow:

                    return "Başlıq filterini göstər";
                case DevExpress.XtraGrid.Localization.GridStringId.CustomizationCaption:

                    return "Sütunların siyahısı";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnClearAllSorting:

                    return "Düzülüşü ləğv et (hamısını)";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnClearSorting:

                    return "Düzülüşü ləğv et";
                case DevExpress.XtraGrid.Localization.GridStringId.FilterPanelCustomizeButton:

                    return "Filter tənzimləyici";
                case DevExpress.XtraGrid.Localization.GridStringId.FilterBuilderApplyButton:

                    return "Tətbiq et";
                case DevExpress.XtraGrid.Localization.GridStringId.FilterBuilderCancelButton:

                    return "Imtina et";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuGroupPanelFullCollapse:

                    return "Hamısını yığ";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuGroupPanelFullExpand:

                    return "Hamısını aç";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuColumnUnGroup:

                    return "Qruplaşdırmanı ləğv et";
                case DevExpress.XtraGrid.Localization.GridStringId.MenuGroupPanelClearGrouping:

                    return "Qruplaşdırmanı ləğv et (hamısını)";
                
            }
            return base.GetLocalizedString(id);
        }
    }
}
