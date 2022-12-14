using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Phone_Book__class_phone_
{
    public class Phone
    {
        private Contact[] ContactList = new Contact[3];
        private int TotalAmountOfContacts = 0;



        public void AddContact(int age, string firstName, string lastName, string group, long number, string model, int weight)
        {
            var position = TotalAmountOfContacts;
            var contact = new Contact(age, firstName, lastName, group, number, model, weight);
            ContactList[position] = contact;
            TotalAmountOfContacts += 1;
        }

        public void PrintPhoneBook()
        {
            foreach (var contact in ContactList)
            {
                Console.WriteLine("Contact list is:" + contact.ToString());

            }
        }


      

        public void ReceiveCall()
        {
            Console.WriteLine($"вонит");

        }
    }


}
