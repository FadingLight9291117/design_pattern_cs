using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface InterfaceProductObserver
    {
        AbstractProduct Product { get; set; }

        void update(AbstractProduct abstractProduct);
    }

    class ProductObserver : InterfaceProductObserver
    {
        private string name;
        private string observerState;
        private AbstractProduct product;
        public AbstractProduct Product
        {
            get { return product; }
            set { product = value; }
        }
        public ProductObserver(string name)
        {
            this.name = name;
        }
        public void update(AbstractProduct abstractProduct)
        {
            Console.WriteLine("Notified investor {0} of {1}'s change to {2}$", this.name, abstractProduct.Name, abstractProduct.Price);
        }

    }
}
