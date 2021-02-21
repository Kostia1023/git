using System.Threading;
using System;

namespace order_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            static void createAList(out int[,] newList)
            {
                Random rand = new Random();
                int[,] list = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        while (true)
                        {
                            int ran = rand.Next(0, 9);
                            bool t = false;
                            foreach (int item in list)
                            {
                                t = item == ran;
                                if (t)
                                    break;
                            }
                            if (!t)
                            {
                                list[i, j] = ran;
                                break;
                            }
                        }
                    }
                }
                newList = list;
            }

            static void showTableElement(int element, bool last = false)
            {
                Console.Clear();
                int[,] list = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

                if (!last)
                {
                    int i, j;
                    i = Math.DivRem(element, 3, out j);
                    list[i, j] = 1;
                }
                Console.WriteLine("---------");
                for (int i1 = 0; i1 < 3; i1++)
                {
                    for (int j1 = 0; j1 < 3; j1++)
                    {
                        Console.Write("|");
                        if (list[i1, j1] == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            Console.ResetColor();
                        }
                        else
                            Console.Write(" ");
                        Console.Write("|");
                    }
                    Console.WriteLine();
                    Console.WriteLine("---------");
                }
            }



            int[,] list = { { 10, 10, 10 }, { 10, 10, 10 }, { 10, 10, 10 } };
            while (true)
            {
                Console.WriteLine("Тренажер памяті\nПравила гри:\nПо черзі буде показано " +
                    "9 елементів таблиці (таблиця 3 на 3)\nВам потрібно запамятати порядок " +
                    "елементів і потім написати числа (через Enter) від 0 до 9 в такому порядку, " +
                    "в якому\nбули показані елменти таблиці\n" +
                    "Для початку гри нажміть любу клавішу");
                Console.ReadKey();
                createAList(out list);
                foreach (int item in list)
                {
                    Console.WriteLine(item);
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        showTableElement(list[i, j]);
                        Thread.Sleep(1200);
                    }
                }
                showTableElement(0, true);
                Console.WriteLine("Введіть який на вашу думку був порядок елемнтів");
                int[,] playerList = new int[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        playerList[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                int numberOfCorrect = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        numberOfCorrect += (playerList[i, j] == list[i, j] + 1) ? 1 : 0;
                    }
                }
                switch (numberOfCorrect)
                {
                    case 0:
                        Console.WriteLine($"Погано, ви запамятали {numberOfCorrect} з 9");
                        break;
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine($"Потрібно більше тренуватись, ви запамятали" +
                    $" {numberOfCorrect} з 9");
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine($"Не погано, ви запамятали {numberOfCorrect} з 9");
                        break;
                    case 7:
                    case 8:
                        Console.WriteLine($"Дуже добре, ви запамятали {numberOfCorrect} з 9");
                        break;
                    case 9:
                        Console.WriteLine($"У вас відмінна память, ви запамятали" +
                    $" {numberOfCorrect} з 9");
                        break;
                }
                Console.WriteLine("Чи бажаєте продовжити ? (Так/Нет)");
                //Я взяв "нет", а не "ні" бо проблема з буквою "і"
                string next = Console.ReadLine();
                if (next == "Нет" || next == "нет")
                {
                    Console.WriteLine("Дякую за гру!");
                    break;
                }
                else
                    if (next == "Так" || next == "так")
                {
                    Console.Clear();
                }
                else
                    Console.WriteLine("Гра автоматично завершена, бо було введено неправильний " +
                        "формат продовження");

            }
        }
    }
}
