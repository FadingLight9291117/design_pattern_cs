using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new McDonaldsFactory();
            Cola cola = factory.getCola();
            cola.drinkIt();
            Hamburg hamburg = factory.getHamburg();
            hamburg.eatIt();
        }
    }
}
