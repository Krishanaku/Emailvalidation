using System.Text.RegularExpressions;

namespace EmailValidation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Email Validation :-All Sample validate ");
            string email = "abc@yahoo.com";

            if (Regex.IsMatch(email, @"^[a-zA-Z0-9@.]+$"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}