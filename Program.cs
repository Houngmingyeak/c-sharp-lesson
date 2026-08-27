namespace First_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator Ca = new Calculator();

            Console.Write("Enter Value A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum= " + Ca.add(A, B));
            Console.WriteLine("Mul= " + Ca.mul(A, B));
            Console.WriteLine("Div= " + Ca.div(A, B));
            Console.WriteLine("Sub= " + Ca.sub(A, B));

            Console.ReadKey();


            Console.WriteLine();
            Console.WriteLine("Calling the method from ConvertGramToPound class");
            // Calling the method from ConvertGramToPound class
            ConvertGramToPound.Run();

            Console.ReadKey();

            //int num = int.Parse(Console.ReadLine());
        }
    }
}
