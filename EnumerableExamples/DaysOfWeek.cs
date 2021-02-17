using System.Collections;

namespace Samples
{
    public class DaysOfWeek : IEnumerable
    {
        private readonly string[] _daysOfWeek = {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday",
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _daysOfWeek.GetEnumerator();
        }
    }
}