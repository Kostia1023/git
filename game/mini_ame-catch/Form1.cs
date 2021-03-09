using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_ame_catch
{
    public partial class Form1 : Form
    {
        private int sec = 0;
        private int min = 0;
        private GameFuncion[] listBut;
        public Form1()
        {
            InitializeComponent();
        }
        //private GameFuncion funcion = new GameFuncion();
        private Button bt;
        private Timer tim;
        Random rand = new Random(DateTime.Now.Millisecond);
        private void button1_Click(object sender, EventArgs e)
        {
            //funcion.score = score;
            listBut = new GameFuncion[Convert.ToInt32(textBox1.Text)]; 
            int enem = Convert.ToInt32(textBox1.Text);
            if (enem>0)
            {
                for (int i = 0; i < enem; i++)
                {
                    listBut[i] = new GameFuncion(this,score);
                    //listBut[i] =  funcion.createEnemies();
                    //listBut[i].Text = $"{i+1}";

                    //tim = funcion.createTimer();
                    //tim.Tick += tick;
                    //Controls.Add(listBut[i]);
                }
            }
            label2.Text = textBox1.Text;
            textBox1.Visible = false;
            button1.Visible = false;
            label5.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            label6.Visible = false;

        }
        private void score()
        {
            int sc = Convert.ToInt32(label2.Text);
            label2.Text = Convert.ToString(sc - 1);
            if (sc - 1 == 0)
            {
                label6.Visible = true;
                label6.Text = $"Your time:\n{min:d2}:{sec:d2}";
                textBox1.Visible = true;
                button1.Visible = true;
                label5.Visible = true;
                timer1.Enabled = false;
                timer2.Enabled = false;
                min = 0;
                sec = 0;
                label4.Text = $"{min:d2}:{sec:d2}";
                foreach (GameFuncion item in listBut)
                {
                    item.bt.Visible = false;
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sec += 1;
            label4.Text = $"{min:d2}:{sec:d2}";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            min += 1;
            sec = 0;
            label4.Text = $"{min:d2}:{sec:d2}";
            
        }


    }
}
