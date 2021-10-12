using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameInterfaces
{
    public class Building : IHasValue
    {
        public float Value => 100;
        private string type;
        private float area;

        public Building(string type, float area)
        {
            this.type = type;
            this.area = area;
        }

        public override string ToString()
        {
            return $"{type,-20},{Value,8:f2},{area,8:f2}";
        }

        public bool Equals(IHasValue other)
        {
            if (other == null) return false;
            return Value == other.Value; 
        } 
    }
}