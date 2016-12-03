using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day2.Classes;

namespace Day2Test
{
    public class TestUtil
    {
        public static Point MakePoint_WithXAndY(int x, int y)
        {
            return new Point(x, y);
        }

        public static Node MakeNode_WithString(string value)
        {
            return new Node(value);
        }

        public static Direction MakeDirection_WithString(char value)
        {
            return new Direction(value);
        }

        public static Graph MakeGraph_WithListOfTuples(List<Tuple<int, int, string>> map)
        {
            return new Graph(map);
        }

        public static Graph MakeGraph_WithoutArgument()
        {
            var arg = new List<Tuple<int, int, string>>
            {
                new Tuple<int, int, string>(0, 0, "5"),
                new Tuple<int, int, string>(1, 0, "6"),
                new Tuple<int, int, string>(0, 1, "2"),
                new Tuple<int, int, string>(1, 1, "3")
            };

            return new Graph(arg);
        }

        public static Path MakePath_WithString(string path)
        {
            return new Path(path, MakeGraph_WithoutArgument());
        }
    }
}
