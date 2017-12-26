using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presents
{
    public class Informer
    {
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"Здравствуйте,{user.Name}. Вы купили {product.Name} за {price}.");
            Console.WriteLine($"Ваш баланс {user.Balance}");
        }
    }
}
