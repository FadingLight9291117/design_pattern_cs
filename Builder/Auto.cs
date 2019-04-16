using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Auto
    {
        private string wheel;
        private string oilbox;
        private string body;
        public string Wheel
        {
            set { wheel = value; }
            get { return wheel; }
        }
        public string Oilbox
        {
            set { oilbox = value; }
            get { return oilbox; }
        }
        public string Body
        {
            set { body = value; }
            get { return body; }
        }
        public void Introduce()
        {
            Console.WriteLine(wheel);
            Console.WriteLine(oilbox);
            Console.WriteLine(body);
        }
    }
}
