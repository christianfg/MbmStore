using System;
using System.Collections.Generic;
namespace MbmStore.Models
{
    public class Customer
    {
        private DateTime birthdate;
        private List<string> phoneNumbers = new List<string>();

        //Propeties
        public int PersonId
        {
            get; set;
        }
        public string Firstname
        {
            get; set;
        }
        public string Lastname
        {
            get; set;
        }
        public string Address
        {
            get; set;
        }
        public string Zip
        {
            get;set;
        }
        public string City
        {
            get; set;
        }
        public string Phonenumber
        {
            get; set;
        }
        public DateTime Birthdate {
            get; set;
        }
        //Constructor
        public Customer (string firstname, string lastname, string address, string zip, string city, string phonenumber)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Zip = zip;
            City = city;
            Phonenumber = phonenumber;
        }
        public Customer(int personId, string firstname, string lastname, string address, string zip, string city, string phonenumber)
        {
            PersonId = personId;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Zip = zip;
            City = city;
            Phonenumber = phonenumber;
        }
        //Method
        public void AddPhone(string phone)
        {
            phoneNumbers.Add(phone);
        }

    }
}