using System.Numerics;

namespace Blazor.Components.Pages
{
    public partial class Factorial
    {
        int n;
        BigInteger factorial;
        void CalculateFactorial()
        {
            factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {n} is {factorial}");
        }

    }
}
