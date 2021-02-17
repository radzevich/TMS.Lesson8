using System;
using System.Collections;

namespace Samples
{
    public class DaysOfWeekWithCustomEnumerator : IEnumerable, IEnumerator
    {
        private int _currentPosition = -1;

        private readonly string[] _daysOfWeek = {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday",
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_currentPosition < _daysOfWeek.Length - 1)
            {
                _currentPosition++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _currentPosition = -1;
        }

        public object Current
        {
            get
            {
                if (_currentPosition == -1 || _currentPosition >= _daysOfWeek.Length)
                {
                    throw new InvalidOperationException();
                }
                    
                return _daysOfWeek[_currentPosition];
            }
        }
    }
}