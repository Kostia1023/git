using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;




namespace JsonFirsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testCreate();
        }

        private async void testCreate()
        {


            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = File.CreateText(dialog.FileName))
                    {

                        var option = new JsonSerializerOptions
                        {
                            WriteIndented = true
                        };
                        Person p = new Person() { Age = 10, Name = "trip" };  
                        Person p2 = new Person() { Age = 25, Name = "trip2" };  
                        Tk trel = new Tk() { a = 1, b = 2.4, c = true };
                        Person[] list = { p, p2 };
                        Tk[] list2 = { trel };
                        Obj tr = new Obj() { V1 = list, V2 = list2 }; 
                        string json = JsonSerializer.Serialize<Obj>(tr, option);
                        //await JsonSerializer.SerializeAsync<Tk>(fs,trel,option);
                        label1.Text = json;
                        await writer.WriteAsync(json);
                    }
                }
            }
        }

        //private async void testCreate()
        //{
        //    using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
        //    {
        //        Person tom = new Person() { Name = "Tom", Age = 35 };
        //        await JsonSerializer.SerializeAsync<Person>(fs, tom);
        //        Console.WriteLine("Data has been saved to file");
        //    }
        //}

        private async void testRead()
        {

            using (FileStream fs = new FileStream("../../../testfile.json", FileMode.OpenOrCreate))
            {
                Tk trel = await JsonSerializer.DeserializeAsync<Tk>(fs);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            testRead();
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
