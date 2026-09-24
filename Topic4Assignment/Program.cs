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
        }
    }
}
