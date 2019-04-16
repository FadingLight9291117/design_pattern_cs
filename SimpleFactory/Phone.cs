using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    interface Phone
    {
        void Call();
    }
    class IPhoneX : Phone
    {
        public void Call()
        {
            Console.WriteLine("使用IPhone打电话");
        }
    }
    class Mate20pro : Phone
    {
        public void Call()
        {
            Console.WriteLine("使用华为mate20pro打电话");
        }
    }
    class MI9 : Phone
    {
        public void Call()
        {
            Console.WriteLine("使用小米9打电话");
        }
    }
}
