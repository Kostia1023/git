using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labs15_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NElArith_Click(object sender, EventArgs e)
        {
            ArithmeticProgression progres = new ArithmeticProgression(Convert.ToDouble(FirstArith.Text), Convert.ToDouble(ArithD.Text));
            Res.Text = $"{progres.ElProgression(Convert.ToInt32(ArithN.Text))}";
        }

        private void SumArith_Click(object sender, EventArgs e)
        {
            ArithmeticProgression progres = new ArithmeticProgression(Convert.ToDouble(FirstArith.Text), Convert.ToDouble(ArithD.Text));
            Res.Text = $"{progres.Sum(Convert.ToInt32(ArithN.Text))}";
        }

        private void NElGeom_Click(object sender, EventArgs e)
        {
            GeometricProgression progres = new GeometricProgression(Convert.ToDouble(FirstGoem.Text), Convert.ToDouble(GeomQ.Text));
            Res.Text = $"{progres.ElProgression(Convert.ToInt32(GeomN.Text))}";
        }

        private void SumGeom_Click(object sender, EventArgs e)
        {
            GeometricProgression progres = new GeometricProgression(Convert.ToDouble(FirstGoem.Text), Convert.ToDouble(GeomQ.Text));
            Res.Text = $"{progres.Sum(Convert.ToInt32(GeomN.Text))}";
        }
    }
}
