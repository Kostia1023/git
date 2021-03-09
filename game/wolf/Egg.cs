using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace wolf
{
    class Egg
    {
        public int looses = 0;
        public int score = 0;
        public Random rand = new Random(DateTime.Now.Millisecond);
        public bool Active = false;
        private int position;
        public int Position
        {
            get { return position; }
            set
            {
                if (value > 0 && value < 5)
                    position = value;
                else
                    throw new Exception("value is incorrect");
            }
        }
        public const int timeSleep = 1000;
        private int lineNumber;
        public int LineNumber
        {
            get { return lineNumber; }
            set
            {
                if (value > 0 && value < 5)
                    lineNumber = value;
                else
                    throw new Exception("value is incorrect");
            }
        }
        public Egg(int line = 1)
        {
            lineNumber = line;
        }
        public void createEgg()
        {
            if (!Active)
            {
                moveEgg();
            }
        }
        public int[] convertLineToСoordinates(int lineNumber, out bool left)
        {
            int[] list = new int[2];
            left = true;

            switch (lineNumber)
            {
                case 1: list[0] = 0;
                    list[1] = 0;
                    break;
                case 2: list[0] = 16;
                    list[1] = 0;
                    left = false;
                    break;
                case 3: list[0] = 0;
                    list[1] = 5;
                    break;
                case 4: list[0] = 16;
                    list[1] = 5;
                    left = false;
                    break;
                default:
                    break;
            }
            return list;
        }
        public void showMoveToTheEnd(int[] coordinates, bool left)
        {

            Console.SetCursorPosition(coordinates[0], coordinates[1]);
            Console.WriteLine(0);
            Thread.Sleep(timeSleep);
            for (int i = 1; i < 4; i++)
            {
                Console.SetCursorPosition(left ? coordinates[0] + i - 1 : coordinates[0] - i + 1, coordinates[1] + i - 1);
                Console.WriteLine(' ');
                Console.SetCursorPosition(left ? coordinates[0] + i : coordinates[0] - i, coordinates[1] + i);
                Console.WriteLine(0);
                Thread.Sleep(timeSleep);
            }
            Console.SetCursorPosition(left ? coordinates[0] + 3 : coordinates[0] - 3, coordinates[1] + 3);
            Console.WriteLine(' ');


        }
        public void isThereABasket(int basketPosition, bool left, out bool win)
        {
            if (basketPosition == lineNumber)
            {
                win = true;
            }
            else
            {
                win = false;

                Console.SetCursorPosition(left ? 4 : 12, 10);
                Console.WriteLine("*");
                Thread.Sleep(timeSleep);
                Console.SetCursorPosition(left ? 4 : 12, 10);
                Console.WriteLine(' ');

            }

        }
        public void readPosition(int positionBasket)
        {
            position = positionBasket;
        }
        public void stopMove(bool win)
        {
            if (win)
            {
                score += 1;
            }
            else
            {
                looses += 1;
            }
        }
        public void moveEgg()
        {
            bool left;
            bool win;
            showMoveToTheEnd(convertLineToСoordinates(LineNumber,out left),left);
            isThereABasket(position, left, out win);
            stopMove(win);

        }

    }
}
