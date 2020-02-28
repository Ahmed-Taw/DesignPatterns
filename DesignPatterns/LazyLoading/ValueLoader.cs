using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LazyLoading
{
    public class ValueLoader : IValueLoader<int>
    {
        public int Load()
        {
            return 5;
        }
    }
}
