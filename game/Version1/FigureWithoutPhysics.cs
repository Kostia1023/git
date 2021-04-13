using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Version1
{
    class FigureWithoutPhysics : FiguresPoints, IFigureShow
    {
        private bool Shown = false; 
        public PictureBox picture;
        public Panel ParentPanel;

        /// <summary>
        /// FigureWithoutPhysics without physics (walls, ground, platform)
        /// Фігура без фізики (стіни, земля, платформи)
        /// </summary>
        /// <param name="PosX">Starting position on X (Початкова позиція по X )</param>
        /// <param name="PosY">Starting position on Y (Початкова позиція по Y )</param>
        /// <param name="height">The height of the figure (Висота фігури )</param>
        /// <param name="width">The width of the figure (Ширина фігури )</param>
        /// <param name="panel">The panel on which the object will be located (Панель на якій буде розташований об'єкт )</param>
        public FigureWithoutPhysics(int PosX, int PosY, int height, int width, Panel panel)
            : base(PosX, PosY, height, width)
        {
            ParentPanel = panel;
            Show();
        }

        public void Show()
        {
            if (Shown) return;
            picture = new PictureBox();
            picture.Width = WidthObj;
            picture.Height = HeightObj;
            picture.Top = ZeroPosY;
            picture.Left = ZeroPosX;
            picture.Image = CreateImage(picture.Width,picture.Height);
            ParentPanel.Controls.Add(picture);
            Shown = true;
        }

        private Bitmap CreateImage(int width, int height)
        {

            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Pen myPen = new Pen(Color.Black);              
                g.DrawRectangle(myPen, new Rectangle(0, 0, width - 1, height - 1));
            }
            return bmp;
        }

        public void Hide()
        {
            throw new NotImplementedException();
        }

    }
}
