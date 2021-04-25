using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Version_3
{
    class DrawPicture
    {
        private static Bitmap btm;
        private static SolidBrush brush;
        private static Pen MyPen;

        public static Bitmap DrawTrumpetTop(int Width, int Height)
        {
            btm = new Bitmap(Width, Height);
            int CofX = Width / 50;
            Graphics g = Graphics.FromImage(btm);
            brush = new SolidBrush(Color.Black);
            DrawBorderTopEl(CofX, Height);
            DrawTextureTopEl(CofX, Height);
            g.Dispose();
            brush.Dispose();
            return btm;
        }

        private static void DrawBorderTopEl(int CX, int HY)
        {
            Graphics g = Graphics.FromImage(btm);
            MyPen = new Pen(Color.Black, CX * 2);
            Point[] point1 = { new Point(CX, HY - CX), new Point(CX, CX), new Point(CX * 49, CX), new Point(CX * 49, HY - CX), new Point(CX, HY - CX) };
            g.DrawLines(MyPen, point1);
            MyPen.Dispose();
            g.Dispose();
        }

        private static void DrawTextureTopEl(int CX, int HY)
        {
            Graphics g = Graphics.FromImage(btm);
            brush = new SolidBrush(Color.FromArgb(255, 14, 220, 10));
            g.FillRectangle(brush, new Rectangle(CX * 2, CX * 4, CX * 46, HY - CX * 6));
            brush = new SolidBrush(Color.FromArgb(255, 170, 251, 57));
            g.FillRectangle(brush, new Rectangle(CX * 2, CX * 2, CX * 46, CX * 3));



            g.FillRectangle(brush, new Rectangle(CX * 2, CX * 7, CX * 5, HY - CX * 9));

            g.FillRectangle(brush, new Rectangle(CX * 13, CX * 4, CX * 8, HY - CX * 6));

            g.FillRectangle(brush, new Rectangle(CX * 23, CX * 7, CX * 2, HY - CX * 9));

            g.FillRectangle(brush, new Rectangle(CX * 45, CX * 4, CX * 3, HY - CX * 6));

            brush = new SolidBrush(Color.FromArgb(200, 170, 251, 57));

            g.FillRectangle(brush, new Rectangle(CX * 41, CX * 4, CX * 4, HY - CX * 6));

            g.Dispose();
            brush.Dispose();
        }

        public static Bitmap DrawTrumpetBottom(int Width, int Height)
        {
            btm = new Bitmap(Width, Height);
            int CofX = Width / 30;
            Graphics g = Graphics.FromImage(btm);
            brush = new SolidBrush(Color.Black);
            DrawBorderBottomEl(CofX, Height);
            DrawTextureBottomEl(CofX, Height);
            g.Dispose();
            brush.Dispose();
            return btm;
        }

        private static void DrawBorderBottomEl(int CX, int HY)
        {
            Graphics g = Graphics.FromImage(btm);
            MyPen = new Pen(Color.Black, 10);
            Point[] point1 = { new Point(CX, HY), new Point(CX, CX), new Point(CX * 29, CX), new Point(CX * 29, HY) };
            g.DrawLines(MyPen, point1);
            MyPen.Dispose();
            g.Dispose();
        }

        private static void DrawTextureBottomEl(int CX, int HY)
        {
            Graphics g = Graphics.FromImage(btm);
            brush = new SolidBrush(Color.FromArgb(255, 14, 220, 10));
            g.FillRectangle(brush, new Rectangle(CX * 2, CX * 2, CX * 26, HY));
            brush = new SolidBrush(Color.FromArgb(255, 170, 251, 57));
            g.FillRectangle(brush, new Rectangle(CX * 2, CX * 2, CX * 2, HY));

            g.FillRectangle(brush, new Rectangle(CX * 7, CX * 2, CX * 5, HY));

            g.FillRectangle(brush, new Rectangle(CX * 14, CX * 2, CX * 2, HY));

            g.FillRectangle(brush, new Rectangle(CX * 25, CX * 2, CX * 3, HY));

            brush = new SolidBrush(Color.FromArgb(200, 170, 251, 57));

            g.FillRectangle(brush, new Rectangle(CX * 22, CX * 2, CX * 4, HY));

            g.Dispose();
            brush.Dispose();
        }

        public static Bitmap DrawBrick(int Width, int Height)
        {
            btm = new Bitmap(Width, Height);
            MyPen = new Pen(Color.GhostWhite, 2);
            Graphics g = Graphics.FromImage(btm);
            g.FillRectangle(new SolidBrush(Color.Brown), new Rectangle(0, 0, Width, Height));
            g.DrawRectangle(MyPen, new Rectangle(0, 0, Width - 1, Height - 1));
            DrawLineBrick(ref btm);

            g.Dispose();
            return btm;
        }

        private static void DrawLineBrick(ref Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);
            int lengthW = bitmap.Width / 25;
            int lengthH = bitmap.Height / 15;
            for (int j = 0; j < lengthH+1; j++)
            {
                g.DrawLine(MyPen, 0, 15 * j, bitmap.Width, 15 * j);
                for (int i = 0; i < lengthW + 1; i++)
                {
                    if (j % 2 == 0)
                    {
                        g.DrawLine(MyPen, 25 * i, 15 * j, 25 * i, 15 * (j + 1));
                    }
                    else
                    {
                        g.DrawLine(MyPen, 10 + 25 * i, 15 * j, 10 + 25 * i, 15 * (j + 1));
                    }
                }
            }
            g.Dispose();
        }
    }
}
