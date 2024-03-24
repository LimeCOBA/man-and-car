using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey? Key = null;
            Console.CursorVisible = false;
            ConsoleColor oldfg = Console.ForegroundColor;

            bool flag = true;

            while (true)
            {
                if (flag)
                {
                    Human h1 = new Human("Andrew");
                    h1.Move(5, 3);
                    Key = null;

                    do
                    {
                        switch (Key)
                        {
                            case ConsoleKey.W:
                                h1.Move(0, -1);
                                h1.Step();
                                break;
                            case ConsoleKey.A:
                                h1.Move(-1, 0);
                                h1.Step();
                                break;
                            case ConsoleKey.S:
                                h1.Move(0, 1);
                                h1.Step();
                                break;
                            case ConsoleKey.D:
                                h1.Move(1, 0);
                                h1.Step();
                                break;
                        }

                        Console.Clear();
                        Console.ForegroundColor = oldfg;

                        //Отрисовывание humanа
                        h1.Draw();

                        oldfg = Console.ForegroundColor;
                        Console.ForegroundColor = Console.BackgroundColor;
                    } while ((Key = Console.ReadKey().Key) != ConsoleKey.Escape);

                    Console.Clear();
                }
                else
                {

                    Car c1 = new Car("BMW", ConsoleColor.Cyan);
                    c1.Move(2, 1);
                    Key = null;

                    do
                    {
                        switch (Key)
                        {
                            case ConsoleKey.W:
                                c1.Move(0, -1);
                                c1.Ride();
                                break;
                            case ConsoleKey.A:
                                c1.Move(-1, 0);
                                c1.Ride();
                                break;
                            case ConsoleKey.S:
                                c1.Move(0, 1);
                                c1.Ride();
                                break;
                            case ConsoleKey.D:
                                c1.Move(1, 0);
                                c1.Ride();
                                break;
                        }

                        Console.Clear();
                        Console.ForegroundColor = oldfg;

                        //Отрисовывание humanа
                        c1.Draw();

                        oldfg = Console.ForegroundColor;
                        Console.ForegroundColor = Console.BackgroundColor;
                    } while ((Key = Console.ReadKey().Key) != ConsoleKey.Escape);
                }
                flag = !flag;
            }            
        }
    }
}