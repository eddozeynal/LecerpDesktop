using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;


namespace LecERP.UnitTests
{
    [TestClass]
    public class UnitTestMain
    {
        [TestMethod]
        public void TestBindTool_1()
        {
            DataObjectBindTool<Person> dataObjectBind = new DataObjectBindTool<Person>();
            Person p1 = new Person() { name = "eldar", age = 30 };
            dataObjectBind.DataObject = p1;
            TextBox textBox = new TextBox();
            dataObjectBind.BindControl(textBox, "name");
            textBox.Text = "salam";
            Assert.AreEqual(dataObjectBind.DataObject.name, "salam");
        }
    }

    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
    }
}
