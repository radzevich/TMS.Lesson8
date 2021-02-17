using System.Collections.Generic;

namespace Samples
{
    public class FactorialWithYield
    {
        public IEnumerable<int> GetFirst(int n)
        {
            if (n < 0)
            {
                yield break;
            }

            yield return 1;

            var factorial = 1;
            for (var i = 1; i <= n; i++)
            {
                factorial *= i;
                yield return factorial;
            }

            yield return factorial;
        }
    }
}