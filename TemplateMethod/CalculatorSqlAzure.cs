using System;

namespace TemplateMethod
{
    public class CalculatorSqlAzure : Calculator
    {
        public new double Result { get; set; }

        protected override void CalculateSomething()
        {
            Result = 42.42424242;
        }

        protected override void SaveResult()
        {
            Console.WriteLine($"Saved {Result} into SQL Azure database");
        }
    }
}