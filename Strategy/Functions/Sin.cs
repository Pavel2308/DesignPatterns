using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Functions
{
    class Sin : IFunction
    {
        public double Operation(double x)
        {
            return Math.Sin(x);
        }
        public string GetFunctionName()
        {
            return "sin(x)";
        }
    }
}
