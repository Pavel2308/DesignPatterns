using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.ArrayOperations
{
    public class MostCommon : IArrayOperation
    {
        public double ExecuteOperation(int[] array)
        {
            var dictionaryGroups = array.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            return dictionaryGroups.FirstOrDefault(x => x.Value == dictionaryGroups.Values.Max()).Key;
        }
        public string GetOperationName()
        {
            return "MostCommon";
        }
    }
}
