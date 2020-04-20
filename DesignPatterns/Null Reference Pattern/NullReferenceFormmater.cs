using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Null_Reference_Pattern
{

    public class NullDataFormatter<T> : IDataFormatter<T> where T : class
    {
        public string FormatAsString(IEnumerable<T> objectsList, Dictionary<string, string> nestedObjectsAndProperties = null)
        {
            throw new Exception("Unsupported data format");
        }

        public StringContent FormatAsStringContent(IEnumerable<T> objectsList, Dictionary<string, string> nestedObjectsAndProperties = null)
        {
            throw new Exception("Unsupported data format");
        }
    }
}
