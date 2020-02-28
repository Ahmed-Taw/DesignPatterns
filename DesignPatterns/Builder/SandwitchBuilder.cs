using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{

    //Builder
    public abstract class SandwitchBuilder
    {
        protected  Sandwitch _sandwitch;
        public SandwitchBuilder()
        {
            
        }

        public void CreateSandwitch()
        {
            _sandwitch = new Sandwitch();
        }
        public Sandwitch GetSandwitch()
        {
            return this._sandwitch;
        }

        public abstract void SetName();

        public abstract void SetIngrediants();

    }
}
