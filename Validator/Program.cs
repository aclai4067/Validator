using System;
using System.Text;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pin Code
            Console.WriteLine("Enter a 4-8 digit numeric pin");
            var userPin = Console.ReadLine();
            var PinIsValid = false;
            int n;
            if (userPin.Length > 3 && userPin.Length < 9)
            {
                if (int.TryParse(userPin, out n))
                {
                    PinIsValid = true;
                }
            }
            Console.WriteLine($"Valid Pin? {PinIsValid}");
            Console.ReadKey();

            //Phone Number
            Console.WriteLine("Enter your phone number with area code");
            var UserPhone = Console.ReadLine();
            StringBuilder phoneString = new StringBuilder();
            var PhoneIsValid = false;
            int i;
            foreach (var character in UserPhone)
            {
                if (character == '(' || character == ')' || character == ' ' || character == '-')
                {
                    continue;
                }
                if (int.TryParse(character.ToString(), out i))
                {
                    phoneString.Append(character);
                }
                else
                {
                    Console.WriteLine($"Valid Phone Number? {PhoneIsValid}");
                    Console.ReadKey(); 
                    return;
                }
            }
            if (phoneString.Length == 10 && ($"{phoneString[3]}{phoneString[4]}{phoneString[5]}" != "555"))
            {
                PhoneIsValid = true;
            }

            Console.WriteLine($"Valid Phone Number? {PhoneIsValid}");
            Console.ReadKey();
        }
    }
}
