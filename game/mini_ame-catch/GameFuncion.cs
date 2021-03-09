using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace mini_ame_catch
{
    class GameFuncion
    {
        public delegate void scoreLabel();
        public scoreLabel score;
        private Timer tim;
        public Button bt;
        public int a;
        private bool alive = true;
        Random rand = new Random(DateTime.Now.Millisecond);

        public GameFuncion(Control parent, scoreLabel newScore)
        {
            bt = new Button();
            bt.Width = 40;
            bt.Height = 40;
            bt.Left = 390;
            bt.Top = 180;
            bt.BackColor = Color.Green;
            bt.Click += myClick;
            bt.BackgroundImage = Image.FromFile("../../img/alive.png");
            //bt.Text = $"{i}";
            parent.Controls.Add(bt);
            tim = new Timer();
            tim.Interval = 100;
            tim.Enabled = true;
            tim.Tick += tick;
            score = newScore;

        }
        private void myClick(object sender, EventArgs e)
        {
            if (alive)
            {
                score();
                alive = false;
                tim.Enabled = false;
                bt.BackgroundImage = Image.FromFile("../../img/died.png");
            }
            
        }
        private void tick(object sender, EventArgs e)
        {
            bt.Left += rand.Next(-30, 30);
            bt.Top += rand.Next(-30, 30);
        }
        public Timer createTimer()
        {
            tim = new Timer();
            tim.Interval = 100;
            tim.Enabled = true;
            return tim;
        }

    }
}
