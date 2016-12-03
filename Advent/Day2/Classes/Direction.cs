using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Classes
{
    public class Direction
    {
        private readonly Dictionary<char, Heading> _stringToHeading = new Dictionary<char, Heading>
        {
            {'R', Heading.Right},
            {'L', Heading.Left},
            {'U', Heading.Up},
            {'D', Heading.Down}
        };

        private readonly Dictionary<Heading, Point> _headingToPoint = new Dictionary<Heading, Point>
        {
            {Heading.Right, new Point(1, 0)},
            {Heading.Left, new Point(-1, 0)},
            {Heading.Up, new Point(0, 1)},
            {Heading.Down, new Point(0, -1)}
        };

        public Heading Heading { get; }

        public Point Translation => _headingToPoint[Heading];

        public Direction(char heading)
        {
            Heading = _stringToHeading[heading];
        }
    }

    public enum Heading
    {
        Left, Right, Up, Down
    }
}
