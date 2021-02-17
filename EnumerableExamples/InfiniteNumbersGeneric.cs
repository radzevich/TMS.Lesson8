using System.Collections;
using System.Collections.Generic;

namespace Samples
{
    public class InfiniteNumbersGeneric : IEnumerable<int>, IEnumerator<int>
    {
        public int Current { get; private set; } = -1;

        object IEnumerator.Current => Current;

        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            Current++;
            return true;
        }

        public void Reset()
        {
            Current = -1;
        }

        public void Dispose()
        {
            Reset();
        }
    }
}