using System;

namespace Singleton
{
    class AppConfig
    {
        private static AppConfig singleton;
        private static readonly object syncObject = new object();

        private static string parameter;
        private AppConfig()
        { }
        public static AppConfig GetInstance()
        {
            if (singleton == null)
            {
                lock (syncObject)
                {
                    if (singleton == null)
                    {
                        singleton = new AppConfig();
                    }
                }
            }
            return singleton;
        }
        public static void SetParameter(String str)
        {
            parameter = str;
        }
        public static string GetParameter()
        {
            return parameter;
        }
    }
}

