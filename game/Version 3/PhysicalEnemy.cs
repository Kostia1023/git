using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Version_3
{
    class PhysicalEnemy : Enemy
    {
        public bool Skip = true;
        public PhysicalEnemy(int PosX, int PosY, int height, int width, Panel panel, int LBotder, int RBorder)
           : base(PosX, PosY, height, width, panel, LBotder, RBorder)
        {
            MoveXAndY -= base.MoveRight;
            MoveXAndY += this.MoveRight;
            MoveXAndY += falling;
            picture.Image = Image.FromFile("../../img/goomba.gif");
        }
        public PhysicalEnemy(int PosX, int PosY, int height, int width, Panel panel) : this(PosX, PosY, height, width, panel, 0, 0)
        { }

        public new void MoveRight(FiguresPoints[] figuresPoints)
        {

            if (CrossingsCheck(figuresPoints, RightCrossing) || RightBorder == this.EndPosX || (!CrossingsCheck(figuresPoints, DropCheck) && Skip))
            {
                Skip = false;
                MoveXAndY -= this.MoveRight;
                MoveXAndY += this.MoveLeft;
            }
            else
            {
                Skip = true;
                ChangePositionX(SpeedX);
            }
        }

        public new void MoveLeft(FiguresPoints[] figuresPoints)
        {

            if (CrossingsCheck(figuresPoints, LeftCrossing) || LeftBorder == this.ZeroPosX || (!CrossingsCheck(figuresPoints, DropCheck) && Skip))
            {
                Skip = false;
                MoveXAndY -= this.MoveLeft;
                MoveXAndY += this.MoveRight;
            }
            else
            {
                Skip = true;
                ChangePositionX(-SpeedX);
            }
        }
        public bool DropCheck(FiguresPoints Ground)
        {
            return (this.ZeroPosX > Ground.ZeroPosX + 10 && this.EndPosX < Ground.EndPosX - 10);
        }
    }
}
