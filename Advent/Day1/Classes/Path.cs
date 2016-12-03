using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent.Classes
{
    public class Path
    {
        private Heading _heading;

        public Point Start { get; }

        public Point End { get; private set; }

        public List<Point> Nodes { get; }

        public List<Point> Duplicated => Nodes.GroupBy(x => x).SelectMany(x => x.Skip(1)).Distinct().ToList();

        public Path(List<Step> steps)
        {
            Start = new Point(0, 0);
            End = Start;
            Nodes = new List<Point> {End};

            steps.ForEach(Move);
        }

        private void Move(Step step)
        {
            ChangeHeading(step.Direction);

            var currentX = End.X;
            var currentY = End.Y;

            for (var i = 0; i < step.Distance; i++)
            {
                switch (_heading)
                {
                    case Heading.North:
                        currentY++;
                        break;
                    case Heading.East:
                        currentX++;
                        break;
                    case Heading.South:
                        currentY--;
                        break;
                    case Heading.West:
                        currentX--;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                var next = new Point(currentX, currentY);

                Nodes.Add(next);
                End = next;
            }        
        }

        private void ChangeHeading(Direction dir)
        {
            var current = (int) _heading;
            var next = (current + (int) dir) % Enum.GetNames(typeof (Heading)).Length;
            _heading = next == -1 ? Heading.West : (Heading) next;
        }

        public void Print()
        {
            var dup = Duplicated.First();

            Console.WriteLine($"The end point is at {End}.");
            Console.WriteLine($"The distance is {Start.Distance(End)}.");

            Console.WriteLine($"The first duplicated point is at {dup}.");
            Console.WriteLine($"The distance to the first duplicated point is {Start.Distance(dup)}");
        }

        private enum Heading
        {
            North = 0,
            East = 1,
            South = 2,
            West = 3
        }
    }
}
