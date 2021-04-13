using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    public partial class Form1 : Form
    {
        private Hero hero;
        private LevelObjects lvl1;
        private int CenterX;
        private Panel panel1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //----------------------------Test-------------------------------
            //------------------------Create-Pole----------------------------
            this.WindowState = FormWindowState.Maximized;
            panel1 = new Panel();
            panel1.Left = 0;
            panel1.Top = 0;
            panel1.Width = 9000;
            panel1.Height = 2000;
            panel1.BackColor = Color.SkyBlue;

            //----------------------Create-Lvl------------------------------
            lvl1 = new LevelObjects(2, 11, 1,2, new FigureWithoutPhysics(8800,750,150,50, panel1));
                        
            //---------------------Add-platforms----------------------------
            lvl1.AddPlatforms(new FigureWithoutPhysics(0, 900, 30, 1400, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(2000, 900, 30, 1500, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(300, 560, 30, 400, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(1500, 870, 30, 400, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(3600, 880, 20, 100, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(3800, 880, 20, 100, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(4000, 900, 30, 3000, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(7100, 900, 30, 50, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(7250, 900, 30, 50, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(7450, 900, 30, 50, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(7600, 900, 30, 2400, panel1));

            for (int i = 0; i < lvl1.NumberPlatforms; i++)
            {
                (lvl1.PlatformsList[i] as FigureWithoutPhysics).picture.BackColor = Color.Green;
            }
            //----------------------Add-check-points----------------------

            lvl1.AddCheckPoints(new FigureWithoutPhysics(2500,750,150,50,panel1));
            lvl1.AddCheckPoints(new FigureWithoutPhysics(6500,750,150,50,panel1));

            for (int i = 0; i < lvl1.NumberCheckpoints; i++)
            {
                (lvl1.CheckPointsList[i] as FigureWithoutPhysics).picture.BackColor = Color.Purple;
            }


            //------------------------Add-enemies-------------------------
            lvl1.AddEnemy(new Enemy(1050, 800, 20, 20, panel1, 1000, 2000));
            lvl1.AddEnemy(new Enemy(7200, 850, 20, 20, panel1, 6900, 8000));
            for (int i = 0; i < lvl1.MaxNumberEnemies; i++)
            {
                lvl1.EnemiesList[i].SpeedX = 2;

            }
            
            //----------------------Add-static-enemies--------------------
            lvl1.AddStaticEnemy(new FigureWithoutPhysics(0, 930, 120, 9000, panel1));

            for (int i = 0; i < lvl1.StaticEnemies; i++)
            {
                (lvl1.StaticEnemiesList[i] as FigureWithoutPhysics).picture.BackColor = Color.Orange;
            }
            
            //------------------------Create-hero-------------------------
            hero = new Hero(300, 200, 60, 40, 3,panel1, this, CenterX);

            //----------------------Add-panel-----------------------------
            this.Controls.Add(panel1);
            //----------------------End-test------------------------------
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //--------------------Move-hero--------------------
            hero.falling(lvl1.PlatformsList);
            hero.MoveRight(lvl1.PlatformsList);
            hero.MoveLeft(lvl1.PlatformsList);
            hero.JumpOpportunity(lvl1.PlatformsList);
            hero.MoveUp(lvl1.PlatformsList);

            //----------------Check-death-and-hit--------------
            hero.Hit(lvl1.AllEnemies());
            if (hero.Died)
            {
                timer1.Stop();
                panel1.Visible = false;
                hero.pictureBox.Visible = false;
                hero.NumberOfHp.Visible = false;
                MessageBox.Show("You died");
                hero.NumberOfHp.Visible = true;
                hero.pictureBox.Visible = true;
                this.OnLoad(e);
                timer1.Start();
            }
            //----------------------Save-------------------------

            hero.Save(lvl1.CheckPointsList);


            //-------------------Check-win------------------------
            if (hero.HitBox(lvl1.WinObj))
            {
                timer1.Stop();
                panel1.Visible = false;
                hero.pictureBox.Visible = false;
                hero.NumberOfHp.Visible = false;
                MessageBox.Show("You Win");
                hero.NumberOfHp.Visible = true;
                hero.pictureBox.Visible = true;
            
                this.OnLoad(e);
                timer1.Start();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            CenterX = (int)(this.Width / 2);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    hero.KeysA = true;
                    break;

                case Keys.D:
                    hero.KeysD = true;
                    break;

                case Keys.Space:
                    hero.KeysSpace = true;
                    break;

            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    hero.KeysA = false;
                    break;

                case Keys.D:
                    hero.KeysD = false;
                    break;


                case Keys.Space:
                    hero.KeysSpace = false;
                    break;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < lvl1.NumberEnemies; i++)
            {
                lvl1.EnemiesList[i].MoveX(lvl1.PlatformsList);
            }
        }
    }
}
