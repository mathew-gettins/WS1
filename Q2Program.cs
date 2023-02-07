namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 5 numbers");
            int count = CountOddNumbers(); // We are going to call the method and print the result
            Console.WriteLine($"{count} of them are odd"); //statement takes the value returned by the CountOddNumbers() method and adds the text
        }
        static int CountOddNumbers()
        {
            int count = 0;  // This variable will be used to keep track of how many odd numbers have been entered

            for (int i = 0; i < 5; i++) // We are going to repeat the following steps 5 times
            {
                int num = int.Parse(Console.ReadLine());  // We are going to read a number from the console

                if (num % 2 != 0)  // We are going to check if the number is odd
                {
                    count++;   // If it is, we will add 1 to our count
                }
            }
             return count;
        }   
    }   
}