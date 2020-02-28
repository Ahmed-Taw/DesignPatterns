using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class Book : ManuScript
    {
       public Book(Iformatter formatter) : base(formatter)
        {

        }

        public string Title { get; set; }
        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            Console.WriteLine();
        }
    }
}
