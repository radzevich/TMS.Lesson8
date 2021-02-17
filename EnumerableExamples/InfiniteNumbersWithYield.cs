using System.Collections.Generic;

namespace Samples
{
    public class InfiniteNumbersWithYield
    {
        public IEnumerable<int> GetRange(int from, int to)
        {
            for (var i = from; i <= to; i++)
            {
                yield return i;
            }
        }
    }
}