using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    class FiguresPoints
    {
        private int zeroPosX;
        public int ZeroPosX
        {
            get
            {
                return zeroPosX;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                zeroPosX = value;
            }
        }

        private int zeroPosY;
        public int ZeroPosY
        {
            get
            {
                return zeroPosY;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                zeroPosY = value;
            }
        }

        private int heightObj;
        public int HeightObj
        {
            get
            {
                return heightObj;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                heightObj = value;
            }
        }
        
        private int widthObj;
        public int WidthObj
        {
            get
            {
                return widthObj;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                widthObj = value;
            }
        }
        
        private int endPosX;
        public int EndPosX
        {
            get
            {
                return endPosX;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                endPosX = value;
            }
        }
        
        private int endPosY;
        public int EndPosY
        {
            get
            {
                return endPosY;
            }
            set
            {
                if (value < 0) throw new Exception("eror");
                endPosY = value;
            }
        }
        public FiguresPoints(int PosX, int PosY, int height, int width)
        {
            ZeroPosX = PosX;
            ZeroPosY = PosY;
            HeightObj = height;
            WidthObj = width;
            EndPosX = PosX + width;
            endPosY = PosY + height;
        }
    }
}
