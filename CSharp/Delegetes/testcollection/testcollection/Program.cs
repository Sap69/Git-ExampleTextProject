using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Products[] _prod = {
               new Products("Kayak", 12)
            , new Products("dress", 120)
            , new Products("Karress", 420)
            , new Products("pck", 2)};
            //ShopCollect _shop = new ShopCollect { Product = _prod };
            ShopCollect _shop = new ShopCollect();
            _shop.Product = _prod;

            decimal d1 = _prod
                .Filter( p => (p?.Price ?? 0) >= 20)
            .TotalPrice();
            decimal d2 = _prod
                .Filter(p => p?.Name[0] == 'K')
            .TotalPrice();
            //
            foreach (Products _p in _shop)
            {
                Console.WriteLine("{0} - {1}", _p.Name, _p.Price);
            }
            Console.WriteLine("Total1 {0} ", d1.ToString());
            Console.WriteLine("Total2 {0} ", d2.ToString());
            decimal max = 0;
            Products ProductsVal;
            ProductsVal = _prod
                .Filter(
                (p) =>
                {
                    if (p.Price > max)
                    {
                        max = p.Price;
                        return true;
                    }
                    return false;
                    
                })
                .ValPrice();
            Console.WriteLine("Val {0} Name{1}", ProductsVal.Price.ToString(), ProductsVal.Name);
            decimal min = max;
            ProductsVal = _prod
                .Filter(
                (p) =>
                {
                    if (p.Price < min)
                    {
                        min = p.Price;
                        return true;
                    }
                    return false;

                })
                .ValPrice();

            
            Console.WriteLine("Val {0} Name{1}", ProductsVal.Price.ToString(), ProductsVal.Name);
            Console.ReadKey();

           
        }
    }
}
