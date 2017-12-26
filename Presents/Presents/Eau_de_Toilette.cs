using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presents
{
    public class Eau_de_Toilette : Product
    {
        public string Perfume { get; private set; }

        public Eau_de_Toilette(string name, int price, string perfume)
        {
            Name = name;
            Price = price;
            Perfume = perfume;
        }
    }
}
