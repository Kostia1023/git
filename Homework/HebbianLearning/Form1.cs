using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HebbianLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Change(object sender, EventArgs e)
        {

            dataGridView1.ColumnCount = (int)vector.Value + 1;
            dataGridView1.RowCount = (int)sizeVector.Value;

            for (int i = 0; i < (int)vector.Value; i++)
            {
                dataGridView1.Columns[i].Name = $"X{i + 1}";
            }
            dataGridView1.Columns[(int)vector.Value].Name = "f";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[][] arr1 = new double[(int)vector.Value][];

            for (int i = 0; i < (int)vector.Value; i++)
            {
                arr1[i] = new double[(int)sizeVector.Value];
                for (int j = 0; j < (int)sizeVector.Value; j++)
                {
                    arr1[i][j] = Convert.ToDouble(dataGridView1[i, j].Value);
                }
            }

            double[] f = new double[(int)sizeVector.Value];

            for (int i = 0; i < (int)sizeVector.Value; i++)
            {
                f[i] = Convert.ToDouble(dataGridView1[(int)vector.Value, i].Value);
            }

            HebbianLearningClass hebbian = new HebbianLearningClass(arr1, f);
            double[] w = hebbian.WeightArr();

            dataGridView2.ColumnCount = (int)vector.Value + 1;
            dataGridView2.RowCount = 1;
            for (int i = 0; i < (int)vector.Value + 1; i++)
            {
                dataGridView2.Columns[i].Name = $"w{i}";
                dataGridView2[i, 0].Value = w[i];
            }
            dataGridView3.ColumnCount = 0;
            dataGridView3.RowCount = 0;
            string rule = "The hebbian rule is followed";
            int[] sgnX = hebbian.ConvertToThreshold();
            for (int i = 0; i < (int)sizeVector.Value; i++)
            {
                if (f[i] != sgnX[i])
                {
                    rule = "The hebbian rule is not followed";
                }
            }
            label3.Text = rule;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[][] BoolFunc = new double[16][];
            for (int i = 0; i < 16; i++)
            {
                BoolFunc[i] = new double[4];
                string binary = Convert.ToString(i, 2);
                for (int j = 0; j < binary.Length; j++)
                {
                    BoolFunc[i][j] = binary[binary.Length - j - 1] == '1' ? -1 : 0;
                }
            }

            dataGridView2.RowCount = 4;
            dataGridView2.ColumnCount = 16;

            dataGridView3.RowCount = 4;
            dataGridView3.ColumnCount = 16;

            for (int i = 0; i < 16; i++)
            {
                dataGridView2.Columns[i].Name = $"f{i}";
                for (int j = 0; j < 4; j++)
                {
                    BoolFunc[i][j] = BoolFunc[i][j] == -1 ? -1 : 1;
                    dataGridView2[i, j].Value = BoolFunc[i][j];
                }
            }

            double[][] arr1 = new double[(int)vector.Value][];

            for (int i = 0; i < (int)vector.Value; i++)
            {
                arr1[i] = new double[(int)sizeVector.Value];
                for (int j = 0; j < (int)sizeVector.Value; j++)
                {
                    arr1[i][j] = Convert.ToDouble(dataGridView1[i, j].Value);
                }
            }


            double[][] w = new double[16][];
            for (int i = 0; i < 16; i++)
            {
                HebbianLearningClass hebbian = new HebbianLearningClass(arr1, BoolFunc[i]);
                w[i] = hebbian.WeightSum();
            }

            for (int i = 0; i < 16; i++)
            {
                dataGridView3.Columns[i].Name = $"w{i}";
                for (int j = 0; j < 4; j++)
                {
                    dataGridView3[i, j].Value = w[i][j];
                }
            }
            label3.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[][] arr1 = new double[(int)vector.Value][];

            for (int i = 0; i < (int)vector.Value; i++)
            {
                arr1[i] = new double[(int)sizeVector.Value];
                for (int j = 0; j < (int)sizeVector.Value; j++)
                {
                    arr1[i][j] = Convert.ToDouble(dataGridView1[i, j].Value);
                }
            }

            double[] f = new double[(int)sizeVector.Value];

            for (int i = 0; i < (int)sizeVector.Value; i++)
            {
                f[i] = Convert.ToDouble(dataGridView1[(int)vector.Value, i].Value);
            }

            HebbianLearningClass hebbian = new HebbianLearningClass(arr1, f);


            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].Name = "f";
            dataGridView2.Columns[1].Name = "sgn(x)";
            dataGridView2.RowCount = (int)sizeVector.Value;
            int[] sgnX = hebbian.ConvertToThreshold();
            string rule = "The hebbian rule is followed";
            for (int i = 0; i < (int)sizeVector.Value; i++)
            {
                dataGridView2[0, i].Value = f[i];
                dataGridView2[1, i].Value = sgnX[i];
                if(f[i] != sgnX[i])
                {
                    rule = "The hebbian rule is not followed";
                }
            }
            label3.Text = rule;

            double[] w = hebbian.WeightArr();
            dataGridView3.ColumnCount = (int)vector.Value + 1;
            dataGridView3.RowCount = 1;
            for (int i = 0; i < (int)vector.Value + 1; i++)
            {
                dataGridView3.Columns[i].Name = $"w{i}";
                dataGridView3[i, 0].Value = w[i];
            }
            

        }
    }
}
