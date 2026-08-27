using System;
using System.Collections.Generic;
using System.Text;

namespace First_Day.classwork
{
    class EmplyeeSalary
    {
        public static void Run()
        {
            double baseSalary = 1200.00;
            int overTimeHours = 10;
            double overTimeRate = 8.5;
            double bonus = 150.00;
            double taxRate = 0.1;

            double overTimePay = overTimeHours * overTimeRate;
            double grossSalary = baseSalary + overTimeRate + bonus;
            double taxAmount = grossSalary * taxRate;
            double netSalary = grossSalary - taxAmount;

            Console.WriteLine("========================");
            Console.WriteLine($"Employee overTimePay : {overTimePay:F2}");
            Console.WriteLine($"Employee grossSalary : {grossSalary:F2}");
            Console.WriteLine($"Employee taxAmount : {taxAmount:F2}");
            Console.WriteLine($"Employee netSalary : {netSalary:F2}");

        }
    }
}
