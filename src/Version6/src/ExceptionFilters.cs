namespace Features.Version6
{
    using System;

    public class ExceptionFilters
    {
        public void FilterExample(bool notFiltered)
        {
            try
            {
                this.ThrowCustomException(true);
            }
            // Exception Filters are clauses that determine when a given catch clause should be applied.
            // If the expression used for an exception filter evaluates to true, the catch clause performs
            // its normal processing on an exception.
            // If the expression evaluates to false, then the catch clause is skipped.
            catch (CustomException ce) when (ce.Message.Contains("Custom"))
            {
                Console.WriteLine($"Custom Exception Message.");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Not Filtered Custom Exception :: {ex.Message}");
            }
        }

        public void ThrowCustomException(bool @throw)
        {
            if (@throw)
            {
                throw new CustomException();
            }

            throw new CustomException("Do not filter");
        }
    }

    public class CustomException : Exception
    {
        public CustomException()
        : base("CustomExceptionMessage")
        {
        }

        public CustomException(string message)
        : base(message)
        {
        }
    }
}