namespace Features.Version6
{
    using System;
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
}