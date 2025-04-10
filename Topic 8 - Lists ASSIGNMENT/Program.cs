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
            bool done = false;

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
            Console.WriteLine("Enter the size of the list:");
            listSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minimum number:");
            minNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum number:");
            maxNumber = Convert.ToInt32(Console.ReadLine());
            if (minNumber >= maxNumber)
            {
                minNumber = maxNumber;
                maxNumber = minNumber;
                Console.WriteLine("Your maximum and minimum are the same.");
            }
            for (int i = 0; i < listSize; i++)
            {
                numbers.Add(number.Next(minNumber, maxNumber));
            }
            Console.WriteLine("The numbers in the list are:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("From the numbers shown, which one do you choose? I will count how many times it shows up in the list.");
            inNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == inNumber)
                {
                    Console.WriteLine("The number " + inNumber + " shows up " + numbers.Count(x => x == inNumber) + " times.");
                }
                
            }
            Console.WriteLine("Pick a number from the list to turn into 0");
            inNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == inNumber)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine("The numbers in the list are:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(numbers.Count(x => x == 0) + " numbers were changed to 0.");
            Console.WriteLine("The numbers in the list are:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("Lets make a new list!");
            List<int> numbers2 = new List<int>();
            listSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the minimum number:");
            minNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum number:");
            maxNumber = Convert.ToInt32(Console.ReadLine());
            if (minNumber >= maxNumber)
            {
                minNumber = maxNumber;
                maxNumber = minNumber;
                Console.WriteLine("Your maximum and minimum are the same.");
            }
            for (int i = 0; i < listSize; i++)
            {
                numbers.Add(number.Next(minNumber, maxNumber));
            }
            Console.WriteLine("The numbers in the list are:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }










        }
    }
}
