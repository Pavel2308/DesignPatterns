using System;
using TemplateMethod.Cars;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new PassengerСar("23", "BMW", 200);
            Console.WriteLine(car.GetDescription());

            car = new Truck("24", "MAN", 2500);
            Console.WriteLine(car.GetDescription());

            car = new PublicTransport("100", "ПАЗ", 20);
            Console.WriteLine(car.GetDescription());
        }
    }
}
