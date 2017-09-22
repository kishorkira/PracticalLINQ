using System.Collections.Generic;
using System.Linq;

namespace Basics.Library
{
    public class Builder
    {
        public IEnumerable<int> GenerateSequence()
        {
            var ints = Enumerable.Range(1, 10)
                                .Select(i => i*6);
            return ints;
        }
    }
}
