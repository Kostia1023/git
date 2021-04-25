using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Version_3
{
    class Hero : PhysicalBody
    {

        private bool ProtectionLeft = true;
        private bool ProtectionRight = true;

        private int Xp { get; set; }

        private int hp;
        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                hp = value;
            }
        }

        private int centerX;
        public int CenterX
        {
            get
            {
                return centerX;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                centerX = value;
            }
        }

        public bool KeysD = false;

        public bool KeysA = false;

        public bool KeysSpace = false;

        public bool KillKnocback = false;

        public int JumpTime = 0;

        public int CheckPointX;

        public int CheckPointY;

        public Control ParentControl;

        public Label NumberOfHp;

        public Label NumberOfXp;

        public PictureBox pictureBox;

        public PictureBox pictureBox2;

        public bool Died = false;

        public Hero(int PosX, int PosY, int height, int width, int life, Panel panel, Control control, int windowCenterX)
            : base(PosX, PosY, height, width, panel)
        {
            CheckPointX = ZeroPosX;
            CheckPointY = ZeroPosY;
            ParentControl = control;
            HP = life;
            centerX = windowCenterX;
            picture.Image = Image.FromFile("../../img/HeroRight.png");
            Xp = 0;
            CreateHpPole();
            CreateXpPole();
        }


        public void MoveRight(FiguresPoints[] figuresPoints)
        {
            if (this.CrossingsCheck(figuresPoints, RightCrossing) || !KeysD) return;
            if (HeroOnly())
            {
                if (this.picture.Left < ParentPanel.Width - this.picture.Width - Speed * 2) //protection against leaving the game zone
                {
                    ChangePositionX(Speed);
                    CheckProtect();
                }
            }
            else
            {

                if (ProtectionRight)
                {
                    ParentPanel.Left -= Speed;
                    ChangePositionX(Speed);
                }
                else
                {
                    ChangePositionX(Speed);
                    ProtectionRight = true;
                }
            }

        }


        public void MoveLeft(FiguresPoints[] figuresPoints)
        {
            if (this.CrossingsCheck(figuresPoints, LeftCrossing) || !KeysA) return;
            if (HeroOnly())
            {
                if (this.ZeroPosX > Speed * 2) //protection against leaving the game zone
                {
                    ChangePositionX(-Speed);
                    CheckProtect();
                }
            }
            else
            {
                if (ProtectionLeft)
                {
                    ParentPanel.Left += Speed;
                    ChangePositionX(-Speed);

                }
                else
                {
                    ChangePositionX(-Speed);
                    ProtectionLeft = true;
                }
            }
        }

        private void CheckProtect()
        {
            if (this.picture.Left < this.ParentPanel.Width / 2)
            {
                if (HeroOnly())
                {
                    ProtectionLeft = false;
                }
            }
            else
            {
                if (HeroOnly())
                {
                    ProtectionRight = false;
                }
            }
        }

        public void MoveUp(FiguresPoints[] figuresPoints)
        {
            if (!CrossingsCheck(figuresPoints, TopCrossing) && JumpTime > 5 && (KeysSpace || KillKnocback))
            {
                ChangePositionY(-Speed);
                JumpTime--;
            }
            else
            if (JumpTime != 0)
            {
                JumpTime--;
                this.Active = true;
                KillKnocback = false;
            }
        }

        public void JumpOpportunity(FiguresPoints[] figuresPoints, int height)
        {
            if (this.CrossingsCheck(figuresPoints, this.BottomCrossing) && (KeysSpace || KillKnocback) && JumpTime == 0)
            {
                this.JumpTime = height;
                this.Active = false;
            }
        }

        public bool HeroOnly()
        {

            return this.picture.Left < centerX || this.picture.Left > ParentPanel.Width - centerX;
        }

        public bool HitBox(FiguresPoints figures)
        {
            if (this.EndPosX < figures.ZeroPosX || this.ZeroPosX > figures.EndPosX) return false;
            if (this.EndPosY < figures.ZeroPosY || this.ZeroPosY > figures.EndPosY) return false;
            return true;
        }

        public bool atack(FiguresPoints[] figuresPoints, out int a)
        {

            for (int i = 0; i < figuresPoints.Length; i++)
            {
                if (figuresPoints[i] == null)
                {
                    continue;
                }
                if (BottomCrossing(figuresPoints[i]))
                {
                    a = i;
                    return true;
                }
            }
            a = 0;
            return false;
        }

        public bool destroy(FiguresPoints[] figuresPoints, out int a)
        {

            for (int i = 0; i < figuresPoints.Length; i++)
            {
                if (figuresPoints[i] == null)
                {
                    continue;
                }
                if (TopCrossing(figuresPoints[i]))
                {
                    a = i;
                    return true;
                }
            }
            a = 0;
            return false;
        }

        public bool TakeStar(FiguresPoints[] figuresPoints, out int a)
        {
            for (int i = 0; i < figuresPoints.Length; i++)
            {
                if (figuresPoints[i] == null)
                {
                    continue;
                }
                if (HitBox(figuresPoints[i]))
                {
                    Xp += 1000;
                    NumberOfXp.Text = $"X{Xp}";
                    a = i;
                    return true;
                }
            }
            a = 0;
            return false;
        }

        public bool TakeHeart(FiguresPoints[] figuresPoints, out int a)
        {
            for (int i = 0; i < figuresPoints.Length; i++)
            {
                if (figuresPoints[i] == null)
                {
                    continue;
                }
                if (HitBox(figuresPoints[i]))
                {
                    HP++;
                    NumberOfHp.Text = $"X{HP}";
                    a = i;
                    return true;
                }
            }
            a = 0;
            return false;
        }


        private void ChangeHp()
        {
            if (HP > 1)
            {
                HP--;
                ZeroPosX = CheckPointX;
                EndPosX = CheckPointX + WidthObj;
                picture.Left = CheckPointX;

                ZeroPosY = CheckPointY;
                EndPosY = CheckPointY + HeightObj;
                picture.Top = CheckPointY;

                if (CheckPointX - centerX <= 0)
                {
                    ParentPanel.Left = 0;
                }
                else
                if (CheckPointX + centerX >= ParentPanel.Width)
                {
                    ParentPanel.Left = -ParentPanel.Width + centerX;
                }
                else
                {
                    ParentPanel.Left = -CheckPointX + centerX;
                }
                NumberOfHp.Text = $"X{HP}";
            }
            else
            {
                Died = true;
            }
        }

        public void Hit(FiguresPoints[] figuresPoints)
        {
            if (CrossingsCheck(figuresPoints, HitBox))
            {
                ChangeHp();
            }
        }

        public void CreateHpPole()
        {
            NumberOfHp = new Label();
            NumberOfHp.Left = CenterX * 2 - 100;
            NumberOfHp.Top = 55;
            NumberOfHp.Width = 50;
            Font font = new Font("Arial", 12);
            NumberOfHp.Font = font;
            NumberOfHp.BackColor = Color.SkyBlue;
            ShowHp();
            ParentControl.Controls.Add(NumberOfHp);
            NumberOfHp.BringToFront();

        }

        public void CreateXpPole()
        {
            NumberOfXp = new Label();
            NumberOfXp.Left = CenterX * 2 - 150;
            NumberOfXp.Top = 105;
            NumberOfXp.Width = 200;
            Font font = new Font("Arial", 12);
            NumberOfXp.Font = font;
            NumberOfXp.BackColor = Color.SkyBlue;
            ShowXp();
            ParentControl.Controls.Add(NumberOfXp);
            NumberOfHp.BringToFront();

        }

        public void ShowXp()
        {
            NumberOfXp.Text = $"X{Xp}";
            pictureBox2 = new PictureBox();
            pictureBox2.Top = 100;
            pictureBox2.Left = CenterX * 2 - 50;
            pictureBox2.Width = 25;
            pictureBox2.Height = 25;
            pictureBox2.Image = Image.FromFile("../../img/star.png");
            pictureBox2.BackColor = Color.SkyBlue;
            ParentControl.Controls.Add(pictureBox2);
            pictureBox.BringToFront();
        }

        public void AddXp(int xp)
        {
            Xp += xp;
            NumberOfXp.Text = $"X{Xp}";
        }

        public void ShowHp()
        {
            NumberOfHp.Text = $"X{HP}";
            pictureBox = new PictureBox();
            pictureBox.Top = 50;
            pictureBox.Left = CenterX * 2 - 50;
            pictureBox.Width = 25;
            pictureBox.Height = 25;
            pictureBox.Image = Image.FromFile("../../img/Heart.png");
            pictureBox.BackColor = Color.SkyBlue;
            ParentControl.Controls.Add(pictureBox);
            pictureBox.BringToFront();
        }

        public void Save(FiguresPoints[] figuresPoints)
        {
            FiguresPoints figures;
            if (CrossingsCheckAndItem(figuresPoints, HitBox, out figures))
            {
                CheckPointX = figures.ZeroPosX;
                CheckPointY = figures.ZeroPosY;
            }

        }

        public void HideStats()
        {
            pictureBox.Visible = false;
            ParentControl.Controls.Add(pictureBox);

            NumberOfHp.Visible = false;
            ParentControl.Controls.Add(NumberOfHp);
         
            NumberOfXp.Visible = false;
            ParentControl.Controls.Add(NumberOfXp);
            
            pictureBox2.Visible = false;
            ParentControl.Controls.Add(pictureBox2);
        }

    }
}
