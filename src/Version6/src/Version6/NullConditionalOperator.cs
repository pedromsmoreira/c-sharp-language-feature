namespace Features.Version6
{
    // The rules of the ?. operator ensure that the left-hand side of the operator is evaluated only once.
    public class NullConditionalOperator
    {
        // used = null to force a compiler check and ask for nullconditional operator
        public void Print(Person person = null)
        {
            // use this
            var first = person?.FirstName;

            // instead of
            if (person != null)
            {
                var first2 = person.FirstName;
            }
        }
    }
}