using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LecERP
{
    public class DataObjectBindTool<T>
    {
        List<Control> controls = null;
        List<string> fieldNames = null;
        public void BindControl(Control control, string fieldName)
        {
            if (controls == null)
            {
                controls = new List<System.Windows.Forms.Control>();
                fieldNames = new List<string>();
            }

            controls.Add(control);
            fieldNames.Add(fieldName);
        }
        //public void BindControl(Control control, string fieldName)
        //{
        //    if (controls == null)
        //    {
        //        controls = new List<System.Windows.Forms.Control>();
        //        fieldNames = new List<string>();
        //    }

        //    controls.Add(control);
        //    fieldNames.Add(fieldName);
        //}

        public void SetDataToControlsFromObject()
        {
            if (_dataObject == null) return;
            Type mType = typeof(T);
            IList<PropertyInfo> props = new List<PropertyInfo>(mType.GetProperties());
            for (int i = 0; i < fieldNames.Count; i++)
            {
                var p = props.Where(x => x.Name == fieldNames[i]).FirstOrDefault();
                if (p != null)
                {
                    object value = p.GetValue(_dataObject);
                    if (value == null) return;
                    Control control = controls[i];
                    if (control is TextEdit) control.Text = value.ToString();
                    if (control is CheckEdit) (control as CheckEdit).Checked = Convert.ToBoolean(value);
                    if (control is LookUpEdit) (control as LookUpEdit).EditValue = value;
                    if (control is GridLookUpEdit) (control as GridLookUpEdit).EditValue = value;
                    if (control is SearchLookUpEdit) (control as SearchLookUpEdit).EditValue = value;
                    if (control is SpinEdit) (control as SpinEdit).EditValue = value;
                    if (control is DateEdit) (control as DateEdit).EditValue = value;
                    //object value = p.GetValue(_dataObject);
                    //controls[i].Text = value.ToString();
                }
            }
        }

        public void SetDataToObjectFromControls()
        {
            if (_dataObject == null) _dataObject = Activator.CreateInstance<T>();
            Type mType = typeof(T);
            IList<PropertyInfo> props = new List<PropertyInfo>(mType.GetProperties());
            for (int i = 0; i < fieldNames.Count; i++)
            {
                var p = props.Where(x => x.Name == fieldNames[i]).FirstOrDefault();
                if (p != null)
                {
                    Control control = controls[i];

                    if (control is CheckEdit) { p.SetValue(_dataObject, (control as CheckEdit).Checked); continue; }
                    if (control is LookUpEdit) { p.SetValue(_dataObject, (control as LookUpEdit).EditValue); continue; }
                    if (control is GridLookUpEdit) { p.SetValue(_dataObject, (control as GridLookUpEdit).EditValue); continue; }
                    if (control is SearchLookUpEdit) { p.SetValue(_dataObject, (control as SearchLookUpEdit).EditValue); continue; }
                    if (control is SpinEdit) { p.SetValue(_dataObject, (control as SpinEdit).EditValue); continue; }
                    if (control is DateEdit) { p.SetValue(_dataObject, (control as DateEdit).EditValue); continue; }
                    p.SetValue(_dataObject, control.Text);
                    //object value = p.GetValue(_dataObject);
                    //controls[i].Text = value.ToString();
                }
            }
            //List<object> oldKeyList = new List<object>();

            //foreach (T oldItem in initialList)
            //{
            //    object oldKeyObject = props.Where(x => x.Name == KeyFieldName).First().GetValue(oldItem, null);
            //    oldKeyList.Add(oldKeyObject);
            //}

            //foreach (T item in finalList)
            //{
            //    object keyObject = props.Where(x => x.Name == KeyFieldName).First().GetValue(item, null);
            //    if (!oldKeyList.Contains(keyObject)) list.Add(item);

            //}
        }
        private T _dataObject = default(T);
        public T DataObject
        {
            get
            {
                SetDataToObjectFromControls();
                return _dataObject;

            }
            set
            {
                _dataObject = value;
                SetDataToControlsFromObject();
            }
        }
    }
}
