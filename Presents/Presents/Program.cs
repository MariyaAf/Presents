using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presents
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            User user = new User(
                       "Петр",
                       1000,
                       500
                   );
            Socks Henderson = new Socks(
               "Henderson",
               100,
               "wool"
           );
            Socks Gamma = new Socks(
               "Gamma",
               50,
               "cotton"
           );
            Socks Folk = new Socks(
               "Folk",
               95,
               "cotton"
           );
            Console.WriteLine("Носки");
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Henderson.Name);
            Console.WriteLine("Цена: " + Henderson.Price);
            Console.WriteLine("Материал: " + Henderson.Material);
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Gamma.Name);
            Console.WriteLine("Цена: " + Gamma.Price);
            Console.WriteLine("Материал: " + Gamma.Material);
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Folk.Name);
            Console.WriteLine("Цена: " + Folk.Price);
            Console.WriteLine("Материал: " + Folk.Material);
            Console.WriteLine(new String('-', 25));
            Shampoo Oriflame = new Shampoo(
               "Oriflame",
               500,
               "ForNormalHair"
           );
            Shampoo Sensens = new Shampoo(
               "Sensens",
               350,
               "ForAridHair"
           );
            Shampoo Estel = new Shampoo(
               "Estel",
               390,
               "ForAridHair"
           );
            Console.WriteLine("Шампунь");
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Oriflame.Name);
            Console.WriteLine("Цена: " + Oriflame.Price);
            Console.WriteLine("Вид: " + Oriflame.Kind);
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Sensens.Name);
            Console.WriteLine("Цена: " + Sensens.Price);
            Console.WriteLine("Вид: " + Sensens.Kind);
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Estel.Name);
            Console.WriteLine("Цена: " + Estel.Price);
            Console.WriteLine("Вид: " + Estel.Kind);
            Console.WriteLine(new String('-', 25));

            Slippers Halluci = new Slippers(
               "Halluci",
               700,
               40
           );
            Slippers Gucci = new Slippers(
                   "Gucci",
                   1500,
                   42
               );
            Slippers Rapana = new Slippers(
                   "Rapana",
                   900,
                   42
               );

            Console.WriteLine("Тапочки");
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Halluci.Name);
            Console.WriteLine("Цена: " + Halluci.Price);
            Console.WriteLine("Вид: " + Halluci.Size);
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Gucci.Name);
            Console.WriteLine("Цена: " + Gucci.Price);
            Console.WriteLine("Вид: " + Gucci.Size);
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Rapana.Name);
            Console.WriteLine("Цена: " + Rapana.Price);
            Console.WriteLine("Вид: " + Rapana.Size);
            Console.WriteLine(new String('-', 25));

            Eau_de_Toilette Dior = new Eau_de_Toilette(
                   "Dior",
                   1000,
                   "Цитрусовый"
               );
            Eau_de_Toilette Hermes = new Eau_de_Toilette(
                   "Hermes",
                   750,
                   "Древесный"
               );
            Eau_de_Toilette Cartier = new Eau_de_Toilette(
                   "Cartier",
                   890,
                   "Древесный"
               );
            Console.WriteLine("Туалетная вода");
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Dior.Name);
            Console.WriteLine("Цена: " + Dior.Price);
            Console.WriteLine("Вид: " + Dior.Perfume);
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Hermes.Name);
            Console.WriteLine("Цена: " + Hermes.Price);
            Console.WriteLine("Вид: " + Hermes.Perfume);
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Cartier.Name);
            Console.WriteLine("Цена: " + Cartier.Price);
            Console.WriteLine("Вид: " + Cartier.Perfume);
            Console.WriteLine(new String('-', 25));

            Casing Modis = new Casing(
                   "Modis",
                   900,
                   48
               );
            Casing Alcott = new Casing(
                   "Alcott",
                   1350,
                   50
               );
            Casing Gap = new Casing(
                   "Gap",
                   1290,
                   48
               );
            Console.WriteLine("Рубашки");
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Modis.Name);
            Console.WriteLine("Цена: " + Modis.Price);
            Console.WriteLine("Вид: " + Modis.Size);
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Alcott.Name);
            Console.WriteLine("Цена: " + Alcott.Price);
            Console.WriteLine("Вид: " + Alcott.Size);
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("Название: " + Gap.Name);
            Console.WriteLine("Цена: " + Gap.Price);
            Console.WriteLine("Вид: " + Gap.Size);
            Console.WriteLine(new String('-', 25));

            while (true)
            {
                Console.WriteLine("Выберите нужный товар");
                Console.WriteLine("1.  Шампунь");
                Console.WriteLine("2.  Тапки");
                Console.WriteLine("3.  Носки");
                Console.WriteLine("4.  Туалетная вода");
                Console.WriteLine("5.  Рубашка");
                Informer informer = new Informer();

                string number = Console.ReadLine();
                int productNumber = Convert.ToInt32(number);
                if (productNumber > 0 && productNumber <= 5)
                {
                    if (productNumber == 1)
                    {

                        Product[] products = new Product[]
                        {
                    Oriflame, Sensens, Estel
                        };
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"Шапунь{i} {products[i].Name} по цене {products[i].Price}");
                        }
                        Console.WriteLine("Выберите шампунь");
                        string str = Console.ReadLine();
                        int ShampooNumber = Convert.ToInt32(str);
                        if (ShampooNumber >= 0 && ShampooNumber < products.Length)
                        {
                            if (products[productNumber].Price < user.Balance)
                            {
                                informer.Buy(user, products[productNumber]);
                            }
                            else
                            {
                                Console.WriteLine("У вас недостаточно средств");
                            }
                        }

                    }

                    if (productNumber == 2)
                    {

                        Product[] products = new Product[]
                        {
                    Halluci, Gucci, Rapana
                        };
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"Тапки{i} {products[i].Name} по цене {products[i].Price}");
                        }
                        Console.WriteLine("Выберите тапки");
                        string str = Console.ReadLine();
                        int SlipperNumber = Convert.ToInt32(str);
                        if (SlipperNumber >= 0 && SlipperNumber < products.Length)
                        {
                            if (products[productNumber].Price < user.Balance)
                            {
                                informer.Buy(user, products[productNumber]);
                            }
                            else
                            {
                                Console.WriteLine("У вас недостаточно средств");
                            }
                        }

                    }

                    if (productNumber == 3)
                    {

                        Product[] products = new Product[]
                        {
                    Henderson, Gamma, Folk
                        };
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"Носки {i} {products[i].Name} по цене {products[i].Price}");
                        }
                        Console.WriteLine("Выберите носки");
                        string str = Console.ReadLine();
                        int SocksNumber = Convert.ToInt32(str);
                        if (SocksNumber >= 0 && SocksNumber < products.Length)
                        {
                            if (products[productNumber].Price < user.Balance)
                            {
                                informer.Buy(user, products[productNumber]);
                            }
                            else
                            {
                                Console.WriteLine("У вас недостаточно средств");
                            }
                        }

                    }
                    if (productNumber == 4)
                    {

                        Product[] products = new Product[]
                        {
                    Dior, Hermes, Cartier
                        };
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"Туалетная вода {i} {products[i].Name} по цене {products[i].Price}");
                        }
                        Console.WriteLine("Выберите туалетную воду");
                        string str = Console.ReadLine();
                        int WaterNumber = Convert.ToInt32(str);
                        if (WaterNumber >= 0 && WaterNumber < products.Length)
                        {
                            if (products[productNumber].Price < user.Balance)
                            {
                                informer.Buy(user, products[productNumber]);
                            }
                            else
                            {
                                Console.WriteLine("У вас недостаточно средств");
                            }
                        }

                    }
                    if (productNumber == 5)
                    {

                        Product[] products = new Product[]
                        {
                    Modis, Alcott, Gap
                        };
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"Рубашка {i} {products[i].Name} по цене {products[i].Price}");
                        }
                        Console.WriteLine("Выберите рубашку");
                        string str = Console.ReadLine();
                        int CasingNumber = Convert.ToInt32(str);
                        if (CasingNumber >= 0 && CasingNumber < products.Length)
                        {
                            if (products[productNumber].Price < user.Balance)
                            {
                                informer.Buy(user, products[productNumber]);
                            }
                            else
                            {
                                Console.WriteLine("У вас недостаточно средств");
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Такого продукта не существует");
                }
            }
        }



    }
}
