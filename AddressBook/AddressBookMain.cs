using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        Contact contact = new Contact();
        public List<Contact> address = new List<Contact>();
        public void Display()
        {
            foreach (var contact in address)
            {
                Console.WriteLine("\nContact Deatils :-" + "\n" + "First name :-" + contact.FirstName + "\n" + "Last name :-" + contact.LastName + "\n" + "Address :-" + contact.Address
                            + "\n" + "City name :-" + contact.City + "\n" + "State name :-" + contact.State + "\n" + "Zip code :-" + contact.Zip
                            + "\n" + "Phone number :-" + contact.PhoneNumber + "\n" + "Email Id :-\n" + contact.Email);
            }
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
        public void Edit()
        {
            Console.WriteLine("\nEnter Name whos detail your want to Edit");
            string name = Console.ReadLine();
            foreach (var contact in address)
            {
                if (address.Contains(contact))
                {
                    if (contact.FirstName.Equals(name))
                    {
                        Console.WriteLine("What do you want to edit :-");
                        Console.WriteLine("1. Address\n" + "2. City\n" + "3. State\n" + "4. Zip\n" + "5. Phone Number\n" + "6. Email Id\n");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter the updated Address");
                                contact.Address = Console.ReadLine();
                                Display();
                                break;
                            case 2:
                                Console.WriteLine("Enter the updated City");
                                contact.City = Console.ReadLine();
                                Display();
                                break;
                            case 3:
                                Console.WriteLine("Enter the updated State");
                                contact.State = Console.ReadLine();
                                Display();
                                break;
                            case 4:
                                Console.WriteLine("Enter the updated Zip Code");
                                contact.Zip = Convert.ToInt64(Console.ReadLine());
                                Display();
                                break;
                            case 5:
                                Console.WriteLine("Enter the updated Phone Number");
                                contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                                Display();
                                break;
                            case 6:
                                Console.WriteLine("Enter the updated Email Id");
                                contact.Email = Console.ReadLine();
                                Display();
                                break;
                            default:
                                Console.WriteLine("Try Again Later");
                                break;
                        }
                    }
                }
            }
        }
        public void Delete()
        {
            Console.WriteLine("\nEnter Name whos detail your want to Delete");
            string name = Console.ReadLine();
            foreach (var contact in address)
            {
                if (address.Contains(contact))
                {
                    if (contact.FirstName.Equals(name))
                    {
                        address.Remove(contact);
                    }
                    Console.WriteLine("Contact Deleted Successfully");
                }
            }
        }
    }
}