using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presents
{
    public class Slippers : Product
    {
        public int Size { get; private set; }

        public Slippers(string name, int price, int size)
        {
            Name = name;
            Price = price;
            Size = Size;
        }
        public override double GetDiscountPrice(User user)
        {
            if (Name == "Gucci")
            {
                return Price * 0.9;
            }
            else
            {
                return Price;
            }
        }
    }
}
