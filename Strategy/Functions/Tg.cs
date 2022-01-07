using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Functions
{
    public class Tg : IFunction
    {
        public double Operation(double x)
        {
            return Math.Tan(x);
        }
        public string GetFunctionName()
        {
            return "tg(x)";
        }
    }
}
