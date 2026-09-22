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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();

            int age;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("How old were you?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Int32.TryParse(Console.ReadLine(), out age);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The enscryption grows crooked: " + age);

            double price;
            Console.WriteLine("What was the price you paid?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            double.TryParse(Console.ReadLine(), out price);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The enscryption tears itself asunder: " + price.ToString("C"));
        }
    }
}
