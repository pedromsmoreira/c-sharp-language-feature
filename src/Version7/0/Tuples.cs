namespace Version7
{
    using System.Collections.Generic;

    public class Tuples
    {
        // The new tuples features require the ValueTuple types.
        // You must add the NuGet package System.ValueTuple in order to use it on platforms that do not include the types.

        public void SimpleTupleExample()
        {
            // You can create a tuple by assigning a value to each member:
            var letters = ("a", "b");

            //That assignment creates a tuple whose members are Item1 and Item2,
            // which you can use in the same way as Tuple You can change the syntax to create a tuple that provides semantic names to each of the members of the tuple:
            (string Alpha, string Beta) namedLetters = letters;

            var alphabet = (Alpha: namedLetters.Alpha, Beta: namedLetters.Beta);

            (string First, string Second) firstLetters = (Alpha: "a", Beta: "b");
            // The line above generates a warning, CS8123, telling you that the names on the right side of the assignment,
            // Alpha and Beta are ignored because they conflict with the names on the left side, First and Second.
        }

        private static (int Max, int Min) Range(IEnumerable<int> numbers)
        {
            var min = int.MaxValue;
            var max = int.MinValue;

            foreach (var n in numbers)
            {
                min = (n < min) ? n : min;
                max = (n > max) ? n : max;
            }

            return (max, min);
        }
    }
}