using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Version_3
{
    class SpecialBlock : FigureWithoutPhysics
    {

        public delegate void Add(FiguresPoints figures);
        public bool ThisStar = false;
        public FiguresPoints Drop { get; set; }
        public bool Destroy = false;

        public SpecialBlock(int PosX, int PosY, int height, int width, Panel panel)
            : base(PosX, PosY, height, width, panel)
        { }

        public void Break(Add AddItem)
        {
            if (!Destroy)
            {
                //picture.Image = Image.FromFile("");
                picture.Image = null;
                picture.BackColor = Color.Brown;
                if (ThisStar)
                {
                    BreakAndCreateStar(AddItem);
                    Destroy = true;
                }
                else
                {
                    CreateItem();
                }

            }
        }

        public void CreateItem()
        {
            Drop = new FigureWithoutPhysics(ZeroPosX + (int)WidthObj / 2 - 13, ZeroPosY - 50, 25, 25, ParentPanel);
            (Drop as FigureWithoutPhysics).picture.BackColor = Color.Transparent;
            (Drop as FigureWithoutPhysics).picture.Image = Image.FromFile("../../img/star.png");
        }

        public void BreakAndCreateStar(Add AddItem)
        {
            FiguresPoints Drop = new FigureWithoutPhysics(ZeroPosX + (int)WidthObj / 2 - 13, ZeroPosY - 50, 25, 25, ParentPanel);
            (Drop as FigureWithoutPhysics).picture.BackColor = Color.Transparent;
            (Drop as FigureWithoutPhysics).picture.Image = Image.FromFile("../../img/star.png");
            AddItem(Drop);
        }
    }
}
