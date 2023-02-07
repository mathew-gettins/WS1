namespace Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double totalReceipt = 0.0;
            bool repeat = true;

            while (repeat)
            {
                Console.Write("Enter number of hours? (-999 to quit) :");
                int hours = int.Parse(Console.ReadLine());

                if (hours == -999)
                {
                    repeat = false;

                    break;
                }
                double cost = CalaculateCharge(hours);
                totalReceipt += cost;

                Console.Write($"customer charge: \u20ac{cost} \t          Total Receipt: \u20ac{totalReceipt}");
                Console.WriteLine();
            }
        }

        static double CalaculateCharge(int Hours)

        {
            double minFee = 2.00;
            double perHourFee = 0.5;

            if (Hours <= 3)
            {
                return minFee;
            }
            else if (Hours > 3 && Hours < 19)
            {
                return (Hours - 3) * perHourFee + minFee;
            }
            else
            {
                return (10);
            }
        }
    }
}