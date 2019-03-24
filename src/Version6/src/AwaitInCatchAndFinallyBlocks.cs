namespace Features.Version6
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    // C# 5 had several limitations around where you could place await expressions.
    // With C# 6, you can now use await in catch or finally expressions.
    public class AwaitInCatchAndFinallyBlocks
    {
        public async Task AwaitInCatchAndFinally()
        {
            try
            {
            }
            catch (Exception e)
            {
                await this.ReturnSomeTask();
            }
            finally
            {
                await this.ReturnSomeTask();
            }
        }

        public Task ReturnSomeTask()
        {
            return Task.CompletedTask;
        }
    }

    public class InitializeAssociativeCollectionsUsingIndexers
    {
        // Index Initializers is one of two features that make collection initializers more consistent with index usage.
        // In earlier releases of C#, you could use collection initializers with sequence style collections,
        // including Dictionary<TKey,TValue>, by adding braces around key and value pairs
        private Dictionary<int, string> messages = new Dictionary<int, string>
        {
            { 404, "Page not Found"},
            { 302, "Page moved, but left a forwarding address."},
            { 500, "The web server can't come out to play today."}
        };

        // You can use them with Dictionary<TKey,TValue> collections and other types where the accessible Add method accepts more than one argument.
        // The new syntax supports assignment using an index into the collection:
        private Dictionary<int, string> statusErrorMessages = new Dictionary<int, string>
        {
            [200] = "Success",
            [404] = "Not Found",
            [400] = "Bad Request",
            [301] = "Redirect",
            [302] = "Redirect Moved Permanently",
            [500] = "Internal Server Error"
        };
    }
}