using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_3
{
    class PhysicalBody : FigureWithoutPhysics, IPhisicable, IFigureCrossing
    {
        public const int Speed = 10;
        public bool Active = true;
        public bool DropNow = true;

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




    }
}
