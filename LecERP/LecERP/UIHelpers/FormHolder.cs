using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LecERP
{
    public static class FormHolder
    {

        static Dictionary<Type, Form> formList = new Dictionary<Type, Form>();
        public static Form MdiParent { get; set; }

        public static void Populate(Type _type, string Caption)
        {
            if (formList.ContainsKey(_type))
            {
                if (formList[_type] == null || formList[_type].IsDisposed)
                {
                    formList[_type] = (Form)Activator.CreateInstance(_type);
                }
            }
            else
            {
                formList.Add(_type, (Form)Activator.CreateInstance(_type));
            }
            formList[_type].MdiParent = MdiParent;
            formList[_type].Text = Caption;
            formList[_type].Show();
            formList[_type].BringToFront();

        }


    }
}
