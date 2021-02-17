using System.Collections;

namespace Samples
{
    public class InfiniteNumbers : IEnumerable, IEnumerator
    {
        private int _currentNumber = -1;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            _currentNumber++;
            return true;
        }

        public void Reset()
        {
            _currentNumber = -1;
        }

        public object Current
        {
            get { return _currentNumber; }
        }
    }
}