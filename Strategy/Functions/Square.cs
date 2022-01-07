using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Functions
{
    public class Square : IFunction
    {
        public double Operation(double x)
        {
            return x * x;
        }
        public string GetFunctionName()
        {
            return "x^2";
        }
    }
}
