using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public class Array
    {
        int[] _array { get; set; }
        IArrayOperation _arrayOperation { get; set; }
        public Array(int[] array, IArrayOperation arrayOperation)
        {
            _array = array;
            _arrayOperation = arrayOperation;
        }
        public void SetArrayOperation(IArrayOperation arrayOperation)
        {
            _arrayOperation = arrayOperation;
        }
        public double ExecuteOperation()
        {
            return _arrayOperation.ExecuteOperation(_array);
        }
        public string GetOperationName()
        {
            return _arrayOperation.GetOperationName();
        }
        public override string ToString()
        {
            string arrayString ="{";
            foreach (var item in _array)
                arrayString += $"[{item}]";
            arrayString += "}";
            return arrayString;
        }
    }
}
