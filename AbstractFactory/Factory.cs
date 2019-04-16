using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IFactory
    {
        Hamburg getHamburg();
        Cola getCola();
    }

    class McDonaldsFactory:IFactory
    {
        public Hamburg getHamburg()
        {
            return new McDonaldsHamburg();
        }
        public Cola getCola()
        {
            return new McDonaldCola();
        }
    }
    class KFCFactory : IFactory
    {
        public Cola getCola()
        {
            return new KFCCola();
        }

        public Hamburg getHamburg()
        {
            return new KFCHamburg();
        }
    }
}
