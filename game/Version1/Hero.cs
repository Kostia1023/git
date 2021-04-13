using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Version1
{
    class Hero : PhysicalBody
    {

        private bool ProtectionLeft = true;
        private bool ProtectionRight = true;

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

        public int JumpTime = 0;

        public int CheckPointX;

        public int CheckPointY;

        public Control ParentControl;

        public Label NumberOfHp;

        public PictureBox pictureBox;

        public bool Died = false;

        public Hero(int PosX, int PosY, int height, int width, int life, Panel panel, Control control, int windowCenterX)
            : base(PosX, PosY, height, width, panel)
        {
            CheckPointX = ZeroPosX;
            CheckPointY = ZeroPosY;
            ParentControl = control;
            HP = life;
            ParentControl = control;
            centerX = windowCenterX;
            picture.BackColor = Color.DarkGray;
            CreateHpPole();
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
            if (!CrossingsCheck(figuresPoints, TopCrossing) && KeysSpace && JumpTime > 5)
            {
                ChangePositionY(-Speed);
                JumpTime--;
            }
            else
            if (JumpTime != 0)
            {
                JumpTime--;
                this.Active = true;
            }
        }

        public void JumpOpportunity(FiguresPoints[] figuresPoints)
        {
            if (this.CrossingsCheck(figuresPoints, this.BottomCrossing) && this.KeysSpace && JumpTime == 0)
            {
                this.JumpTime = 2 * Speed;
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

        public void Hit(FiguresPoints[] figuresPoints)
        {
            if (CrossingsCheck(figuresPoints, HitBox))
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
            foreach (FiguresPoints item in figuresPoints)
            {
                if (HitBox(item))
                {
                    CheckPointX = item.ZeroPosX;
                    CheckPointY = item.ZeroPosY;
                }
            }
        }

    }
}
