using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version_3
{
    interface IFigureCrossing
    {
        bool TopCrossing(FiguresPoints Ground);
        bool RightCrossing(FiguresPoints Ground);
        bool LeftCrossing(FiguresPoints Ground);
    }
}
