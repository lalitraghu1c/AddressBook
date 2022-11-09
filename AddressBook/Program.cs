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
                AddressBookMain create = new AddressBookMain();
                Console.WriteLine("Welcome to Address Book Problem Statement\n");
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1. Create a new Contact \n2. Edit a Contact \n3. Delete a Contact \n4. Exit \n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter your details :-\n");
                        create.Create();
                        break;
                    case 2:
                        Console.WriteLine("\nEnter your details :-\n");
                        create.Edit("Lalit");
                        break;
                    case 3:
                        Console.WriteLine("\nEnter your details :-\n");
                        
                        Console.WriteLine("\nEnter name whose detail you want to delete :-\n");
                        create.Delete("Lalit");
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