using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter_Pattern
{
    // Adapter interface to be passed to the client 
    public interface IPatternRenderAdapter
    {
        string RenderPatterns(IEnumerable<Pattern> patterns);
    }
}
