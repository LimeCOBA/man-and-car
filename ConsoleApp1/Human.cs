using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Human : IDrawable, IMoveable, IStepable
    {
        public Human(string fio)
        {
            FIO = fio;
        }

        public int Age;
        public string FIO;
        public string Image = " # \n" +
                              "# #\n" +
                              " # \n" +
                              "###\n" +
                              " # \n" +
                              " # \n" +
                              "# #";

        public Vector2 Position = new Vector2();

        public void Draw()
        {
            for (int i = 0; i < Position.Y - 2; i++)
                Console.WriteLine();

            for (int i = 0; i < Position.X; i++)
                Console.Write("  ");

            Console.WriteLine(FIO + '\n');

            foreach (string line in Image.Split('\n'))
            {
                for (int i = 0; i < Position.X; i++)
                    Console.Write("  ");

                foreach(char c in line)
                    Console.Write($"{c}{c}");
                Console.WriteLine();
            }
        }

        public void Step()
        {
            string[] lines;
            lines = Image.Split('\n');

            string last = lines.Last();

            last = last.Replace(' ', '1');
            last = last.Replace('#', ' ');
            last = last.Replace('1', '#');

            lines[lines.Length - 1] = last;

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
