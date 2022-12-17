using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AddressBook
{
    public class AddressBookMain
    {

        public List<Contact> address = new List<Contact>();
        public Dictionary<string, List<Contact>> addressBook = new Dictionary<string, List<Contact>>();
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
            Contact contact = new Contact();
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
            CheckForDuplicacy(address, contact);
        }
        public void Edit()
        {
            Console.WriteLine("\nEnter Name whos detail your want to Edit");
            string name = Console.ReadLine();
            foreach (var contact in address)
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
                            contact.Zip = Convert.ToInt64(Console.ReadLine());

                            break;
                        case 5:
                            Console.WriteLine("Enter the updated Phone Number");
                            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

                            break;
                        case 6:
                            Console.WriteLine("Enter the updated Email Id");
                            contact.Email = Console.ReadLine();

                            break;
                        default:
                            Console.WriteLine("Try Again Later");
                            break;
                    }
                }
            }
        }
        public void Delete()
        {
            Console.WriteLine("\nEnter Name whos detail your want to Delete");
            string name = Console.ReadLine();
            foreach (var contact in address.ToList())
            {
                if (contact.FirstName.Equals(name))
                {
                    address.Remove(contact);
                }
                Console.WriteLine("Contact Deleted Successfully");
            }
        }
        public void CreateDictionaryContact()
        {
            Console.WriteLine("Enter name to add AddressBook");
            string name = Console.ReadLine();
            addressBook.Add(name, address);
            address = new List<Contact>();
        }
        public void DisplayDictionary()
        {
            foreach (var data in addressBook)
            {
                Console.WriteLine(data.Key);
                foreach (var contact in data.Value)
                {
                    Console.WriteLine(contact.FirstName + "\t" + contact.LastName);
                }
            }
        }
        public void CheckForDuplicacy(List<Contact> address, Contact contact)
        {
            if (address.Any())
            {
                if (address.Any(e => e.FirstName == contact.FirstName))//Lambda expression
                {
                    Console.WriteLine("A person with name {0} is already existed", contact.FirstName);
                    return;
                }
            }
            address.Add(contact);
        }
        public void SearchPersonInCityOrState()
        {
            Console.Write("Enter the city or state to search person : ");
            string serachCityOrState = Console.ReadLine();
            foreach (var data in addressBook)
                foreach (var personFind in data.Value.FindAll(x => x.City.Equals(serachCityOrState) || x.State.Equals(serachCityOrState)))
                    Console.WriteLine(personFind.FirstName + " " + personFind.LastName); //UC-9
        }
    }
}