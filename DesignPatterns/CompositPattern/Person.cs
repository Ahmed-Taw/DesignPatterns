using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositPattern
{
   public class Person : CompositeInterface
    {
        public string Name { get; set; }

        public int Gold { get; set; }

    }
}
