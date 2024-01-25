namespace CleanCodeExamples
{
    /// <summary>
    /// Basic implementation of a simple calculator that can perform arithmetics.
    /// </summary>
    public class Calculator
    {
        // Bad Comment: Redundant and not providing any useful information
        // Default constructor.
        public Calculator()
        {
            // Constructor body
        }

        // Holds the result of the arithemitc operations. 
        public double Result { get; set; }

        // Good Comment: Explains the purpose of the method and its parameters
        // Adds two numbers and updates the result.
        public void Add(double a, double b)
        {
            Result = a + b;
        }

        // Good Comment: Highlights an important behavior of the method
        // Resets the calculator result to zero.
        public void Clear()
        {
            Result = 0;
        }

        // Bad Comment: Outdated and misleading
        // Multiplies two numbers and sets the result variable.
        public void Multiply(double a, double b)
        {
            // This method actually divides two numbers
            Result = a / b;
        }

        // Bad Comment: Unclear and does not provide enough information
        // Performs a calculation.
        public void Calculate(double a, double b)
        {
            Result = a - b;
        }

    }
}
