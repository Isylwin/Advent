using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SolvePart1(Input.ReadString());

            SolvePart2(Input.ReadString());

            Console.ReadKey();
        }

        public static void SolvePart1(string inputString)
        {
            var inputs = inputString.Split('\n');
            var outputs = new List<string>();

            foreach (var input in inputs)
            {
                var splitInput = input.Trim().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var a = Convert.ToInt32(splitInput[0]);
                var b = Convert.ToInt32(splitInput[1]);
                var c = Convert.ToInt32(splitInput[2]);

                if (a + b > c && b + c > a && a + c > b)
                    outputs.Add(input + "\n");
            }

            Console.WriteLine($"Amount of valid triangles: {outputs.Count}");
        }

        public static void SolvePart2(string inputString)
        {
            string[] inputLines = inputString.Split('\n');
            var temp = new List<string[]>();
            var count = 0;

            inputLines.ToList()
                .ForEach(x => temp.Add(x.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)));

            var inputs = temp.ToArray();

            for (int i = 0; i < inputs.Length - 2; i += 3)
            {
                for (int j = 0; j < inputs[i].Length; j++)
                {
                    var a = Convert.ToInt32(inputs[i][j]);
                    var b = Convert.ToInt32(inputs[i+1][j]);
                    var c = Convert.ToInt32(inputs[i+2][j]);

                    if (a + b > c && b + c > a && a + c > b)
                        count++;
                }
            }

            Console.WriteLine($"Amount of valid triangles: {count}");
        }
    }
}
