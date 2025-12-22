using System;
using AverageCalculator;

class Program
{
    static void Main(string[] args)
    {
        AverageCalculator.AverageCalculator calc =
            new AverageCalculator.AverageCalculator();

        calc.add(10);
        calc.add(20.5);

        double[] values = { 5, 15, 25 };
        calc.add(values);

        Console.WriteLine(calc.count());
    }
}
