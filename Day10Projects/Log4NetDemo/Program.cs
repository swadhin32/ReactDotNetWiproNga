using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Reflection;
namespace Log4NetDemo
{
    internal class Program
    {
        // Create a static logger instance for the class
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            log4net.Config.XmlConfigurator.Configure();
            // Log application start
            log.Info("Application is starting...");

            try
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                // Log user input
                log.Debug($"User entered: {number}");

                // Simulate a division operation
                int result = 100 / number;
                Console.WriteLine($"Result: 100 / {number} = {result}");

                // Log success
                log.Info($"Division successful. Result: {result}");
            }
            catch (FormatException ex)
            {
                // Log format error
                log.Error("Invalid input format.", ex);
                Console.WriteLine("Please enter a valid number.");
            }
            catch (DivideByZeroException ex)
            {
                // Log divide by zero error
                log.Error("Attempted to divide by zero.", ex);
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                // Log any other errors
                log.Fatal("An unexpected error occurred.", ex);
                Console.WriteLine("An unexpected error occurred.");
            }
            finally
            {
                // Log application end
                log.Info("Application is closing.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
