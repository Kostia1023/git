using System;
using System.Collections.Generic;
using System.Text;

namespace wolf
{
    class GameFuncion
    {
        public Egg egg;
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

        public void moveQ(Egg[] listEgg)
        {
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("U");
            Console.SetCursorPosition(12, 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine(" ");
            Console.SetCursorPosition(12, 9);
            Console.WriteLine(" ");
            foreach (Egg item in listEgg)
            {
                item.readPosition(1);
            }

        }

        public void moveW(Egg[] listEgg)
        {
            Console.SetCursorPosition(4, 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(12, 4);
            Console.WriteLine("U");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine(" ");
            Console.SetCursorPosition(12, 9);
            Console.WriteLine(" ");
            foreach (Egg item in listEgg)
            {
                item.readPosition(2);
            }
        }
        public void moveA(Egg[] listEgg)
        {
            Console.SetCursorPosition(4, 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(12, 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("U");
            Console.SetCursorPosition(12, 9);
            Console.WriteLine(" ");
            foreach (Egg item in listEgg)
            {
                item.readPosition(3);
            }
        }
        public void moveS(Egg[] listEgg)
        {
            Console.SetCursorPosition(4, 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(12, 4);
            Console.WriteLine(" ");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine(" ");
            Console.SetCursorPosition(12, 9);
            Console.WriteLine("U");
            foreach (Egg item in listEgg)
            {
                item.readPosition(4);
            }
        }

        public void createField()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(1, 2);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(14, 3);

            Console.WriteLine(@"/");
            Console.SetCursorPosition(15, 2);
            Console.WriteLine(@"/");
            Console.SetCursorPosition(16, 1);
            Console.WriteLine(@"/");
            Console.SetCursorPosition(0, 6);

            Console.WriteLine(@"\");
            Console.SetCursorPosition(1, 7);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine(@"\");
            Console.SetCursorPosition(14, 8);

            Console.WriteLine(@"/");
            Console.SetCursorPosition(15, 7);
            Console.WriteLine(@"/");
            Console.SetCursorPosition(16, 6);
            Console.WriteLine(@"/");

            Console.SetCursorPosition(0, 12);
            Console.WriteLine("Score:");
            Console.SetCursorPosition(2, 13);
            Console.WriteLine(0);
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("loses:");
            Console.SetCursorPosition(12, 13);
            Console.WriteLine(0);

        }

        public void createList(out Egg[] list)
        {
            list = new Egg[4];
            for (int i = 1; i < 5; i++)
            {
                list[i-1] = new Egg(i);
            }
        }
       

    }
}
