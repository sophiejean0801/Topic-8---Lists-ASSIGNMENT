namespace Topic_8___Lists_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1
            
            Random number = new Random();
            List<string> colour = new List<string>();
            int inNumber, listSize, maxNumber, minNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a colour:");
                string input = Console.ReadLine();
                colour.Add(input);
            }
            Console.WriteLine("The colours you entered are:");
            Console.Write(string.Join(", ", colour));
            Console.ReadLine();
            Console.WriteLine("The random one is: ");
            Console.WriteLine(colour[number.Next(colour.Count)]);

            // Assignment 2

            List<int> numbers = new List<int>();
            Console.WriteLine("Enter a number: ");
            inNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the size of the list:");
            listSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum number:");
            maxNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minimum number:");
            minNumber = Convert.ToInt32(Console.ReadLine());




        }
    }
}
