using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace інтерфейс_1
{
    public partial class Form1 : Form
    {
        private bool Down = false;
        private bool PanelDown = false;
        private Control obj;
        private PictureBox picture;
        private Panel panel;
        private Color BackgroundPanel = Color.White;
        private Color BorderPanelColor = Color.Black;
        private bool ShowBorder = true;

        private int MouseLeft;
        private int MouseTop;
        private int ElLeft;
        private int ElTop;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateImg(int x, int y, int w = 50, int h = 50)
        {
            picture = new PictureBox();
            picture.Top = y;
            picture.Left = x;
            picture.Width = w;
            picture.Height = h;
            toolStripMenuItem8.Text = $"{x},{y}";
            picture.Tag = 2;
            picture.Image = DrawImg(w, h, Color.Black);
            picture.MouseDown += MyMouseDown;
            picture.MouseUp += MyMouseUp;
            picture.MouseMove += MyMouseMove;
            picture.ContextMenuStrip = contextMenuStrip1;
            panel.Controls.Add(picture);
        }



        private void MyMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Down = true;
            obj = sender as Control;
        }

        private void MyMouseUp(object sender, MouseEventArgs e)
        {
            Down = false;
        }

        private void MyMouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (Down)
            {
                c.Location = panel.PointToClient(Control.MousePosition);
                toolStripMenuItem8.Text = $"{c.Left},{c.Top}";
            }
        }


        private void MyDoubleClick(object sender, MouseEventArgs e)
        {
            CreateImg(e.X, e.Y);
        }


        private Bitmap DrawImg(int w, int h, Color BorderColor, int PenSize = 2)
        {
            Bitmap btm = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(btm))
            {
                Pen pen = new Pen(BorderColor, PenSize);
                g.DrawRectangle(pen, new Rectangle(0, 0, w - 1, h - 1));
            }
            return btm;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                obj.BackColor = colorDialog1.Color;
            }
        }



        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] a = toolStripMenuItem6.Text.Split(',').Select(int.Parse).ToArray();
            picture.Width = a[0];
            picture.Height = a[1];
            (obj as PictureBox).Image = DrawImg(a[0], a[1], Color.Black, Convert.ToInt32(obj.Tag));


        }

        private void colorBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color col;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                col = colorDialog1.Color;
                (obj as PictureBox).Image = DrawImg(obj.Width, obj.Height, col, Convert.ToInt32(obj.Tag));
            }
        }

        private void changeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (obj as PictureBox).Image = DrawImg(obj.Width, obj.Height, Color.Black, Convert.ToInt32(toolStripMenuItem7.Text));
            obj.Tag = Convert.ToInt32(toolStripMenuItem7.Text);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (obj as PictureBox).Image = DrawImg(obj.Width, obj.Height, Color.Black, Convert.ToInt32(toolStripMenuItem7.Text));
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (obj as PictureBox).Image = null;
        }

        private void placeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] a = toolStripMenuItem8.Text.Split(',').Select(int.Parse).ToArray();
            obj.Left = a[0];
            obj.Top = a[1];
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel = new Panel();
            panel.Top = 150;
            panel.Left = 150;
            int[] a = toolStripMenuItem10.Text.Split(',').Select(int.Parse).ToArray();
            panel.Width = a[0];
            panel.Height = a[1];
            panel.BackColor = BackgroundPanel;
            panel.MouseDoubleClick += MyDoubleClick;
            panel.MouseDown += MyPanelMouseDown;
            panel.MouseUp += MyPanelMouseUp;
            panel.MouseMove += MyPanelMouseMove;
            toolStripMenuItem9.Text = toolStripMenuItem10.Text;
            if (ShowBorder)
                panel.BackgroundImage = DrawImg(panel.Width, panel.Height, BorderPanelColor, int.Parse(toolStripMenuItem11.Text));
            this.Controls.Add(panel);
        }

        private void backgroundColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackgroundPanel = colorDialog1.Color;
            }
        }

        private void borderColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BorderPanelColor = colorDialog1.Color;
            }
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowBorder = true;
        }

        private void hideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowBorder = false;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackgroundPanel = colorDialog1.Color;
                panel.BackColor = BackgroundPanel;
            }
        }

        private void changeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int[] a = toolStripMenuItem9.Text.Split(',').Select(int.Parse).ToArray();
            panel.Width = a[0];
            panel.Height = a[1];
            if (ShowBorder)
                panel.BackgroundImage = DrawImg(panel.Width, panel.Height, BorderPanelColor, int.Parse(toolStripMenuItem11.Text));


        }
        private void MyPanelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseLeft = Control.MousePosition.X;
                MouseTop = Control.MousePosition.Y;

                ElLeft = (sender as Control).Left;
                ElTop = (sender as Control).Top;
                //MessageBox.Show($"{Control.MousePosition.X} --- {Control.MousePosition.Y} --- {(sender as Control).Left} --- {(sender as Control).Top}");
                PanelDown = true;
            }
        }
        private void MyPanelMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PanelDown = false;
            }
        }

        private void MyPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (PanelDown)
            {
                (sender as Control).Left = ElLeft + Control.MousePosition.X - MouseLeft;
                (sender as Control).Top = ElTop + Control.MousePosition.Y - MouseTop;
                //Thread.Sleep(50);
            }
        }

        private void MyKeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                int[] a = toolStripMenuItem9.Text.Split(',').Select(int.Parse).ToArray();
                panel.Width = a[0];
                panel.Height = a[1];
                if (ShowBorder)
                    panel.BackgroundImage = DrawImg(panel.Width, panel.Height, BorderPanelColor, int.Parse(toolStripMenuItem11.Text));

            }
        }

        private void MyKeyDownEnterObjPos(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                
                int[] a = toolStripMenuItem8.Text.Split(',').Select(int.Parse).ToArray();
                obj.Left = a[0];
                obj.Top = a[1];

            }
        }

        private void toolStripMenuItem9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                int[] a = toolStripMenuItem9.Text.Split(',').Select(int.Parse).ToArray();
                panel.Width = a[0];
                panel.Height = a[1];
                if (ShowBorder)
                    panel.BackgroundImage = DrawImg(panel.Width, panel.Height, BorderPanelColor, int.Parse(toolStripMenuItem11.Text));

            }
        }
        private void toolStripMenuItem6_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Return)
            {
                
                int[] a = toolStripMenuItem6.Text.Split(',').Select(int.Parse).ToArray();
                obj.Width = a[0];
                obj.Height = a[1];
                (obj as PictureBox).Image = DrawImg(a[0], a[1], Color.Black, Convert.ToInt32(obj.Tag));

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(panel);
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel.Controls.Remove(obj);
        }

    }
}
