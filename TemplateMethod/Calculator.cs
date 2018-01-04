using System;

namespace TemplateMethod
{
    public class Calculator
    {
        public virtual decimal Result { get; set; }

        public void TemplateMethod()
        {
            BeforeCalculation();
            CalculateSomething();
            SaveResult();

            Console.WriteLine();
        }

        protected virtual void CalculateSomething()
        {
            Result = 42.42m;
        }

        protected virtual void SaveResult()
        {
            Console.WriteLine($"The result {Result} does not get saved");
        }

        private static void BeforeCalculation()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Starting the calculation");
            Console.WriteLine("-------------------------");
        }
    }
}