using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Phone_Book__class_phone_;


namespace Phone_Book__class_phone_
{


    public class Program
    {


        public static void Main(string[] args)
        {
            Run();

        }

        public static void Run()


        {
            var exitMenue = false;
            Console.WriteLine("Welcome to your phone, what do you want to do?");
            Phone phone = new Phone();

            while (!exitMenue)
            { // MENU
                Console.WriteLine("if you want to add a contact, press 1");
                Console.WriteLine("if you want to print every contact, press 2");
                Console.WriteLine("if you want to receive a call, press 3");
                Console.WriteLine("if you want to exit press 4");
                var temp = int.Parse(Console.ReadLine());
                switch (temp)
                {
                    case 1:

                        Console.WriteLine("You chose to add a contact");
                        Console.WriteLine("Please, insert contact's firstName");
                        var firstName = Console.ReadLine();
                        Console.WriteLine("Please, insert contact's lastName");
                        var lastName = Console.ReadLine();
                        Console.WriteLine("Please, insert contact's group");
                        var group = Console.ReadLine();
                        Console.WriteLine("Please, insert contact's age");
                        var age = Console.ReadLine();
                        Console.WriteLine("Please, insert contact's phone number");
                        var number = Console.ReadLine();
                        Console.WriteLine("Please, insert phone model");
                        var model = Console.ReadLine();
                        Console.WriteLine("Please, insert phone's weight");
                        var weight = Console.ReadLine();

                        phone.AddContact(Int32.Parse(age), firstName, lastName, group, Int64.Parse(number), model, Int32.Parse(weight));
                        break;

                    case 2:
                        Console.WriteLine("Here is the list of every contact");
                        phone.PrintPhoneBook();
                        break;
                    case 3:
                        Console.WriteLine("Someone is calling to you!");
                        phone.ReceiveCall();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        exitMenue = true;
                        break;
                    default:
                        Console.WriteLine("wrong option, please, try again");
                        break;
                }


            }
        }
    }
}
