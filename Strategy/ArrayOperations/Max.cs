using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ArrayOperations
{
    public class Max : IArrayOperation
    {
        public double ExecuteOperation(int[] array)
        {
            return array.Max();
        }
        public string GetOperationName()
        {
            return "Max";
        }
    }
}
