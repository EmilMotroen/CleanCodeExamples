using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeExamples
{
    using System;

    public class CommentExample
    {
        // Good Comment: Describes the purpose of the class
        // Represents a simple calculator with basic arithmetic operations.
        public class Calculator
        {
            // Good Comment: Clearly states the purpose of the variable
            // Holds the result of the arithmetic operations.
            private double result;

            // Good Comment: Explains the purpose of the method and its parameters
            // Adds two numbers and updates the result.
            public void Add(double a, double b)
            {
                result = a + b;
            }

            // Good Comment: Highlights an important behavior of the method
            // Resets the calculator result to zero.
            public void Clear()
            {
                result = 0;
            }

            // Bad Comment: Redundant and not providing any useful information
            // Default constructor.
            public Calculator()
            {
                // Constructor body
            }

            // Bad Comment: Outdated and misleading
            // Multiplies two numbers and sets the result variable.
            public void Multiply(double a, double b)
            {
                // This method actually divides two numbers
                result = a / b;
            }

            // Bad Comment: Unclear and does not provide enough information
            // Performs a calculation.
            public void Calculate()
            {
                // Method body
            }
        }
    }

}
