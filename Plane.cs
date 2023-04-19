using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_Practice_Inheritance
{
    internal class Plane : Air
    {
        int _numberOfJets;

        public Plane(string color, int numberOfJets) : base(color)
        {
            _numberOfJets = numberOfJets;
        }

        public int NumberOfJets { get => _numberOfJets; set => _numberOfJets = value; }
        public override string ToString()
        {
            return base.ToString() + $"- Number of Jets {_numberOfJets}";
        }
    }
}
