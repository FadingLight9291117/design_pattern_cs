using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            AppConfig.GetInstance();
            AppConfig.SetParameter(str);
            Console.WriteLine(AppConfig.GetParameter());
        }
    }
}
