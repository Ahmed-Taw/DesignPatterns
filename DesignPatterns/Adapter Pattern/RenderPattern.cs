using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter_Pattern
{

    //the client class which want to access render class but is not able to because incompatibility 
    public class RenderPattern
    {
        private readonly IPatternRenderAdapter _patternRenderAdapter;
        public RenderPattern(IPatternRenderAdapter patternRenderAdapter)
        {
            _patternRenderAdapter = patternRenderAdapter;
        }
        public string RenderPatterns(IEnumerable<Pattern> patterns)
        {
            return _patternRenderAdapter.RenderPatterns(patterns);
        }
    }
}
