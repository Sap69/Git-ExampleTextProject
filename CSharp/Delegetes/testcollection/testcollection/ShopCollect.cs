using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testcollection
{
    public class ShopCollect :IEnumerable<Products>
    {
        public IEnumerable<Products> Product { get; set; }


        public IEnumerator<Products> GetEnumerator()
        {
            return Product.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
     


    }
    public static class MyExtMetods
    {
        public static IEnumerable<Products> Filter(this IEnumerable<Products> enumProd, Func<Products, bool> selector)
        {
            foreach (Products _prod in enumProd)
            {
                if (selector(_prod))
                {
                    yield return _prod;
                }
            }
        }
        public static decimal TotalPrice(this IEnumerable<Products> _prod)
        {
            decimal total = 0;
            foreach (Products _p in _prod)
            {
                total += _p?.Price ?? 0;
            }
            return total;
        }
        public static Products ValPrice(this IEnumerable<Products> _prod)
        {
            Products total=null;
            foreach (Products _p in _prod)
            {
                total = _p;
            }
            return total;
        }
    }
}
