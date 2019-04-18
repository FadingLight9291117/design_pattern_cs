using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceFacility camera = new Camera();
            InterfaceFacility light1 = new Light();
            InterfaceFacility light2 = new Light();
            InterfaceFacility sensor = new Sensor();
            InterfaceFacility alarm = new Alarm();
            Facade facade = new Facade();
            facade.add(camera);
            facade.add(light1);
            facade.add(light2);
            facade.add(sensor);
            facade.add(alarm);
            facade.open();
            Console.WriteLine("============");
            facade.close();
        }
    }
}
