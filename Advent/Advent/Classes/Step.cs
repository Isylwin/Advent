using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Advent.Classes
{
    public class Step
    {
        public Direction Direction { get; }

        public int Distance { get; }

        public Step(string arg)
        {
            Direction = DirectionExt.ParseString(arg);
            Distance = Convert.ToInt32(arg.Substring(1));
        }

        public static List<Step> GetStepsFromString(string arg)
        {
            var ret = new List<Step>();

            var tokens = arg.Replace(" ", "").Split(',');
            tokens.ToList().ConvertAll(x => new Step(x)).ForEach(ret.Add);

            return ret;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Step))
            {
                return false;
            }

            var other = (Step) obj;

            return other.Direction == Direction && other.Distance == Distance;
        }
    }
}
