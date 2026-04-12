namespace Blazor.Components.Pages
{
    public partial class Power
    {
        private double baseValue = 2;
        private int exponent = 0;
        private double result = 1;

        private void CalculatePower()
        {
            result = Math.Pow(baseValue, exponent);
        }

    }
}
