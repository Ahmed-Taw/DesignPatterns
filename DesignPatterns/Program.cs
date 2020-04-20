using DesignPatterns.Bridge;
using DesignPatterns.LazyLoading;
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
                Console.ReadLine();
        }
    }
}
