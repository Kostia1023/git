using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testRead();
        }
        private async void testRead()
        {

            using (FileStream fs = new FileStream("../../../testfile.json", FileMode.OpenOrCreate))
            {
                Obj list = await JsonSerializer.DeserializeAsync<Obj>(fs);
                Person pers = list.V1[1];
                Tk trel = list.V2[0];
                //label1.Text = list.vs[0];
                label1.Text = Convert.ToString(trel.a);
                label2.Text = Convert.ToString(trel.c);
                label3.Text = Convert.ToString(pers.Name);
                label4.Text = Convert.ToString(trel.b);

            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Tk
    {
        public int a { get; set; }
        public double b { get; set; }
        public bool c { get; set; }
    }
    class Obj
    {
        public Person[] V1 { get; set; }
        public Tk[] V2 { get; set; }
    }
}
