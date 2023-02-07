    namespace Question2b
    {
        class Program 
        {
            static void Main(string[] args)
            {
                AverageMinMax();
            }

            static void AverageMinMax()
            {
                int[] numbers = new int[5];
                int sum = 0;
                int min = int.MaxValue;
                int max = int.MinValue;

                Console.WriteLine("Enter 5 integer values:");
                for (int i = 0; i < 5; i++)
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    sum += numbers[i];
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }

                Console.WriteLine("Average: " + (sum / 5.0));
                Console.WriteLine("Smallest number: " + min);
                Console.WriteLine("Largest number: " + max);
            }
        }
    }
