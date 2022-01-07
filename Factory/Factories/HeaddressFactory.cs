using Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    class HeaddressFactory : BaseFactory
    {
        public HeaddressFactory()
            : base("Фабрика по производству головных уборов")
        {

        }
        protected override Product CreateProduct(string fabric, string size)
        {
            return new Headdress(fabric, size);
        }
    }
}
