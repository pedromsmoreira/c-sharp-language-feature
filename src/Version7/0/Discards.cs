namespace Version7
{
    using System;

    public class Discards
    {
        public Discards()
        {
            var (str, _, _, str2) = QueryStuff("str", 1, 2, "str2");

            Console.WriteLine($"Str: {str} || Str2: {str2}");
        }

        public static (string, int, int, string) QueryStuff(string str, int n1, int n2, string str2)
        {
            return (str, n1, n2, str2);
        }
    }
}