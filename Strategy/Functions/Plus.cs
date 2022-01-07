using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Functions
{
    public class Plus : IFunction
    {
        public double Operation(double x)
        {
            return 3*x + 5;
        }
        public string GetFunctionName()
        {
            return "3*x + 5";
        }
    }
}
