using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car : IDrawable, IMoveable, IRidable
    {
        public Car(string mark, ConsoleColor color)
        {
            Mark = mark;
            Color = color;
        }

        public string Mark;
        public string Image = "   ####   \n" +
                              "  #    #  \n" +
                              "##      ##\n" +
                              "#  #   # #\n" +
                              "  #   # ";
        public ConsoleColor Color;

        public Vector2 Position = new Vector2();

        public void Draw()
        {
            ConsoleColor oldfg = Console.ForegroundColor;

            Console.ForegroundColor = Color;
            for (int i = 0; i < Position.Y - 2; i++)
                Console.WriteLine();

            for (int i = 0; i < Position.X; i++)
                Console.Write("  ");

            Console.WriteLine("        " + Mark + '\n');

            foreach (string line in Image.Split('\n'))
            {
                for (int i = 0; i < Position.X; i++)
                    Console.Write("  ");

                foreach (char c in line)
                    Console.Write($"{c}{c}");
                Console.WriteLine();
            }

            Console.ForegroundColor = oldfg;
        }

        public void Ride()
        {
            string[] lines;
            lines = Image.Split('\n');

            string last = lines.Last();
            string prelast = lines[lines.Length-2];

            if (last == "  #   # ")
                last = "   #   #";
            else
                last = "  #   # ";

            if (prelast == "#  #   # #")
                prelast = "# #   #  #";
            else
                prelast = "#  #   # #";

            lines[lines.Length - 1] = last;
            lines[lines.Length - 2] = prelast;

            Image = string.Join("\n", lines);
        }

        public void Move(int x, int y)
        {
            Position.X += x;
            Position.Y += y;
        }

        public void Move(Vector2 v)
        {
            Position.X += v.X;
            Position.Y += v.Y;
        }

        public void MoveTo(int x, int y)
        {
            Position.X = x;
            Position.Y = y;
        }

        public void MoveTo(Vector2 v)
        {
            Position.X = v.X;
            Position.Y = v.Y;
        }
    }
}
