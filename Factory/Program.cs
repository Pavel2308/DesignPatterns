using System;
using Factory.Factories;
using Factory.Products;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseFactory factory = new FootwearFactory();
            Product product = factory.Make("Кожа", "42");

            factory = new HeaddressFactory();
            product = factory.Make("Хлопок", "S");

            factory = new OuterwearFactory();
            product = factory.Make("Полиэстер", "M");
        }
    }
}
