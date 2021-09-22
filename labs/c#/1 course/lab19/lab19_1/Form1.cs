using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab19_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] number;
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(fileDialog.FileName))
                {
                    number = new int[Convert.ToInt32(reader.ReadLine())];
                    string[] s = reader.ReadLine().Split(' ');

                    for (int i = 0; i < number.Length; i++)
                    {
                        number[i] = Int32.Parse(s[i]) < 0 ? 0 : Int32.Parse(s[i]);
                    }
                }
                using (StreamWriter writer = new StreamWriter(fileDialog.FileName))
                {
                    string[] s = { "1", "2" };
                    writer.WriteLine(number.Length);
                    writer.WriteLine(string.Join(" ",number));
                }
            }
        }
    }
}
