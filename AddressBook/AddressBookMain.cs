using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> address = new List<Contact>();
        public Contact contact = new Contact();
        public void Display()
        {
            Console.WriteLine("\nFirst Name - " + contact.FirstName + "\nLast Name - " + contact.LastName + "\nAddress - " + contact.Address +
                "\nCity Name - " + contact.City + "\nState Name - " + contact.State + "\nZip Code - " + contact.Zip +
                "\nPhone Number - " + contact.PhoneNumber + "\nEmail ID - " + contact.Email);
        }
        public void Create()
        {
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
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Id");
            contact.Email = Console.ReadLine();
            address.Add(contact);
            Display();
        }
        public void Edit(string name)
        {
            foreach (var contact in address)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    Console.WriteLine("\nWhat do you want to edit ?");
                    Console.WriteLine("1. Address \n2. City \n3. State \n4. Zip Code \n5. Phone Number \n6. Email Id \n");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter your updated Address!");
                            contact.Address = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter your updated City!");
                            contact.City = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter your updated State!");
                            contact.State = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter your updated Zip code!");
                            contact.Zip = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Enter your updated Phone Nummber!");
                            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter your updated Email Id!");
                            contact.Address = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Try Again");
                            break;
                    }
                    Display();
                }
            }
        }
        public void Delete(string name)
        {
            if (contact.FirstName == name || contact.LastName == name)
            {
                address.Remove(contact);
            }
            Console.WriteLine("Contact Deleted Successfully");
        }
    }
}