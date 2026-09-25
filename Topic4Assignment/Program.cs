using System.Diagnostics;
using System.Xml.Linq;

namespace Topic4Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Who were you?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            username = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("An enscryption takes form: " + username);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();

            int age;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("How old were you?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Int32.TryParse(Console.ReadLine(), out age);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The enscryption grows crooked: " + age);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();

            double price;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("What was the price you paid?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out price);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            price = price / 2;
            Console.WriteLine("The enscryption tears itself asunder: " + price.ToString("C"));
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();

            string topping;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Your topping?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            topping = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("" + topping + " is certainly a choice, " + username + ".");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();

            string item;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Name of an item?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            item = Console.ReadLine();

            double itemPrice;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("And it's price?");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out itemPrice);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Three of this " + item + " you speak of would cost $" + itemPrice * 3 + ".");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();

            double diameter;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Diameter of a circle?");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out diameter);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The radius of your circle is " + diameter / 2 + ".");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();
            Part1();
            Part2();
        }

        public static void Part1()
        {
            string name;
            double age, salary;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Ignore him. What's your name?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("" + name + ". What's your age?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out age);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("" + age + ", right. How much do you make?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out salary);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("" + salary.ToString("C") + "? You're kidding, right?");
        }
        public static void Part2()
        {
            string firstName, lastName, login;
            double average;
            int grade, id;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("I'm The Green One I Need All Of Your Personal Information");
            Console.WriteLine("You Do Not Have A Choice In The Matter");
            Console.WriteLine("First Name");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            firstName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Last Name");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            lastName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("sto");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Student Login Username");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            login = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Grade, 1 - 29,724,955");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Int32.TryParse(Console.ReadLine(), out grade);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Student ID");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Int32.TryParse(Console.ReadLine(), out id);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Student Average");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out average);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("First Name:\t\t " + firstName);
            Console.WriteLine("Last Name:\t\t " + lastName);
            Console.WriteLine("Grade:\t\t " + grade);
            Console.WriteLine("Student ID:\t\t " + id);
            Console.WriteLine("Login:\t\t " + login);
            Console.WriteLine("Average:\t\t " + average);
            Console.WriteLine("You Have Three Minutes To Live");
            Console.WriteLine("Have A           Day");
        }
    }
    }   

