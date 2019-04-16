using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface CoffeeSize
    {
        void Sale();
    }

    class JorumCoffee : CoffeeSize
    {
        private Recipe recipe;
        public JorumCoffee(Recipe recipe)
        {
            this.recipe = recipe;
        }
        public void Sale()
        {
            Console.WriteLine("大杯咖啡+" + recipe.Add());
        }
    }
    class MediumCoffee : CoffeeSize
    {
        private Recipe recipe;
        public MediumCoffee(Recipe recipe)
        {
            this.recipe = recipe;
        }
        public void Sale()
        {
            Console.WriteLine("中杯咖啡+" + recipe.Add());
        }
    }
    class SmallCofee : CoffeeSize
    {
        private Recipe recipe;
        public SmallCofee(Recipe recipe)
        {
            this.recipe = recipe;
        }
        public void Sale()
        {
            Console.WriteLine("小杯咖啡+" + recipe.Add());
        }
    }
}
