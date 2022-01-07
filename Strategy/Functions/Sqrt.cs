using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Functions
{
    public class Sqrt : IFunction
    {
        public double Operation(double x)
        {
            return Math.Sqrt(x);
        }
        public string GetFunctionName()
        {
            return "sqrt(x)";
        }
    }
}
