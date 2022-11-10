using System;
using System.Security.Cryptography.X509Certificates;

namespace AddressBook
{
    public class AddressBookMain
    {
        public Contact contact = new Contact();
        public List<Contact> address = new List<Contact>();
        public void Display()
        {
            Console.WriteLine("\nFirst Name - " + contact.FirstName + "\nLast Name - " + contact.LastName + "\nAddress - " + contact.Address +
                "\nCity Name - " + contact.City + "\nState Name - " + contact.State + "\nZip Code - " + contact.ZipCode +
                "\nPhone Number - " + contact.PhoneNumber + "\nEmail ID - " + contact.EmailID);
        }
        public void Create()
        {
            Console.WriteLine("Enter Detail of the contact -\n");
            Console.WriteLine("Enter your First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address Name");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter your City Name");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State Name");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code");
            contact.ZipCode = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Id");
            contact.EmailID = Console.ReadLine();
            address.Add(contact);
        }
        public void Edit()
        {
            Create();
            Console.WriteLine("\nEnter the name of the person whose contact detail you want to edit?\n");
            string name = Console.ReadLine();
            foreach (var contact in address)
            {
                if (address.Contains(contact))
                {
                    if (contact.FirstName == name)
                    {
                        Console.WriteLine("What do you want to edit");
                        Console.WriteLine("1. Address\n2. City\n3. State\n4. Zip Code\n5. Phone Number\n6. Email ID\n");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the updated Address");
                                contact.Address = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the updated City");
                                contact.City = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter the updated State");
                                contact.State = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter the updated Zip Code");
                                contact.ZipCode = Convert.ToInt64(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter the updated Phone Number");
                                contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Enter the updated Phone Number");
                                contact.EmailID = Console.ReadLine();
                                break;
                        }
                    }
                }
            }
        }
    }
}