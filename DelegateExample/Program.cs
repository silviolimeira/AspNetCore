using System;
using DelegateExample.Services;

namespace DelegateExample
{
    //delegate double BinaryNumericOperation(double n1, double n2);
    // Multicast Delegate
    delegate void BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 Delegates
            //double a = 10;
            //double b = 12;

            //// delegate op é uma referencia para CalculationService.Sum
            //BinaryNumericOperation op = CalculationService.Sum;
            ////BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);


            ////double result = op(a, b);
            //double result = op.Invoke(a, b);
            //Console.WriteLine(result);

            // Multicas Delegate
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            //op.Invoke(a, b);
            op(a, b);

        }
    }
}
