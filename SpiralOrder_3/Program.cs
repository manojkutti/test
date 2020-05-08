using System;

namespace SpiralOrder_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            int printValue = 1;
            int c1 = 0, c2 = n - 1;
            while (printValue <= n * n)
            {
                //Right Direction Move  
                for (int i = c1; i <= c2; i++)
                    a[c1, i] = printValue++;
                //Down Direction Move  
                for (int j = c1 + 1; j <= c2; j++)
                    a[j, c2] = printValue++;
                //Left Direction Move  
                for (int i = c2 - 1; i >= c1; i--)
                    a[c2, i] = printValue++;
                //Up Direction Move  
                for (int j = c2 - 1; j >= c1 + 1; j--)
                    a[j, c1] = printValue++;
                c1++;
                c2--;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}  
       