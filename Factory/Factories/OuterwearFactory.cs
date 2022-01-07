using Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    class OuterwearFactory : BaseFactory
    {
        public OuterwearFactory()
            : base("Фабрика по производству верхней одежды")
        {

        }
        protected override Product CreateProduct(string fabric, string size)
        {
            return new Outerwear(fabric, size);
        }
    }
}
