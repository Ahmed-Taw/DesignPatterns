using DesignPatterns.Bridge;
using DesignPatterns.LazyLoading;
using DesignPatterns.Memento;
using DesignPatterns.Observer_Pattern;
using DesignPatterns.Observer_Pattern.IObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //IList<ManuScript> manuScripts = new List<ManuScript>();
            //StandardFormatter standardFormatter = new StandardFormatter();
            //ReverseFormatter reverseFormatter = new ReverseFormatter();
            //Book book = new Book(standardFormatter) { Title = "Book 1" };
            //manuScripts.Add(book);

            //FAQ fAQ = new FAQ(reverseFormatter) { Title = "FAQ" };
            //manuScripts.Add(fAQ);

            //foreach (var doc in manuScripts)
            //{
            //    doc.Print();


            //}

            //List<int> vs = new List<int>() { 1, 2, 3, 4 };

            //IEnumerator<int> re = vs.GetEnumerator();
            //while (re.MoveNext())
            //{
            //    Console.WriteLine(re.Current);
            //}

            //OrderBad orderBad = new OrderBad();
            //string companyname = orderBad.Customer.CompanyName;

            //DesignPatterns.Singlton.Singlton singlton = DesignPatterns.Singlton.Singlton.Instance;

            //StockTicker st = new StockTicker();

            //GoogleMonitor gf = new GoogleMonitor();
            //MicrosoftMonitor mf = new MicrosoftMonitor();

            //using (st.Subscribe(gf))
            //using (st.Subscribe(mf))
            //{
            //    foreach (var s in SampleData.getNext())
            //        st.Stock = s;
            //}

            // Client code.
            Originator originator = new Originator("Super-duper-super-puper-super.");
            CareTaker caretaker = new CareTaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.UnDo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.UnDo();

            Console.WriteLine("\n\nClient: Original state!\n");
            caretaker.UnDo();
            Console.ReadLine();
        }
    }
}
