using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics.Library
{
    public class Builder
    {
        public IEnumerable<int> GenerateIntSequence()
        {
            var ints = Enumerable.Range(1, 10)
                                .Select(i => i*6);
            return ints;
        }
        public IEnumerable<string> GenerateStringSequence()
        {
            Random rand = new Random();
            var strings = Enumerable.Range(0, 10)
                                .Select(i =>((char)('A' + rand.Next(0,26))).ToString());
            return strings;
        }
    }
}
