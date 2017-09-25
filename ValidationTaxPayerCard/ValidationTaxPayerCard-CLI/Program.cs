
namespace ValidationTaxPayerCard_CLI
{
    using System;
    using System.Linq;

    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TaxPayerVerify. Type in a command.");
            while (true)
            {
                args = new[] { Console.ReadLine() };
                if (args.Contains("/h") || args.Contains("help") || args.Contains("--help"))
                {
                    DisplayHelp(args);
                }
            }
        }

        public static void DisplayHelp(string[] args)
        {
            Console.WriteLine("===== SOME MEANINGFULL HELP ==== ");
        }

    }
}
