using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractProduct product = new Product("面包", "10.0");
            InterfaceProductObserver observer = new ProductObserver("用户1");
            product.attach(observer);
            observer.Product = product;
            observer.Product.productState();
            product.Price = "12";
        }
    }
}
