using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    string pal = string.Empty;
                    Console.WriteLine("Enter text to see if it's a palindrome:" + "(Enter q to quit)");
                    pal = Console.ReadLine();

                    if (pal.ToUpper().Equals("Q"))
                        break;
                    string NotPal = GetStringReversed(pal);
                    
                    if (pal.ToLower().Equals(NotPal.ToLower()))
                    {
                        Console.WriteLine("Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("Not a Palindrome");
                    }
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine("General Exception Thrown" + ex.Message);
            }
        }
        public static string GetStringReversed(string input)
        {
            char[] sentence = input.ToCharArray();
            Array.Reverse(sentence);
            return new string(sentence);
        }
    }
}
