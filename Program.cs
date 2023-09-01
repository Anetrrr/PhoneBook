using System;
using System.ComponentModel;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the PhoneBook app!");
            Console.WriteLine("Select operation");
            Console.WriteLine("1 - Add contact");
            Console.WriteLine("2 - Display contact by number");
            Console.WriteLine("3 - View all contacts");
            Console.WriteLine("4 - Search for specific contact");
            Console.WriteLine("x - End operation");


            var userInput = Console.ReadLine();

            PhoneBook phonebook = new PhoneBook();

            while(true)
            {
                switch (userInput.ToLower())
                {
                    case "1":

                        Console.WriteLine("Enter contact name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter contact Number: ");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phonebook.AddContact(newContact);

                        break;

                    case "2":
                        Console.WriteLine("Enter contact number to search: ");
                        var contactNumber = Console.ReadLine();
                        phonebook.DisplayContact(contactNumber);
                        break;

                    case "3":
                        phonebook.GetAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Enter search term: ");
                        var searchString = Console.ReadLine();

                        phonebook.DisplaySearchContact(searchString);
                        break;
                    case "x":
                        return;
                        
                    default:
                        Console.WriteLine("Select a valid operation");
                        break;
                }

                Console.WriteLine("Select another operation");
                userInput = Console.ReadLine();

            }

           
        }

    }
}
