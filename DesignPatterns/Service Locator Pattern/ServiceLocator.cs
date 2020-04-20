using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Service_Locator_Pattern
{

    internal class ServiceLocator
    {
        private static readonly Hashtable services = new Hashtable();

        public static void AddService<T>(T t)
        {
            services.Add(typeof(T).Name, t);
        }

        public static void AddService<T>(string name, T t)
        {
            services.Add(name, t);
        }

        public static T GetService<T>()
        {
            return (T)services[typeof(T).Name];
        }

        public static object GetService<T>(string serviceName)
        {
            return (T)services[serviceName];
        }
    }
}
