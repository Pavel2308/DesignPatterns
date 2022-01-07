using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Products
{
    public abstract class Product
    {
        public readonly string Name;
        public readonly string Fabric;
        public readonly string Size;
        public Product(string name, string fabric, string size)
        {
            Name = name;
            Fabric = fabric;
            Size = size;
        }
    }
}
