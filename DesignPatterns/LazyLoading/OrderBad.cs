using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LazyLoading
{
   public class OrderBad
    {

        private Customer _customer;
        public Customer Customer {
            get {
                if (_customer == null)
                    _customer = new Customer();
                return _customer;
                }
        }
    }
}
