namespace Version7._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PatternMatching
    {
        public static int SumPositiveNumbers(IEnumerable<object> seq)
        {
            var sum = 0;

            foreach (var o in seq)
            {
                switch (o)
                {
                    case 0:
                        break;

                    case IEnumerable<int> childSequence:
                        {
                            sum += childSequence.Sum(item => ((item > 0) ? item : 0));
                            break;
                        }
                    case int n when n > 0:
                        sum += n;
                        break;

                    case null:
                        throw new NullReferenceException("Null found in sequence");

                    default:
                        throw new InvalidOperationException("Unrecognized type");
                }
            }

            return sum;
        }
    }
}