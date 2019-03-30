namespace Version7._0
{
    using System;

    public class OutVariables
    {
        public void OutVariablesExample()
        {
            const string strEx = "1";

            if (int.TryParse(strEx, out var number))
            {
                Console.WriteLine($"Inside if :: var number type: {number.GetType()}");
            }

            Console.WriteLine($"Outside if :: var number type: {number.GetType()}");
        }
    }
}