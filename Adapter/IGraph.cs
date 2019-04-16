using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IGraph
    {
        void Draw();
    }
    class Circle : IGraph
    {
        public void Draw()
        {
            Console.WriteLine("画一个圆");
        }
    }
    class Rectangle : IGraph
    {
        public void Draw()
        {
            Console.WriteLine("画一个矩形");
        }
    }
    class Line : IGraph
    {
        public void Draw()
        {
            Console.WriteLine("画一条直线");
        }
    }
}
