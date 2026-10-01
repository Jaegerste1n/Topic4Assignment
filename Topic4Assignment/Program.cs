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
            Part3();
            Part4();
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

        public static void Part3()
        {
            string name;
            double age;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("From the top. What is your name?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("" + name + ", wonderful.");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("And your age?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out age);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("In five years, you'd be " + (age + 5) + ". And five years before, you were " + (age - 5) + ".");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();

            double numberOne, numberTwo, numberThree;


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Beep; Boop. Give me a number.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out numberOne);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Beep. Boop; I said give me a number.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out numberTwo);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Beep, Boop; I SAID give me a NUMBER");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out numberThree);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The machine regurgitates. " + (numberOne + numberTwo + numberThree / 2) + ".");
        }
        public static void Part4()
        {
            string itemOne, itemTwo;
            double priceOne, priceTwo;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("A beckoning. An item's name:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            itemOne = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("A beckoning. Another item's name:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            itemTwo = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Yet a price:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out priceOne);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Yet another price:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out priceTwo);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            double both = priceOne + priceTwo;
            Console.WriteLine("There is no enscryption. ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Buy " + itemOne + " & " + itemTwo + " Together For Only $" + (priceOne + priceTwo) + "!, And With 20% Off That's $" + both * 0.8 + "!");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" And yet ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            double tax = both * 0.13;
            double final = both * 0.8 + tax;
            double discount = both * 0.2;
            double noDis = both + tax;
            Console.Write("But Taxes Would Be " + tax.ToString("C") + " So It Would Actually Be " + final.ToString("C") + "");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Receipt");
            Console.WriteLine("Item 1: " + itemOne + "");
            Console.WriteLine("Price: " + priceOne.ToString("C") + "");
            Console.WriteLine("Item 2: " + itemTwo + "");
            Console.WriteLine("Price: " + priceTwo.ToString("C") + "");
            Console.WriteLine("=================");
            Console.WriteLine("Total: " + noDis.ToString("C") + "");
            Console.WriteLine("Discount: " + discount.ToString("C") + "");
            Console.WriteLine("Tax: " + tax.ToString("C") + "");
            Console.WriteLine("=================");
            Console.WriteLine("Total Owed: " + final.ToString("C") + "");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("    Alright");
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

    }
}

       

