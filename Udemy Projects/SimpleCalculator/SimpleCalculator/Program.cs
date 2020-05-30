using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criteria:
            //Three inputs, 2 numerical and 1 operational - four basic used
            //The two input have to be numerial - if not throw an exception
            //Perform the operation

            //Single Responsibility Principle:

            try { 
                InputConverter inputConverter = new InputConverter();//Read input and Convert
                CalculatorEngine calculatorEngine = new CalculatorEngine();  //Do the operation

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine(result);
            } catch (Exception ex)
            {
                //In the real world we would want to log this message
                Console.WriteLine(ex.Message);
            }
        }
    }
}
