namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersfor();
            PrintIntegersWhile();
            PrintIntegersDo();
            PrintExcudingFor();
            PrintDecendingFor();    
        }

        static void PrintIntegersfor()
        {
            for (int i = 40; i <= 60; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintIntegersWhile()
        {
            int i = 40;
            while (i <= 60)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void PrintIntegersDo()
        {
            int i = 40;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 60);
        }
        static void PrintExcudingFor()
        {
            for (int i = 40; i <= 60; i++)
                if (i != 46 && i != 48)
                {
                    Console.WriteLine();
                    i++;
                }
        }

        static void PrintDecendingFor()
        {
            for (int i = 60; i >= 40; i--)
               
                {
                    Console.WriteLine(i);
                }
        }
    }
}