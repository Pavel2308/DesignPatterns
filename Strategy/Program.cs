using Strategy.ArrayOperations;
using Strategy.Functions;
using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy
{
    class Program
    {
        static int[] GetRandomArray()
        {
            const int MinArrayLength = 5;
            const int MaxArrayLength = 30;
            const int MinArrayItemValue = 1;
            const int MaxArrayItemValue = 5;
            var rnd = new System.Random();
            var array = new int[rnd.Next(MinArrayLength, MaxArrayLength+1)];
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(MinArrayItemValue, MaxArrayItemValue+1);
            return array;
        }

        static void ArrayOperationsTest()
        {
            System.Console.WriteLine("Array operations test:");

            var array = new Array(GetRandomArray(), new Max());
            System.Console.WriteLine($"Array: {array.ToString()}");
            System.Console.WriteLine($"Result of an array operation {array.GetOperationName()}: {array.ExecuteOperation()}");

            array.SetArrayOperation(new Min());
            System.Console.WriteLine($"Result of an array operation {array.GetOperationName()}: {array.ExecuteOperation()}");

            array.SetArrayOperation(new Average());
            System.Console.WriteLine($"Result of an array operation {array.GetOperationName()}: {array.ExecuteOperation()}");

            array.SetArrayOperation(new MostCommon());
            System.Console.WriteLine($"Result of an array operation {array.GetOperationName()}: {array.ExecuteOperation()}");

            System.Console.WriteLine();
        }
        static void FunctionsTest()
        {
            double x = 4;
            System.Console.WriteLine("Functions test:");

            var number = new Number(x, new Square());
            System.Console.WriteLine($"x: {number.ToString()}");
            System.Console.WriteLine($"Result of function {number.GetFunctionName()}: {number.ExecuteOperation()}");

            number.SetFunction(new Plus());
            System.Console.WriteLine($"Result of function {number.GetFunctionName()}: {number.ExecuteOperation()}");

            number.SetFunction(new Sqrt());
            System.Console.WriteLine($"Result of function {number.GetFunctionName()}: {number.ExecuteOperation()}");

            number.SetFunction(new Sin());
            System.Console.WriteLine($"Result of function {number.GetFunctionName()}: {number.ExecuteOperation()}");

            number.SetFunction(new Tg());
            System.Console.WriteLine($"Result of function {number.GetFunctionName()}: {number.ExecuteOperation()}");

            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            FunctionsTest();
            ArrayOperationsTest();
        }
    }
}
