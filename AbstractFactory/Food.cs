using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface Hamburg
    {
        void eatIt();
    }
    interface Cola
    {
        void drinkIt();
    }
    class McDonaldsHamburg : Hamburg
    {
        public void eatIt()
        {
            Console.WriteLine("吃了一个麦当劳的汉堡");
        }
    }
    class KFCHamburg : Hamburg
    {
        public void eatIt()
        {
            Console.WriteLine("吃了一个肯德基的汉堡");
        }
    }
    class McDonaldCola : Cola
    {
        public void drinkIt()
        {
            Console.WriteLine("喝了一杯麦当劳的可乐");
        }
    }
    class KFCCola : Cola
    {
        public void drinkIt()
        {
            Console.WriteLine("喝了一杯肯德基的可乐");
        }
    }
}