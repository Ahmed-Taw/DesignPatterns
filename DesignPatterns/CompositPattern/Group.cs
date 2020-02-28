using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositPattern
{
   public class Group : CompositeInterface
    {
        public string Name { get; set; }

        public List<Person> Members { get; set; }

        // it should deal with that as a group so we should loop over the members to get the total gold and loop again to set the gold in case we are setting 
        public int Gold {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }
    }
}
