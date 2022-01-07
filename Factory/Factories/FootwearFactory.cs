using Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public class FootwearFactory : BaseFactory
    {
        public FootwearFactory()
            : base("Обувная фабрика")
        {

        }
        protected override Product CreateProduct(string fabric, string size)
        {
            return new Footwear(fabric,size);
        }
    }
}
