using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Classes
{
    public class Node
    {
        public string Value { get; }

        public Node(string value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Node))
                return false;

            var other = (Node) obj;

            return other.Value == Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
