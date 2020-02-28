using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public abstract class ManuScript
    {
        protected readonly Iformatter formatter;

        public ManuScript(Iformatter formatter)
        {
            this.formatter = formatter;
        }
        public abstract void Print();
    }
}
