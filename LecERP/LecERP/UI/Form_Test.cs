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
    public partial class Form_Test : DevExpress.XtraEditors.XtraForm
    {
        public Form_Test()
        {
            InitializeComponent();
        }

        private void Form_Test_Load(object sender, EventArgs e)
        {
           // textBox1.Text = new Configuration.ConfigFileManager().ReadConfigSettings().Value["DataServiceURL"].ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var v = OperationHandler.PostTest().Value;
           
                //List<Item> lst = new List<LecERP.Item>();
                //lst.Add(new Item { ItemCode = "CODE1", ItemName = "NAME1" });
                //lst.Add(new Item { ItemCode = "CODE2", ItemName = "NAME2" });
                //gcData.DataSource = lst;
                //TestClass test = new TestClass();
                //test.Name = "Eldar";
                //ServiceWorker<TestClass> sw = new ServiceWorker<TestClass>();
                //Dictionary<string, object> prms = new Dictionary<string, object>();
                //prms["data"] = test;
                //Operation<TestClass> ope = sw.Post("PostTest2", prms);
                //Operation<List<EnumMaster>> enums = OperationHandler.GetEnums(1);
                //ServiceWorker<String> sw = new ServiceWorker<String>();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
    public class TestClass
    {
        
        public string Name { get; set; }
    }
}