using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер квадратной матрицы: ");
            int r = Convert.ToInt16(Console.ReadLine());
            int[,] Matrix = new int[r, r];
            Random random = new Random();    
            
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Matrix[i, j] = random.Next(-10, 10);
                    Console.Write("{0}\t", Matrix[i, j]);
                }
                Console.WriteLine();
            }

            int a = -1, sum = -1, sum1 = -1; 
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    if (Matrix[i, j] < 0)
                    {
                        a = j;
                        sum = 0;
                    }

                    sum1 += Matrix[i, j];
                }

                for (int j = 0; j < a; j++)
                    sum += Matrix[i, j];

                Console.WriteLine($"В строке {i+1} сумма до последнего отрицательного элменета {sum}");
                a = sum = sum1 = -1;
            }

            Console.ReadLine();
        }
    }
}
