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


            // Kjøre enhetstester mot MeaningfulNames klassen
            //MeaningfulNamesTests meaningfulNamesTests = new MeaningfulNamesTests();
            //meaningfulNamesTests.SetDescription_ShouldSetDescription();
            //meaningfulNamesTests.GetDescription_WithoutSetting_ShouldReturnNull();
            //meaningfulNamesTests.GetDescription_AfterSetting_ShouldReturnSetDescription();

            // Kjøre enhetstester av LinkedListDemo i Functions klassen
            //LinkedListDemoTests linkedListDemoTests = new LinkedListDemoTests();
            //linkedListDemoTests.Add_AddsElementToList();
            //linkedListDemoTests.Add_GrowsListWhenAtCapacity();
            //linkedListDemoTests.Print_PrintsCorrectly();
        }
    }
}
