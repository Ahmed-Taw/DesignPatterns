using System;

namespace DesignPatterns.Bridge
{
    public class FAQ : ManuScript
    {
        public FAQ(Iformatter formatter) : base(formatter) { }

        public string Title { get; set; }
        public override void Print()
        {
            Console.WriteLine(formatter.Format("Title", Title));
            Console.WriteLine();
        }
    }
}