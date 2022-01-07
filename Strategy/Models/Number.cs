using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    public class Number
    {
        double _number { get; set; }
        IFunction _function { get; set; }
        public Number(double number, IFunction function)
        {
            _number = number;
            _function = function;
        }
        public void SetFunction(IFunction function)
        {
            _function = function;
        }
        public double ExecuteOperation()
        {
            return _function.Operation(_number);
        }
        public string GetFunctionName()
        {
            return _function.GetFunctionName();
        }
        public override string ToString()
        {
            return _number.ToString();
        }
    }
}
