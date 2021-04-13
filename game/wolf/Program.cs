using System;
using System.Threading;
using System.Threading.Tasks;


namespace wolf
{
    class Program
    {
        static int score = 0;
        static int looses = 0;
        
        static Random rand = new Random();
        static GameFuncion funcion = new GameFuncion();
        static Egg[] listEgg = new Egg[4];
        static void winLooses()
        {
            while (true)
            {


                int scoreNew = 0;
                int loosesNew = 0;
                foreach (Egg item in listEgg)
                {
                    scoreNew += item.score;
                    loosesNew += item.looses;
                }
                if (loosesNew != looses)
                {
                    Console.SetCursorPosition(12, 13);
                    Console.WriteLine(loosesNew);
                    if (loosesNew == 3)
                    {
                        Environment.Exit(0);
                    }
                    looses = loosesNew;
                }
                if (scoreNew != score)
                {
                    score = scoreNew;
                    Console.SetCursorPosition(2, 13);
                    Console.WriteLine(score);
                }
                Thread.Sleep(100);
            }

        }
        static void test()
        {

            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Q:
                        funcion.moveQ(listEgg);
                        break;
                    case ConsoleKey.W:
                        funcion.moveW(listEgg);
                        break;
                    case ConsoleKey.A:
                        funcion.moveA(listEgg);
                        break;
                    case ConsoleKey.S:
                        funcion.moveS(listEgg);
                        break;
                    default:
                        break;
                }


            }
        }

        static void Main(string[] args)
        {

            funcion.createField();
            funcion.createList(out listEgg);
            Action action1 = new Action(test);
            Task task1 = new Task(action1);
            task1.Start();

            Action action2 = new Action(winLooses);
            Task task2 = new Task(action2);
            task2.Start();


            Console.SetCursorPosition(0, 9);
            while (true)
            {
                foreach (Egg item in listEgg)
                {
                    Action action3 = new Action(item.createEgg);
                    Task task3 = new Task(action3);
                    task3.Start();
                    Thread.Sleep(rand.Next(1200, 1999));
                }
            }

        }
    }
}
