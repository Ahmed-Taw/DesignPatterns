using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LazyLoading
{
   public class OrderLazy
    {
        public OrderLazy()
        {
            _customer = new Lazy<Customer>(() => new Customer());
        }
        private Lazy<Customer> _customer;
        public Customer Customer { get {
                return _customer.Value;
            } }

    }
}
