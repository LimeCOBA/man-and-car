using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IMoveable
    {
        void Move(int x, int y);
        void Move(Vector2 v);
        void MoveTo(int x, int y);
        void MoveTo(Vector2 v);
    }
}
