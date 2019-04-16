using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe milk = new Milk();
            CoffeeSize mediumCoffee = new MediumCoffee(milk);
            mediumCoffee.Sale();
            Recipe lemon = new Lemon();
            CoffeeSize jourumCoffee = new JorumCoffee(lemon);
            jourumCoffee.Sale();
        }
    }
}
