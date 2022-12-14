using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book__class_phone_
{
    public struct Contact
    {
        public Guid Id;
        public string FirstName;
        public string LastName;
        public string Group;
        public int Age;
        public long Number;
        public string Model;
        public int Weight;

        public Contact(int age, string firstName, string lastName, string group, long number, string model, int weight)
        {
            
            Id = Guid.NewGuid(); 
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Group = group;
            Number = number;
            Model = model;
            Weight = weight;

        }

        public string GetFirstName() 
        {
            return FirstName;
        }

        public string GetLastName() 
        {
            return LastName;
        }

        public int GetAge() 
        {
            return Age;
        }

        public long GetNumber() 
        {
            return Number;
        }

        public string GetModel() 
        {
            return Model;
        }

        public string GetGroup() 
        {
            return Group;
        }

        public int GetWeight() 
        {
            return Weight;
        }

        public override string ToString()
        {

            var printAllContacts = new StringBuilder();
            printAllContacts.AppendLine("Details of the phone number: ");
            printAllContacts.AppendLine($"Id: {Id}");
            printAllContacts.AppendLine($"Name: {FirstName}");
            printAllContacts.AppendLine($"Lastname: {LastName}");
            printAllContacts.AppendLine($"Group: {Group}");
            printAllContacts.AppendLine($"Age: {Age}");
            printAllContacts.AppendLine($"Phone number: {Number.ToString("+# (###) ### - ## - ##")}");
            printAllContacts.AppendLine($"Phone model: {Model}");

            return printAllContacts.ToString();
            


        }



    }
}
