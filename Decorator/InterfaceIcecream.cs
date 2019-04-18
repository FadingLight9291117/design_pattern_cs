using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface InterfaceIcecream
    {
        void show();
    }

    class Icecream : InterfaceIcecream
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
    abstract class AbstractIcecreamDecorator : InterfaceIcecream
    {
        protected InterfaceIcecream component;
        public void Decorate(InterfaceIcecream component)
        {
            this.component = component;
        }
        public abstract void show();
        
    }

    class OreoCookies : AbstractIcecreamDecorator
    {
        public override void show()
        {
            Console.Write("奥利奥");
            component.show();
        }
    }
    class Almond : AbstractIcecreamDecorator
    {
        public override void show()
        {
            Console.Write("杏仁");
            component.show();
            
        }
    }
    class Casthews : AbstractIcecreamDecorator
    {
        public override void show()
        {
            Console.Write("腰果");
            component.show();
        }
    }
    class Pecan : AbstractIcecreamDecorator
    {
        public override void show()
        {
            Console.Write("核桃");
            component.show();
        }
    }
    class Raisin:AbstractIcecreamDecorator
    {
        public override void show()
        {
            Console.Write("葡萄干");
            component.show();
        }
    }
    class ChocolateChip:AbstractIcecreamDecorator
    {
        public override void show()
        {
            Console.Write("巧克力");
            component.show();
        }
    }
    class Strawberry:AbstractIcecreamDecorator
    {
        public override void show()
        {
            Console.Write("果酱");
            component.show();
        }
    }

}

