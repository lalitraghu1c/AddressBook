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
                Console.WriteLine("1. Create a Contact\n2. Edit a Contact\n3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add.Create();
                        add.Display();
                        break;
                    case 2:
                        add.Edit();
                        add.Display();
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