namespace Blazor.Components.Pages
{
    public partial class Fibonacci
    {
        private int count = 1;
        private List<long> fibonacciSequence = new();

        private void GenerateFibonacci()
        {
            fibonacciSequence.Clear();

            long a = 0, b = 1;
            for (int i = 0; i < count; i++)
            {
                fibonacciSequence.Add(a);
                (a, b) = (b, a + b);
            }
        }

        protected override void OnInitialized() => GenerateFibonacci();

    }
}
