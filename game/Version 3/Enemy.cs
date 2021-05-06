using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Version_3
{
    class Enemy : PhysicalBody
    {
        public event Move MoveXAndY;
        public bool MoveToTheRight = true;
        public bool RightNow = true;
        private int rightBorder;
        public int RightBorder
        {
            get
            {
                return rightBorder;
            }
            set
            {
                if (value < 0 || value > ParentPanel.Width) throw new Exception("eror");
                rightBorder = value;
            }
        }

        private int leftBorder;
        public int LeftBorder
        {
            get
            {
                return leftBorder;
            }
            set
            {
                if (value < 0 || value > ParentPanel.Width) throw new Exception("eror");
                leftBorder = value;
            }
        }
        public int SpeedX = 0;

        public Enemy(int PosX, int PosY, int height, int width, Panel panel, int LBotder, int RBorder)
           : base(PosX, PosY, height, width, panel)
        {
            RightBorder = RBorder;
            LeftBorder = LBotder;
            picture.Image = Image.FromFile("../../img/batLeft.gif");
            MoveXAndY += MoveRight;
            
        }

        public Enemy(int PosX, int PosY, int height, int width, Panel panel) : this(PosX, PosY, height, width, panel, 0, 0)
        { }


        public void MoveRight(FiguresPoints[] figuresPoints)
        {
            if (RightNow)
            {
                RightNow = !RightNow;
                picture.Image = Image.FromFile("../../img/batRight.gif");
            }
            if (CrossingsCheck(figuresPoints, RightCrossing) || RightBorder == this.EndPosX)
            {
                MoveXAndY -= MoveRight;
                MoveXAndY += MoveLeft;
            }
            else ChangePositionX(SpeedX);

        }

        public void MoveLeft(FiguresPoints[] figuresPoints)
        {
            if (!RightNow)
            {
                RightNow = !RightNow;
                picture.Image = Image.FromFile("../../img/batLeft.gif");
            }
            if (CrossingsCheck(figuresPoints, LeftCrossing) || LeftBorder == this.ZeroPosX)
            {
                MoveXAndY -= MoveLeft;
                MoveXAndY += MoveRight;
            }
            else ChangePositionX(-SpeedX);
        }

        public void MoveNow(FiguresPoints[] figuresPoints)
        {
            MoveXAndY?.Invoke(figuresPoints);
        }

    }
}
