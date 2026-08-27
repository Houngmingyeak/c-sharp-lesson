using System;

namespace First_Day
{
    public class ConvertGramToPound
    {
        public static void Run()
        {
            string product = "Montreal Smoked Meat";
            double PricePer100grams = 2.09;
            double gramsPerunit = 100;
            double gramPerpoud = 453.59237;

            // price per grams
            double PricePerGrams = PricePer100grams / gramsPerunit;

            // price per pound
            double PricePerpounds = PricePerGrams * gramPerpoud;

            Console.WriteLine($"Product name:{product}");
            Console.WriteLine("Price Per Grams:{0:C2}", PricePer100grams);
            Console.WriteLine($"Price Per Grams:${PricePer100grams}");
            Console.WriteLine("Conversion: 1 pound:{0:F2}", gramPerpoud);
            Console.WriteLine("========================");
            Console.WriteLine("Price per pound:{0:C2}", PricePerpounds);
        }
    }
}