using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class AbstractProduct
    {

        protected string name;
        protected string price;
        private ArrayList obervers = new ArrayList();
        public AbstractProduct(string name, string price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract void productState();

        public void attach(InterfaceProductObserver observer)
        {
            this.obervers.Add(observer);
        }
        public void detach(InterfaceProductObserver observer)
        {
            this.obervers.Remove(observer);
        }
        public void notify()
        {
            foreach (InterfaceProductObserver observer in this.obervers)
            {
                observer.update(this);
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Price
        {
            get { return price; }
            set
            {
                price = value;
                notify();
            }
        }
    }
    class Product : AbstractProduct
    {
        public Product(string name, string price) : base(name, price)
        {
        }

        public override void productState()
        {
            Console.WriteLine("{0}'s price is {1}", name, price);
        }
    }

}
