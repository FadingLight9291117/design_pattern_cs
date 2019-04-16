using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory= new AcerFactory();
            Product product = factory.getLaptop();
            string str = product.getLaptop();
            Console.WriteLine(str);
        }
    }
}
