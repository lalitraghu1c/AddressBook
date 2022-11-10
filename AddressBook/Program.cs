using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Program Problem Statements\n");
            bool choice = true;
            AddressBookMain add = new AddressBookMain();
            while (choice)
            {
                Console.WriteLine("What to you want to do?\n");
                Console.WriteLine("1. Create a Contact\n2. Edit a Contact\n3. Delete a Contact\n4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("How many contact you want to create?\n");
                        int num = Convert.ToInt32(Console.ReadLine());
                        while (num > 0)
                        {
                            add.Create();
                            num--;
                        }
                        add.Display();
                        break;
                    case 2:
                        add.Edit();
                        add.Display();
                        break;
                    case 3:
                        add.Delete();
                        break;
                    default:
                        choice = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}