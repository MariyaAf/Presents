using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presents
{
    public class Socks : Product
    {
        public string Material { get; private set; }

        public Socks(string name, int price, string material)
        {
            Name = name;
            Price = price;
            Material = material;
        }
        public override double GetDiscountPrice(User user)
        {
            if (Material == "wool")
            {
                return Price * 0.3;
            }
            else
            {
                return Price;
            }
        }
    }
}
