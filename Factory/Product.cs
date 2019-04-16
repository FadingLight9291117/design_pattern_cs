
namespace Factory
{
    class Product
    {
        protected string LaptopName;
        public string getLaptop()
        {
            return "这是"+LaptopName+"的电脑";
        }
    }

    class HPProduct:Product
    {
        public HPProduct()
        {
            LaptopName = "HP";
        }
    }

    class AcerProduct : Product
    {
        public AcerProduct()
        {
            LaptopName = "Acer";
        }
    }

    class LenovoProduct : Product
    {
        public LenovoProduct()
        {
            LaptopName = "Lenovo";
        }
    }

}
