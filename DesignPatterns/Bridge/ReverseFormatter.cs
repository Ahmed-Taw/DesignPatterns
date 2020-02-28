using System.Linq;

namespace DesignPatterns.Bridge
{
    public class ReverseFormatter : Iformatter
    {
        public string Format(string key, string value)
        {
            return string.Format("{0}: {1}", key, new string(value.Reverse().ToArray()));
        }
    }
}