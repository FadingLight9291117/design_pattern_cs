using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    class SimpleFactory
    {
        private string phone;
        public SimpleFactory(string phone)
        {
            this.phone = phone;
        }
        public Phone CreatePhone()
        {
            switch (phone)
            {
                case "IPhoneX":
                    return new IPhoneX();
                case "MI9":
                    return new MI9();
                case "Mate20pro":
                    return new Mate20pro();
                default:
                    return null;
            }
        }
    }
}
