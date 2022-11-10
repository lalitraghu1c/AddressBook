﻿using System;
namespace AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long ZipCode { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailID { get; set; }
    }
}