using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Classes
{
    public class Point
    {
        public int X { get; }

        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }

            var other = (Point) obj;

            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            return new Tuple<int, int>(X, Y).GetHashCode();
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
    }
}
