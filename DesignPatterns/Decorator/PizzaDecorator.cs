using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class PizzaDecorator
                           : Pizza
    {
        private readonly Pizza pizza;

        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }
    }
}
