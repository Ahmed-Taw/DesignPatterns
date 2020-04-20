using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Service_Locator_Pattern
{
    class Programe
    {

        public Programe()
        {
            // set the service should be in app start 
            ServiceLocator.AddService<LoggingClass>(new LoggingClass());
        }
        public void UseAservice()
        {
            var loggingService = ServiceLocator.GetService<LoggingClass>();
        }
    }
}
