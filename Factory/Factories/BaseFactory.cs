using Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public abstract class BaseFactory
    {
        readonly string _name;
        protected BaseFactory(string name)
        {
            _name = name;
        }
        public Product Make(string fabric, string size)
        {
            Product product = CreateProduct(fabric, size);
            WriteDescription(product);
            return product;
        }
        private void WriteDescription(Product product)
        {
            Console.WriteLine($"{_name} произвела \"{product.Name}\" из материала \"{product.Fabric}\" c размером \"{product.Size}\"");
        }
        protected abstract Product CreateProduct(string fabric, string size);
    }
}
