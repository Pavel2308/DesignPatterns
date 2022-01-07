using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Products
{
    public class Outerwear : Product
    {
        public Outerwear(string fabric, string size)
            : base("Верхняя одежда", fabric, size)
        {
        }
    }
}
