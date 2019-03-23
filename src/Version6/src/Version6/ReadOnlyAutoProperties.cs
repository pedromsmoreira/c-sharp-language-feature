namespace Features.Version6
{
    public class ReadOnlyAutoProperties
    {
        // Read-only auto-properties provide a more concise syntax to create immutable types.
        // You declare the auto-property with only a get accessor.
        public ReadOnlyAutoProperties(string p1, string p2)
        {
            this.Property1 = p1;
            this.Property2 = p2;
        }

        public string Property1 { get; }

        public string Property2 { get; }

        public void ChangeProperty1ToAnotherProperty(string p3)
        {
            // Generate CS0200: Property or indexer cannot be assigned to. It is a readonly property!
            //this.Property1 = p3;
        }
    }
}