using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        private List<InterfaceFacility> FacilityList = new List<InterfaceFacility>();    
        public void add(InterfaceFacility facility)
        {
            FacilityList.Add(facility);
        }
        public void remove(InterfaceFacility facility)
        {
            FacilityList.Remove(facility);
        }
        public void open()
        {
            foreach (InterfaceFacility item in FacilityList)
            {
                item.open();
            }
        }
        public void close()
        {
            foreach (InterfaceFacility item in FacilityList)
            {
                item.close();
            }
        }
    }

    interface InterfaceFacility
    {
        void open();
        void close();
    }
    class Camera:InterfaceFacility
    {
        public void open()
        {
            Console.WriteLine("录像机开启");
        }
        public void close()
        {
            Console.WriteLine("录像机关闭");
        }
    }
    class Light:InterfaceFacility
    {
        public void open()
        {
            Console.WriteLine("电灯开启");
        }
        public void close()
        {
            Console.WriteLine("电灯关闭");
        }
    }
    class Sensor:InterfaceFacility
    {
        public void open()
        {
            Console.WriteLine("传感器开启");
        }
        public void close()
        {
            Console.WriteLine("传感器关闭");
        }
    }
    class Alarm:InterfaceFacility
    {
        public void open()
        {
            Console.WriteLine("警报器开启");
        }
        public void close()
        {
            Console.WriteLine("警报器关闭");
        }
    }
}
