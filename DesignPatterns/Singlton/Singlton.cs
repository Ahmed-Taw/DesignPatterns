using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singlton
{
    // NOT THREAD SAFE IMPLEMENTATION
    public class Singlton
    {
        private static Singlton _instance;

        private Singlton()
        {

        }

        public static Singlton Instance
        {
            get
            {
                if (_instance == null) _instance = new Singlton();
                return _instance;
            }

        }
    }
}
