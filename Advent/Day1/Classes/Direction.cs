using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent.Classes
{
    public enum Direction
    {
        Left = -1, Right = 1
    }

    public static class DirectionExt
    {
        public static Direction ParseString(string arg)
        {
            return arg.StartsWith("R") ? Direction.Right : Direction.Left;
        }
    }
}
