using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IGraph line = new Line();
            IGraph circle = new Circle();
            IGraph rectangle = new Rectangle();
            Angle Iangle = new Angle();
            IGraph angle = new AngleAdapter(Iangle);
            line.Draw();
            circle.Draw();
            rectangle.Draw();
            angle.Draw();
        }
    }
}
