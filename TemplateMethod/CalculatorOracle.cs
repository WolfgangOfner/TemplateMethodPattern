namespace TemplateMethod
{
    public class CalculatorOracle : Calculator
    {
        protected override void CalculateSomething()
        {
            Result = 40 + 2;
        }
    }
}