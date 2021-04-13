using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Version1
{
    class Enemy : PhysicalBody
    {
        public bool MoveToTheRight = true;

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

        public Enemy(int PosX, int PosY, int height, int width, Panel panel, int RBorder, int LBotder)
           : base(PosX, PosY, height, width, panel)
        {
            RightBorder = RBorder;
            leftBorder = LBotder;
            picture.BackColor = Color.Red; 
        }

        public Enemy(int PosX, int PosY, int height, int width, Panel panel):this(PosX, PosY, height, width, panel, 0, 0)  
        { }

        public void MoveX(FiguresPoints[] figuresPoints)
        {
            if (MoveToTheRight)
            {
                MoveRight(figuresPoints);
            }
            else
            {
                MoveLeft(figuresPoints);
            }

        }
        public void MoveRight(FiguresPoints[] figuresPoints)
        {
            
            if (CrossingsCheck(figuresPoints, RightCrossing) || RightBorder == this.EndPosX)
            {
                MoveToTheRight = false;
            }
            else ChangePositionX(-SpeedX);
           
        }

        public void MoveLeft(FiguresPoints[] figuresPoints)
        {
           
            if (CrossingsCheck(figuresPoints, LeftCrossing) || leftBorder == this.ZeroPosX)
            {
                MoveToTheRight = true;
            }
            else ChangePositionX(+SpeedX);
           
        }

    }
}
