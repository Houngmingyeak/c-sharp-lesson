using First_Day.classwork;
using First_Day.Function;

namespace First_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------------------
            //Calculator Ca = new Calculator();

            //Console.Write("Enter Value A: ");
            //int A = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Value B: ");
            //int B = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Sum= " + Ca.add(A, B));
            //Console.WriteLine("Mul= " + Ca.mul(A, B));
            //Console.WriteLine("Div= " + Ca.div(A, B));
            //Console.WriteLine("Sub= " + Ca.sub(A, B));

            //Console.ReadKey();
            //------------------------------------------------------------------------



            //------------------------------------------------------------------------
            //Console.WriteLine();
            //Console.WriteLine("Calling the method from ConvertGramToPound class");
            //// Calling the method from ConvertGramToPound class
            //ConvertGramToPound.Run();

            //Console.ReadKey();
            //------------------------------------------------------------------------

            //int num = int.Parse(Console.ReadLine());




            //------------------------------------------------------------------------
            //Console.WriteLine();
            //Console.WriteLine("Calling the method from Calculator class");
            //// Call the method from Calculator class
            //SubjectScoreCalculators.CalculateScores();

            //Console.ReadKey();
            //------------------------------------------------------------------------


            //------------------------------------------------------------------------
            //Console.WriteLine();
            //Console.WriteLine("Employee Salary");
            //// Call the method from Calculator class
            //EmplyeeSalary.Run();

            //Console.ReadKey();
            //------------------------------------------------------------------------


            //------------------------------------------------------------------------
            //Console.WriteLine();
            //Console.WriteLine("Bank Salary");
            //// Call the method from Calculator class
            //BankAccount.Run();

            //Console.ReadKey();
            //------------------------------------------------------------------------



            //------------------------------------------------------------------------
            //Demo demo = new Demo();
            //demo.DisplayMessage("Mingyeak!");

            //int sum = demo.Add(5, 10);
            //Console.WriteLine("Sum: " + sum);
            //------------------------------------------------------------------------



            //------------------------------------------------------------------------
            //int age;
            //string value;

            //Console.Write("Enter your age: ");
            //value = Console.ReadLine()!;
            //age = int.Parse(value);

            //Console.WriteLine("Your age next year" + " will be {0} ", ++age);
            //Console.Read();
            //------------------------------------------------------------------------



            // Declare and initialize variables
            double aValue = 78.926;
            double result1, result2;

            // Math.Floor -> round down to nearest integer
            result1 = Math.Floor(aValue);                  // result1 = 78

            // Math.Sqrt -> square root
            result2 = Math.Sqrt(aValue);                  // result2 ≈ 8.88403061678651

            // Display results
            Console.WriteLine("Original value: " + aValue);
            Console.WriteLine("Math.Floor(aValue) = " + result1);
            Console.WriteLine("Math.Sqrt(aValue) = " + result2);

            // Math.Round -> round to 2 decimal places
            Console.WriteLine("aValue rounded to 2 decimal places is {0}", Math.Round(aValue, 2));
        }
    }
}
