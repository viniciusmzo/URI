namespace _1478
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }

                int[,] matrix = new int[num, num];

                for (int i = 0; i < num; i++) 
                {
                    for (int j = 0; j < num; j++) 
                    {
                        matrix[i, j] = Math.Abs(i - j) + 1;
                    }
                }

                for (int i = 0; i < num; i++) 
                {
                    for (int j = 0; j < num; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write(matrix[i, j].ToString().PadLeft(3));
                        }
                        else 
                        {
                            Console.Write(matrix[i, j].ToString().PadLeft(4));
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
