using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{

    // Concrete builder 

    public class MySandwitchBuilder : SandwitchBuilder
    {
        public override void SetIngrediants()
        {
            _sandwitch.Name = "My name";

        }

        public override void SetName()
        {
            _sandwitch.Ingrediants = "My ingredients";
        }
    }
}
