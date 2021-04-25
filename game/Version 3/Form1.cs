using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_3
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
            for (int i = 0; i < panel1.Width / 2000; i++)
            {
                PictureBox Cloud1 = new PictureBox();
                Cloud1.Top = 200;
                Cloud1.Width = 130;
                Cloud1.Height = 100;
                Cloud1.Image = Image.FromFile("../../img/cloud1.png");
                Cloud1.Left = 150 + 2000 * i;
                //Cloud1.BringToFront();
                panel1.Controls.Add(Cloud1);
            }

            for (int i = 0; i < panel1.Width / 1300; i++)
            {
                PictureBox Cloud2 = new PictureBox();
                Cloud2.Top = 50;
                Cloud2.Width = 266;
                Cloud2.Height = 100;
                Cloud2.Image = Image.FromFile("../../img/cloud2.png");
                Cloud2.Left = 500 + 1300 * i;
                //Cloud1.BringToFront();
                panel1.Controls.Add(Cloud2);
            }


            for (int i = 0; i < panel1.Width / 1500; i++)
            {
                PictureBox shrub2 = new PictureBox();
                shrub2.Top = 834;
                shrub2.Width = 264;
                shrub2.Height = 66;
                shrub2.Image = Image.FromFile("../../img/shrub2.png");
                shrub2.Left = 150 + 2000 * i;
                //Cloud1.BringToFront();
                panel1.Controls.Add(shrub2);
            }

            //----------------------Create-Lvl------------------------------
            lvl1 = new LevelObjects(4, 13, 1, 2, 6, 1, 2, 1, new FigureWithoutPhysics(8600, 720, 180, 180, panel1));
            (lvl1.WinObj as FigureWithoutPhysics).picture.Image = Image.FromFile("../../img/castle.png");

            //---------------------Add-platforms----------------------------
            lvl1.AddPlatforms(new FigureWithoutPhysics(0, 900, 120, 1400, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(2000, 900, 120, 1500, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(1500, 870, 120, 400, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(3600, 880, 120, 120, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(3800, 880, 120, 100, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(4000, 900, 120, 3000, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(7100, 900, 120, 60, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(7250, 900, 120, 60, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(7450, 900, 120, 60, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(7600, 900, 120, 2400, panel1));
            lvl1.AddPlatforms(new FigureWithoutPhysics(2300, 750, 60, 200, panel1));

            //for (int i = 0; i < lvl1.NumberPlatforms; i++)
            //{
            //    (lvl1.PlatformsList[i] as FigureWithoutPhysics).picture.BackColor = Color.Green;
            //}
            //---------------------------Trumpet------------------------------
            lvl1.AddPlatforms(new FigureWithoutPhysics(280, 780, 40, 100, panel1));
            (lvl1.PlatformsList[lvl1.NumberPlatforms-1] as FigureWithoutPhysics).picture.Image = DrawPicture.DrawTrumpetTop(lvl1.PlatformsList[lvl1.NumberPlatforms-1].WidthObj, lvl1.PlatformsList[lvl1.NumberPlatforms-1].HeightObj);
            lvl1.AddPlatforms(new FigureWithoutPhysics(300, 820, 80, 60, panel1));
            (lvl1.PlatformsList[lvl1.NumberPlatforms-1] as FigureWithoutPhysics).picture.Image = DrawPicture.DrawTrumpetBottom(lvl1.PlatformsList[lvl1.NumberPlatforms-1].WidthObj, lvl1.PlatformsList[lvl1.NumberPlatforms-1].HeightObj);




            //-------------------------Special-cube----------------------------

            lvl1.AddSpecialCube(new SpecialBlock(2600, 750, 60, 60, panel1));
            lvl1.AddSpecialCube(new SpecialBlock(2660, 750, 60, 60, panel1));
            lvl1.AddSpecialCube(new SpecialBlock(2720, 750, 60, 60, panel1));
            lvl1.AddSpecialCube(new SpecialBlock(2840, 750, 60, 60, panel1));
            lvl1.AddSpecialCube(new SpecialBlock(2900, 750, 60, 60, panel1));
            lvl1.AddSpecialCube(new SpecialBlock(2960, 750, 60, 60, panel1));
            lvl1.AddSpecialUnbreakableCube(new SpecialBlock(2780, 750, 60, 60, panel1));
            (lvl1.SpecialUnbreakableCubeList[0] as SpecialBlock).ThisStar = true;


            for (int i = 0; i < lvl1.MaxNumberSpecialCube; i++)
            {
                (lvl1.SpecialCubeList[i] as FigureWithoutPhysics).picture.Image = DrawPicture.DrawBrick(lvl1.SpecialCubeList[i].WidthObj, lvl1.SpecialCubeList[i].HeightObj);
            }
            for (int i = 0; i < lvl1.MaxNumberUnbreakableSpecialCube; i++)
            {
                (lvl1.SpecialUnbreakableCubeList[i] as FigureWithoutPhysics).picture.Image = DrawPicture.DrawBrick(lvl1.SpecialUnbreakableCubeList[i].WidthObj, lvl1.SpecialUnbreakableCubeList[i].HeightObj);
            }
            //-----------------------------heart---------------------------

            lvl1.AddHeart(new FigureWithoutPhysics(800, 850, 25, 25, panel1));
            lvl1.AddHeart(new FigureWithoutPhysics(4500, 850, 25, 25, panel1));
            for (int i = 0; i < lvl1.NumberHeart; i++)
            {
                (lvl1.HeartList[i] as FigureWithoutPhysics).picture.Image = Image.FromFile("../../img/Heart.png");
            }

            //----------------------Add-check-points----------------------

            lvl1.AddCheckPoints(new FigureWithoutPhysics(2500, 750, 150, 50, panel1));
            lvl1.AddCheckPoints(new FigureWithoutPhysics(6500, 750, 150, 50, panel1));

            for (int i = 0; i < lvl1.NumberCheckpoints; i++)
            {
                (lvl1.CheckPointsList[i] as FigureWithoutPhysics).picture.Image = null;
            }


            //------------------------Add-enemies-------------------------
            lvl1.AddEnemy(new Enemy(1050, 700, 50, 90, panel1, 1000, 2000));
            lvl1.AddEnemy(new Enemy(7200, 820, 50, 90, panel1, 6900, 8000));
            lvl1.AddEnemy(new Enemy(3000, 820, 50, 90, panel1, 2100, 3300));
            lvl1.AddEnemy(new Enemy(5000, 820, 50, 90, panel1, 4300, 6500));
            for (int i = 0; i < lvl1.MaxNumberEnemies; i++)
            {
                lvl1.EnemiesList[i].SpeedX = 2;

            }

            //----------------------Add-static-enemies--------------------
            lvl1.AddStaticEnemy(new FigureWithoutPhysics(0, 1100, 120, 9000, panel1));

            for (int i = 0; i < lvl1.StaticEnemies; i++)
            {
                (lvl1.StaticEnemiesList[i] as FigureWithoutPhysics).picture.BackColor = Color.Orange;
            }

            //------------------------Create-hero-------------------------
            hero = new Hero(300, 700, 70, 50, 3, panel1, this, CenterX);

            //----------------------Add-panel-----------------------------
            this.Controls.Add(panel1);
            //----------------------End-test------------------------------
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            //--------------------Move-hero--------------------
            hero.falling(lvl1.AllPlatforms());
            hero.MoveRight(lvl1.AllPlatforms());
            hero.MoveLeft(lvl1.AllPlatforms());
            hero.JumpOpportunity(lvl1.AllPlatforms(), 20);
            hero.MoveUp(lvl1.AllPlatforms());
            //-----------------------Atack---------------------
            int a;
            if (hero.atack(lvl1.Enemie(), out a))
            {
                hero.AddXp(200);
                lvl1.EnemiesList[a].Hide();
                lvl1.EnemiesList[a] = null;
                hero.JumpTime = 15;
                hero.Active = false;
                hero.KillKnocback = true;
            }
            //-------------------------take-star---------------------

            if (hero.TakeStar(lvl1.StarList, out a))
            {
                (lvl1.StarList[a] as FigureWithoutPhysics).Hide();
                lvl1.StarList[a] = null;
            }

            //------------------------take-heart----------------------


            if (hero.TakeHeart(lvl1.HeartList, out a))
            {
                (lvl1.HeartList[a] as FigureWithoutPhysics).Hide();
                lvl1.HeartList[a] = null;
            }



            //-----------------------Destroy-cube---------------------

            if (hero.destroy(lvl1.SpecialCubeList, out a))
            {

                (lvl1.SpecialCubeList[a] as FigureWithoutPhysics).Hide();
                lvl1.SpecialCubeList[a] = null;
            }

            if (hero.destroy(lvl1.SpecialUnbreakableCubeList, out a))
            {
                //(lvl1.SpecialCubeList[a] as SpecialBlock).Destroy = true;
                (lvl1.SpecialUnbreakableCubeList[a] as SpecialBlock).Break(lvl1.AddStar);
            }

            //----------------Check-death-and-hit--------------
            hero.Hit(lvl1.AllEnemies());
            if (hero.Died)
            {
                timer1.Stop();
                panel1.Visible = false;
                hero.HideStats();
                MessageBox.Show("You died");
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
                hero.HideStats();
                MessageBox.Show("You Win");
                this.OnLoad(e);
                timer1.Start();
            }
            hero.picture.BringToFront();
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
                    hero.picture.Image = Image.FromFile("../../img/HeroLeft.png");
                    hero.KeysA = true;
                    break;

                case Keys.D:
                    hero.picture.Image = Image.FromFile("../../img/HeroRight.png");                   
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

                lvl1.EnemiesList[i]?.MoveX(lvl1.AllPlatforms());
            }
        }
    }

}
