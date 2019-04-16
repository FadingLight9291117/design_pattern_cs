using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto;
            AutoBulider bulider = new BenZBulider();
            Director director = new Director(bulider);
            director.Construct();
            auto = bulider.GetResult();
            auto.Introduce();
        }
    }
}
