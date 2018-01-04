using System;

namespace TemplateMethod
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Calculator calculatorOracle = new CalculatorOracle();
            Calculator calculatorSqlAzure = new CalculatorSqlAzure();

            calculatorOracle.TemplateMethod();
            calculatorSqlAzure.TemplateMethod();

            Console.ReadKey();
        }
    }
}