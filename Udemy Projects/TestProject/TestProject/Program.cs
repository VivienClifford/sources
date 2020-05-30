using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                string input = Console.ReadLine();

                try
                {
                    StringToIntConverter stringToIntConverter = new StringToIntConverter();
                    stringToIntConverter.convert(input);

                } catch(Exception ex)
                {
                    Console.WriteLine("There was an error with conversion: {0}", ex.Message);
                }

            } catch (Exception ex) { //if there is an exception  - deal with it here. logging exception is also appropriate
                Console.WriteLine("There was an error: {0}", ex.Message);
                //Sometimes we want to continue, sometimes we want the application to stop
            } finally { //free up unmanaged resources, whether or not there was an exception.
                Console.WriteLine("The rest of my application is still running.");
            }

        }
    }
}
