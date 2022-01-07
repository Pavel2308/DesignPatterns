using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Products
{
    public class Footwear: Product 
    {
        public Footwear(string fabric, string size)
            :base("Обувь", fabric,size)
        {
        }
    }
}
