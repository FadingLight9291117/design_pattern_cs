using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Iicecream icecream = new Icecream("冰淇淋");
            Almond almond = new Almond();
            Raisin raisin = new Raisin();
            almond.Decorate(raisin);
            raisin.Decorate(icecream);
            almond.show();
        }
    }
}
