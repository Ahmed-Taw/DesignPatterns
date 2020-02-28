using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{

    //Director 
    public class SandwitchMaker
    {
        private readonly SandwitchBuilder sandwitchBuilder;

        public SandwitchMaker(SandwitchBuilder sandwitchBuilder)
        {
            this.sandwitchBuilder = sandwitchBuilder;
        }

        public void CreateSandwitch()
        {
            sandwitchBuilder.CreateSandwitch();
            sandwitchBuilder.SetName();
            sandwitchBuilder.SetIngrediants();
        }

        public Sandwitch GetSandwitch()
        {
           return this.sandwitchBuilder.GetSandwitch();
        }
    }
}
