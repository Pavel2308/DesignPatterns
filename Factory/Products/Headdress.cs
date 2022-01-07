using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Products
{
    public class Headdress : Product
    {
        public Headdress(string fabric, string size)
            : base("Головной убор", fabric, size)
        {
        }
    }
}
