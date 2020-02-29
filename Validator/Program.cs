using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pin Code Validator
            Console.WriteLine("Enter a pin. Note: your pin must be between 4 and 8 digits and be numbers only.");
            var pin = Console.ReadLine();
            if (pin.Length < 4 || pin.Length > 8)
            {
                Console.WriteLine("Oops, your pin is an incorrect length. Please try again.");
            }
            else
            {
                var pinValid = false;
                foreach (var character in pin)
                {
                    if (char.IsDigit(character))
                    {
                        pinValid = true;
                    }
                    else
                        pinValid = false;
                }
                if (pinValid)
                    Console.WriteLine("Your pin is valid");
                else
                    Console.WriteLine("Your pin is invalid, please try again");
            }
            Console.ReadKey();

            // Number Validator
            Console.WriteLine("Please enter your phone number, including area code");
            var phoneNum = Console.ReadLine();
            char[] charsToTrim = { '(', ')', ' ', '-' };
            string result = phoneNum.Trim(charsToTrim);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
