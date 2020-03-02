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
            var pinValid = false;

            while (!pinValid)
            {
                if (pin.Length < 4 || pin.Length > 8)
                {
                    Console.WriteLine("Oops, your pin is an incorrect length. Please try again.");
                    pin = Console.ReadLine();
                }
                else
                {
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
                    pin = Console.ReadLine();
                }
            }

            // Number Validator
            Console.WriteLine("Please enter your phone number, including area code");
            var phoneNum = Console.ReadLine();
            var validPhone = false;

            while (!validPhone)
            {
                char[] charsToTrim = { '(', ')', ' ', '-' };
                string[] result = phoneNum.Split(charsToTrim, StringSplitOptions.RemoveEmptyEntries);

                var phoneNoChars = "";
                foreach (var value in result)
                    phoneNoChars += value;

                var firstThreeNumbers = phoneNoChars.Substring(0, 3);

                if (phoneNoChars.Length != 10)
                {
                    Console.WriteLine("Oops! Looks like your phone number is the wrong length, please try again:");
                    phoneNum = Console.ReadLine();
                }
                else if (firstThreeNumbers == "555")
                {
                    Console.WriteLine("Oops! You area code is invalid, please try again:");
                    phoneNum = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your phone number is valid");
                    validPhone = true;
                }
            }


            // Email Validator
            Console.WriteLine("Please enter a valid email address");
            var email = Console.ReadLine();
            var validEmail = false;

            while (!validEmail)
            {
                string[] inputPieces = email.Split('@');
                if (inputPieces.Length != 2)
                {
                    Console.WriteLine("This email address is in the incorrect format, please try again");
                    email = Console.ReadLine();
                }
                else if (inputPieces[0].Length == 0 || inputPieces[1].Length < 3)
                {
                    Console.WriteLine("This email address is in the incorrect format, please try again");
                    email = Console.ReadLine();
                }
                else if (!inputPieces[1].Contains('.'))
                {
                    Console.WriteLine("This email address is in the incorrect format, please try again");
                    email = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your email is valid");
                    validEmail = true;
                }
            }

            // Spongebob
            Console.WriteLine("Are you mOcKiNg Me?!?!");
            var input = Console.ReadLine();
            var validMock = false;

            var isUpper = new bool[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                if (Char.IsUpper(input, i))
                {
                    isUpper[i] = true;
                }
                else
                    isUpper[i] = false;
            }
            for (var j = 0; j < input.Length; j++)
            {
                if (j % 2 == 0)
                {
                    if (isUpper[j] == true)
                        validMock = true;
                    else
                        validMock = false;
                }
                if (j % 2 != 0)
                {
                    if (isUpper[j] == false)
                        validMock = true;
                    else
                        validMock = false;
                }
            }
            if (validMock)
            {
                Console.WriteLine("sOoOoOoO rUde Of yOu");
                Console.ReadKey();
            }
            else
                Console.WriteLine("HaHa No You'Re NoT bUt I aM");
            Console.ReadKey();

            // Power Ranger
            Console.WriteLine("What's your secret identity?");
            var identity = Console.ReadLine(); 
            
            //Jason Lee Scott, Kimberly Hart, Zack Taylor, Trini Kwan and Billy Cranston

            switch (identity)
            {
                case "Jason Lee Scott":
                    Console.WriteLine("It's morphin time!");
                    break;
                case "Kimberly Hart":
                    Console.WriteLine("It's morphin time!");
                    break;
                case "Zack Taylor":
                    Console.WriteLine("It's morphin time!");
                    break;
                case "Trini Kwan":
                    Console.WriteLine("It's morphin time!");
                    break;
                case "Billy Cranston":
                    Console.WriteLine("It's morphin time!");
                    break;
                default:
                    Console.WriteLine("An imposter!");
                    break;
            }
            Console.ReadKey();

            //Palindrome......
            Console.WriteLine("Write a palindrome. Or don't, I don't care");
            var palin = Console.ReadLine();

            string firstHalf = palin.Substring(0, palin.Length / 2);
            char[] arr = palin.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string secondHalf = temp.Substring(0, temp.Length / 2);

            if (firstHalf.Equals(secondHalf))
                Console.WriteLine("Oh, a palindrome!");
            else
                Console.WriteLine("Boo you");

            Console.ReadKey();
        }
    }
}
