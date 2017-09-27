
namespace ValidationTaxPayerCard_CLI
{
    using System;
    using System.Linq;

    public static class Program
    {
        private const string HELP = "help";
        private const string EXIT = "exit";

        static void Main(string[] args)
        {
            bool exit = true;

            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine(StringsResource.StartProgram);

            while (exit)
            {
                Console.WriteLine(StringsResource.InsertNumberToCheck);
                args = new[] { Console.ReadLine() };

                if (args.Contains(EXIT))
                {
                    exit = false;
                }

                if (args.Contains(HELP))
                {
                    DisplayHelp(args);
                }
                else
                {
                    string str = String.Format("{0}", args[0]);
                    if (IsValidContrib(str))
                    {
                        Console.WriteLine(StringsResource.ValidNumber);
                    }
                    else
                    {
                        Console.WriteLine(StringsResource.InvalidNumber);
                    }
                }
            }
        }

        public static void DisplayHelp(string[] args)
        {

            Console.WriteLine(StringsResource.Help);
        }

        public static bool IsValidContrib(string Contrib)
        {
            bool functionReturnValue = false;
            string[] s = new string[9];

            if (Contrib.Length < 9 || Contrib.Length > 9)
            {
                return false;
            }

            s[0] = Convert.ToString(Contrib[0]);
            s[1] = Convert.ToString(Contrib[1]);
            s[2] = Convert.ToString(Contrib[2]);
            s[3] = Convert.ToString(Contrib[3]);
            s[4] = Convert.ToString(Contrib[4]);
            s[5] = Convert.ToString(Contrib[5]);
            s[6] = Convert.ToString(Contrib[6]);
            s[7] = Convert.ToString(Contrib[7]);
            s[8] = Convert.ToString(Contrib[8]);

            if (Contrib.Length == 9)
            {
                string c = s[0];

                if (c == null)
                {
                    throw new ArgumentNullException(nameof(Contrib));
                }

                if (s[0] == "1" || s[0] == "2" || s[0] == "5" || s[0] == "6" || s[0] == "9")
                {
                    long checkDigit = Convert.ToInt32(c) * 9;
                    int i;
                    for (i = 2; i <= 8; i++)
                    {
                        checkDigit = checkDigit + (Convert.ToInt32(s[i - 1]) * (10 - i));
                    }
                    checkDigit = 11 - (checkDigit % 11);
                    if ((checkDigit >= 10))
                        checkDigit = 0;
                    try
                    {
                        if ((checkDigit == Convert.ToInt32(s[8])))
                            functionReturnValue = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(StringsResource.UsedInvalidCharsError);
                    }
                }
            }
            return functionReturnValue;
        }

    }
}
