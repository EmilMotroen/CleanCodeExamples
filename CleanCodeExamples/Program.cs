namespace CleanCodeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Functions demo
            LinkedListDemo demo = new LinkedListDemo();
            demo.Add(1);
            demo.Add(2);
            demo.Add(3);
            demo.Add(4);
            demo.Print();

            // Calculator demo - Sikkert unødvendig
            //Calculator calculator = new Calculator();
            //double a = 5, b = 4;
            //calculator.Add(a, b);
            //Console.WriteLine($"{a} + {b} = {calculator.Result}");
        }
    }
}
