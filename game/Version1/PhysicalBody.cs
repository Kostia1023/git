using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    class PhysicalBody : FigureWithoutPhysics, IPhisicable, IFigureCrossing
    {
        public const int Speed = 10;
        public bool Active = true;
        public bool DropNow = true;
        public delegate bool CrossingsSide(FiguresPoints figuresPoints);
        /// <summary>
        /// FigureWithoutPhysics without physics (walls, ground, platform)
        /// Фігура без фізики (стіни, земля, платформи)
        /// </summary>
        /// <param name="PosX">Starting position on X (початкова позиція по X )</param>
        /// <param name="PosY">Starting position on Y (початкова позиція по X )</param>
        /// <param name="height">The height of the figure (Висота фігури )</param>
        /// <param name="width">The width of the figure (Ширина фігури )</param>
        public PhysicalBody(int PosX, int PosY, int height, int width, Panel panel)
            : base(PosX, PosY, height, width, panel)
        {
        }


        public bool CrossingsCheck(FiguresPoints[] figuresPoints, CrossingsSide crossingsSide)
        {
            foreach (FiguresPoints item in figuresPoints)
            {
                if (item != null && crossingsSide(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void falling(FiguresPoints[] figuresPoints)
        {
            if (!CrossingsCheck(figuresPoints, BottomCrossing) && Active)
            {
                ChangePositionY(Speed);
                DropNow = true;
            }
            else
            {
                DropNow = false;
            }

        }

        public void ChangePositionX(int changes)
        {
            this.ZeroPosX += changes;
            this.EndPosX += changes;
            this.picture.Left += changes;
        }

        public void ChangePositionY(int changes)
        {
            this.ZeroPosY += changes;
            this.EndPosY += changes;
            this.picture.Top += changes;
        }

        public bool TopCrossing(FiguresPoints Ground)
        {
            return (Ground.EndPosY == this.ZeroPosY && !(this.EndPosX < Ground.ZeroPosX || this.ZeroPosX > Ground.EndPosX));
        }

        public bool RightCrossing(FiguresPoints Ground)
        {
            return (Ground.ZeroPosX == this.EndPosX  && !(this.EndPosY - 1 < Ground.ZeroPosY || this.ZeroPosY > Ground.EndPosY));
        }

        public bool BottomCrossing(FiguresPoints Ground)
        {
            return (Ground.ZeroPosY == this.EndPosY && !(this.EndPosX < Ground.ZeroPosX || this.ZeroPosX > Ground.EndPosX));
        }

        public bool LeftCrossing(FiguresPoints Ground)
        {
            return (Ground.EndPosX == this.ZeroPosX && !(this.EndPosY - 1 < Ground.ZeroPosY || this.ZeroPosY > Ground.EndPosY));
        }


    }
}
