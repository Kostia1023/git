using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_3
{
    interface IPhisicable
    {
        bool BottomCrossing(FiguresPoints Ground);
        void falling(FiguresPoints[] figuresPoints);
    }
}
