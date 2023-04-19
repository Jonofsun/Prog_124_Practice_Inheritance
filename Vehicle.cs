using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Practice_Inheritance
{
    public class Vehicle
    {
        string _color;

        public Vehicle(string color)
        {
            _color = color;
        }

        public string Color { get => _color; set => _color = value; }
        public override string ToString()
        {
            return $"{this.GetType()} - {Color}";
        }
    }
}
