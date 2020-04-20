using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Null_Reference_Pattern
{
    public interface IDataFormatter<T>
    {
        StringContent FormatAsStringContent(IEnumerable<T> objectsList, Dictionary<string, string> nestedObjectsAndProperties = null);

        string FormatAsString(IEnumerable<T> objectsList, Dictionary<string, string> nestedObjectsAndProperties = null);

    }
}
