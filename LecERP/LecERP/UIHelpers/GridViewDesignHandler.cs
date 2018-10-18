using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP
{
    class GridViewDesignHandler
    {
        public DevExpress.XtraGrid.Views.Grid.GridView GridView { get; set; }
        public GridViewInfo GridViewInfo { get; set; }

        public Operation<bool> SetView()
        {
            Operation<bool> op_Ret = new Operation<bool>();
            try
            {
                GridView.OptionsView.ShowFooter = GridViewInfo.GridViewMaster_.ShowFooter;
                GridView.OptionsView.ShowGroupPanel = GridViewInfo.GridViewMaster_.ShowGroupPanel;

                foreach (GridViewColumn gcol in GridViewInfo.GridViewColumns_.Where(x => x.IsActive).OrderBy(x=>x.VisibleIndex))
                {
                    DevExpress.XtraGrid.Columns.GridColumn col =
                        GridView.Columns.Where(x => x.FieldName == gcol.FieldName).FirstOrDefault();
                    if (col == null)
                    {
                        col = new DevExpress.XtraGrid.Columns.GridColumn();
                        col.FieldName = gcol.FieldName;
                        GridView.Columns.Add(col);
                    }
                    col.Caption = gcol.Caption;
                    col.VisibleIndex = gcol.VisibleIndex;
                    col.OptionsColumn.AllowEdit = gcol.Editable;
                    col.OptionsColumn.ReadOnly = gcol.ReadOnly_;
                    col.Width = gcol.Width_;
                    col.OptionsFilter.FilterPopupMode = (DevExpress.XtraGrid.Columns.FilterPopupMode)gcol.FilterPopupMode;
                    col.SummaryItem.SummaryType = (DevExpress.Data.SummaryItemType)gcol.SummaryType;
                    col.AppearanceCell.TextOptions.HAlignment = (DevExpress.Utils.HorzAlignment)gcol.HorzintalAlign;
                    // col.OptionsColumn.ShowInCustomizationForm = gcol.ShowInCustomization;
                    //
                    col.DisplayFormat.FormatString = gcol.DisplayFormat;
                    if (col.DisplayFormat.FormatString.Length >0 ) col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                    col.SummaryItem.DisplayFormat = "";
                    col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

                }
                // GridView.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode. = GridViewInfo.GridViewMaster_.ShowFooter;

            }
            catch (Exception ex)
            {
                if (GridView != null) GridView.Dispose();
                op_Ret.Fail = ex.Message;
            }

            return op_Ret;
        }
    }
}
