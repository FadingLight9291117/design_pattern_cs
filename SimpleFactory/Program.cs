using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone;
            SimpleFactory factory = new SimpleFactory("IPhoneX");
            phone = factory.CreatePhone();
            phone.Call();
        }
    }
}
