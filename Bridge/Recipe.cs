using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface Recipe
    {
        String Add();
    }
    class Milk : Recipe
    {
        public string Add()
        {
            return "牛奶";
        }
    }
    class Sugar : Recipe
    {
        public string Add()
        {
            return "糖";
        }
    }
    class Lemon : Recipe
    {
        public string Add()
        {
            return "柠檬";
        }
    }
}
