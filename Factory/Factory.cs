

namespace Factory
{
    abstract class Factory
    {
        protected Product product;
        public Product getLaptop() { return product; }
    }


    class HPFactory : Factory
    {
        public HPFactory()
        {
            product = new HPProduct();
        }
    }

    class AcerFactory : Factory
    {
        public AcerFactory()
        {
            product = new AcerProduct();
        }
    }

    class LenovoFactory : Factory
    {
        public LenovoFactory()
        {
            product = new LenovoProduct();
        }
    }
}


