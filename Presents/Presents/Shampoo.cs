using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presents
{
    public class Shampoo : Product
    {
        public string Kind { get; private set; }
        public Shampoo(string name, int price, string kind)
        {
            Name = name;
            Price = price;
            Kind = kind;
        }
        public override double GetDiscountPrice(User user)
        {
            return Price * 0.5;
        }
    }
}
