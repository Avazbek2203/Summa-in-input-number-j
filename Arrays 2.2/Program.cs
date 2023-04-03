
using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.Write("Enter rows length : ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter columns length : ");
        int column = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arr[i, j] = random.Next(1, 10);
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int k;
        Console.Write("Enter k number : ");
        k = Convert.ToInt32(Console.ReadLine());

        int summa = 0;
        int multiplication = 1;

        for (int j = 0; j < column; j++)
        {
            summa += arr[j, k];
            multiplication *= arr[j, k];
        }

        Console.WriteLine($"Summa : {summa}");
        Console.WriteLine($"Multiplication : {multiplication}");
    }
}
