using System;

namespace game_checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Move(int oldIJ, int newIJ, int[,] oldBoard, out int[,] newBoard)
            {
                int oldI, oldJ, newI, newJ;
                oldI = Math.DivRem(oldIJ-1, 8, out oldJ);
                newI = Math.DivRem(newIJ-1, 8, out newJ);
                newBoard = oldBoard;
                newBoard[newI, newJ] = oldBoard[oldI, oldJ];
                newBoard[oldI, oldJ] = 0;
            }
            int lenght = 8;
            ConsoleColor color;
            int[,] chessBoard = { {1, -1, 2, -1, 3, -1, 4, -1},
                                  {-1, 5, -1, 6, -1, 7, -1, 8},
                                  {9, -1, 10, -1, 11, -1, 12, -1},
                                  {-1, 0, -1, 0, -1, 0, -1, 0},
                                  {0, -1, 0, -1, 0, -1, 0, -1},
                                  {-1, 13, -1, 14, -1, 15, -1, 16},
                                  {17, -1, 18, -1, 19, -1, 20, -1},
                                  {-1, 21, -1, 22, -1, 23, -1, 24} };
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            while (true)
            {
                for (int i = 0; i < lenght; i++)
                {
                    for (int j = 0; j < lenght; j++)
                    {

                        color = ((i + j) % 2 != 0) ? ConsoleColor.White : ConsoleColor.Black;
                        Console.BackgroundColor = color;
                        if (chessBoard[i, j] != 0 && chessBoard[i, j] != -1)
                        {
                            string chess = (chessBoard[i, j] > 12) ? "2" : "1";
                            Console.Write($" {chess} ");
                        }
                        else
                            Console.Write("   ");
                        Console.ResetColor();

                    }
                    Console.WriteLine();
                }
                int oldIJ = Convert.ToInt32( Console.ReadLine());
                int newIJ = Convert.ToInt32(Console.ReadLine());
                Move(oldIJ, newIJ, chessBoard, out chessBoard);
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
            }
            Console.ReadKey();


            /*
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue") ;
            Console.ResetColor();
            */
        }
    }
}
