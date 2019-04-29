using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface Iicecream
    {
        void show();
    }

    class Icecream : Iicecream
    {
        private string name;
        public Icecream(string name)
        {
            this.name = name;
        }
        public void show()
        {
            Console.WriteLine("的{0}", name);
        }
    }
    abstract class Decorator : Iicecream
    {
        protected Iicecream component;
        public void Decorate(Iicecream component)
        {
            this.component = component;
        }
        public abstract void show();
        
    }

    class OreoCookies : Decorator
    {
        public override void show()
        {
            Console.Write("奥利奥");
            component.show();
        }
    }
    class Almond : Decorator
    {
        public override void show()
        {
            Console.Write("杏仁");
            component.show();
            
        }
    }
    class Casthews : Decorator
    {
        public override void show()
        {
            Console.Write("腰果");
            component.show();
        }
    }
    class Pecan : Decorator
    {
        public override void show()
        {
            Console.Write("核桃");
            component.show();
        }
    }
    class Raisin:Decorator
    {
        public override void show()
        {
            Console.Write("葡萄干");
            component.show();
        }
    }
    class ChocolateChip:Decorator
    {
        public override void show()
        {
            Console.Write("巧克力");
            component.show();
        }
    }
    class Strawberry:Decorator
    {
        public override void show()
        {
            Console.Write("果酱");
            component.show();
        }
    }

}

