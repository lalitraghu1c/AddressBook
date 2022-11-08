using System;
namespace AddressBook
{
    public class program
    {
        public static void Main(string[] args)
        {
            bool condition = true;
            while (condition)
            {
                Console.WriteLine("Welcome to Address Book Problem Statement\n");
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1. Create a new Contact \n2. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your details :-\n");
                        Console.WriteLine("First Name - " + "\n" + "Last Name - " + "\n" + "Address - " + "\n" +
                                        "City Name - " + "\n" + "State Name - " + "\n" + "Zip Code - " + "\n" +
                                        "Phone Number - " + "\n" + "Email ID - ");
                        AddressBookMain create = new AddressBookMain();
                        create.Create();
                        break;
                    default:
                        Console.WriteLine("Try Again");
                        condition = false;
                        break;
                }
            }
        }
    }
}