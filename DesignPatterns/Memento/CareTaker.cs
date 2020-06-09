using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class CareTaker
    {
       private IList<IMemento> _mementos = new List<IMemento>();

        private Originator _originator;

        public CareTaker(Originator originator)
        {
            this._originator = originator;
        }
        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            this._mementos.Add(this._originator.Save());
        }

        public void UnDo()
        {
            if (this._mementos.Count == 0)
                return;

            IMemento memento = this._mementos.Last<IMemento>();
            this._mementos.Remove(memento);

            try
            {
                this._originator.Restore(memento);
            }
            catch
            {
                UnDo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in this._mementos)
            {
                Console.WriteLine(memento.GetState());
            }
        }
    }
}
