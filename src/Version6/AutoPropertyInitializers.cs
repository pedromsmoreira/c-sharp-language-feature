namespace Features.Version6
{
    using System.Collections.Generic;

    public class AutoPropertyInitializers
    {
        // Auto-property initializers let you declare the initial value for an auto-property as part of the property declaration.
        public IDictionary<string, object> ObjectDict { get; } = new Dictionary<string, object>();
    }
}