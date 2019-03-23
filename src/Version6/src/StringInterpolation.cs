namespace Features.Version6
{
    using System;
    using System.Globalization;

    //  string interpolation feature enables you to embed expressions in a string.
    //  Simply preface the string with $and use expressions between { and } instead of ordinals
    public class StringInterpolation
    {
        private readonly Person person;
        private readonly double grades;

        public StringInterpolation(Person person)
        {
            this.person = person;
            this.grades = 12.123;
        }

        public string FullName => $"{this.person.FirstName} {this.person.LastName}";

        // The preceding line of code formats the value for this.grades
        // as a floating-point number with two decimal places.
        public string GradesPercentage() => $"Name: {this.FullName}. G.P.A: {this.grades:F2}";

        public void SpecificCultureString()
        {
            // Often, you may need to format the string produced using a specific culture.
            // You use the fact that the object produced by a string interpolation
            // can be implicitly converted to System.FormattableString.
            // The FormattableString instance contains the composite format string and the
            // results of evaluating the expressions before converting them to strings.
            // Use the FormattableString.ToString(IFormatProvider) method to specify the culture
            // when formatting a string.
            // The following example produces a string using the German (de-DE) culture.
            // (By default, the German culture uses the ',' character for the decimal separator,
            // and the '.' character as the thousands separator.)

            FormattableString str = $"Naming: {this.FullName} average: {this.grades}";
            var nameStr = str.ToString(new CultureInfo("de-DE"));
        }
    }
}