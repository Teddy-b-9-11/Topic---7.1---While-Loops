namespace Topic___7._1___While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin = 12345, entry, age;

            //while (true)
            //    Console.WriteLine("Are we there yet?");

            Console.WriteLine("Welcome to the Bank of Teddy.");
            Console.WriteLine("Enter your pin: ");
            int.TryParse(Console.ReadLine(), out entry);
            Console.WriteLine();

            while (entry != pin)
            {
                Console.WriteLine("Incorrect pin. Try again.");
                Console.WriteLine("Enter your pin: ");
                int.TryParse(Console.ReadLine(), out entry);
                Console.WriteLine();
            }

            Console.WriteLine("Pin accepted. You now have access to your account.");

            while (!int.TryParse(Console.ReadLine(), out age));
                Console.WriteLine("Please enter a vaild number. ");











        }
    }
}
