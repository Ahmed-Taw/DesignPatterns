using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProtoTypePattern
{
    public class WebPageScrapper : ICloneable // implementing the clone is used as prototype pattern 
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
