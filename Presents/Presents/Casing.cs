using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presents
{
    public class Casing : Product
    {
        public int Size { get; private set; }

        public Casing(string name, int price, int size)
        {
            Name = name;
            Price = price;
            Size = size;
        }


    }
}
