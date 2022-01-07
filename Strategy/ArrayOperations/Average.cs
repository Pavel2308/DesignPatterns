using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ArrayOperations
{
    public class Average : IArrayOperation
    {
        public double ExecuteOperation(int[] array)
        {
            return array.Average();
        }
        public string GetOperationName()
        {
            return "Average";
        }
    }
}
