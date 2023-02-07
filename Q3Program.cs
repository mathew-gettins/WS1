namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle();
            PrintTriangleUpsideDown();
            PrintTriangleGeneral(5);
            PrintTriangleGeneralCharacter(5, '#');
        }

        static void PrintTriangle()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangleUpsideDown()
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangleGeneral(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangleGeneralCharacter(int rows, char character)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(character + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
