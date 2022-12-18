using System;

namespace RegexUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UR1
            //Console.WriteLine("Welcome to Regular Expression");
            //Console.WriteLine("Enter your first name");
            //string FirstName = Console.ReadLine(); // Creating user input for first name
            //Validation.FirstNameValidation(FirstName);//Calling method to validate firstname

            //UR2
            //Console.WriteLine("Enter your Last name");
            //string LName = Console.ReadLine(); //  input for last name
            //LastName.LastNameValidation(LName);

            //UR3
            //Console.WriteLine("\n\nEnter your email name : ");
            //string email = Console.ReadLine();
            //bool checkEmail = Email.EmailValidation(email); //Calling method to check email 

            //UR4
            //Console.Write("Enter The Mobile Number:");
            //String mob = Console.ReadLine();

            //if (MobileNumber.validate(mob))
            //{
            //    Console.WriteLine("Valid Data");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Data");
            //}

            //UR5
            //Console.Write("Enter The Password:");
            //String pass = Console.ReadLine();

            //if (Password8Char.validate(pass))
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //UR6
            Console.Write("Enter The Password:");
            String pass = Console.ReadLine();

            if (Password_1_Uppercase.validate(pass))
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
