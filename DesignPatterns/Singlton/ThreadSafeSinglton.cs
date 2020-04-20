using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singlton
{
    public class ThreadSafeSinglton
    {
        private ThreadSafeSinglton()
        {

        }

        // BeforeFieldInit flag 
        private class Nested
        {

            static Nested()
            {

            }

            internal static readonly ThreadSafeSinglton Instance = new ThreadSafeSinglton();

            //// method 1
            //public void SaveObject(object ay7aga)
            //{
            //    Validate(); // method a

            //    // save 
            //}


            //public bool Validate(object ay7aga)
            //{
            //    // validate name < 20  methodai
            //    // va;idate name doesn't contain numbers method aii
            //    // validate ID valid method aiii
            //   //validateDiseas aiii


            //} 
            ////method 1
            //    // method 1 a
            //      // method ai
            //      //
            //      //
            //        //

            //    // method b save

            //public bool validateName(string name)
            //{

            //}

            //public bool validateDiseas(object ay7aga)
            //{
            //    // validate age < 60 aiii 1
            //    // validate doesnt have desease method f aiii 2
            //}
        }

    }
}
