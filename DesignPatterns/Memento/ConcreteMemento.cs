using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;
        public ConcreteMemento(string state)
        {

            this._state = state;
            this._date = DateTime.Now;
        }
        public DateTime GetDate()
        {
            return this._date;
        }



        public string GetState()
        {
            return this._state;
        }
    }
}
