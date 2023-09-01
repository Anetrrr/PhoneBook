using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneBook
    {
        private List<Contact> _contacts {  get; set; } = new List<Contact>();

        private void DisplayOnContactDetails(Contact contact)
        {
            Console.WriteLine("Contact name: {0}, Contact number: {1}", contact.Name, contact.Number);
        }
        private void DisplayLoop(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayOnContactDetails(contact);
            }

        }
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);

            if(contact == null)
            {
                Console.WriteLine("Contact not available");
            } else
            {
                DisplayOnContactDetails(contact);
           }
        }

        public void GetAllContact()
        {
            DisplayLoop(_contacts);
        } 

        public void DisplaySearchContact(string searchString)
        {
            //searchString = Console.ReadLine();
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchString)).ToList();


            DisplayLoop(matchingContacts);

            
           
        }
    }
}   
