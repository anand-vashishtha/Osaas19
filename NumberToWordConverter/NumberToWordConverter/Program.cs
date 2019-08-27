using System;

namespace SampleUtilityApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;

            try
            {
                ConsoleKeyInfo cki;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Please type integer between 0 to 1000000000");
                    input = Console.ReadLine();
                    int typedInt = Int32.Parse(input);

                    if (typedInt >= 0 && typedInt < 1000000000)
                    {
                        Console.WriteLine(Utility.NumberToWordsConverter(typedInt));
                    }
                    else
                    {
                        Console.WriteLine("Typed integer is beyond the range");
                    }

                    Console.WriteLine("Press the Escape (Esc) key to quit or press any key to continue: \n");
                    cki = Console.ReadKey();


                } while (cki.Key != ConsoleKey.Escape);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown exception");
            }
        }

        
    }
}
