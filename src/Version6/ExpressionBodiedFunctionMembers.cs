namespace Features.Version6
{
    public class ExpressionBodiedFunctionMembers
    {
        // Many members that you write are single statements that could be single expressions.
        // Write an expression-bodied member instead. It works for methods and read-only properties.
        public int Multiply(int n, int multiplier) => n * multiplier;

        public string FirstName { get; set; } = "Hello";

        public string LastName { get; set; } = "Dummy";

        public string FullName => $"{this.FirstName} {this.LastName}";
    }
}