using System.Security.Cryptography.X509Certificates;

namespace Lab2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();

            Console.WriteLine("Lab 2 CSharp");
        }
        public static void task1()
        {
            Console.Write("Введіть розмір масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Індекси елементів, які не діляться на 7:");
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
        public static void task2()
        {
            Console.Write("Введіть кількість рядків: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Введіть кількість стовпців: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, cols];

            Console.WriteLine("Введіть елементи масиву:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Індекси елементів, які не діляться на 7:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (array[i, j] % 7 != 0)
                    {
                        Console.WriteLine($"[{i}, {j}]");
                    }
                }
            }
        }


       public static void task3()
        {
            int[,] matrix =
            {
            { 1, 2, 3 },
            { 2, 4, 5 },
            { 3, 5, 6 }
        };

            int n = matrix.GetLength(0);
            bool isSymmetric = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        isSymmetric = false;
                        break;
                    }
                }
                if (!isSymmetric) break;
            }

            Console.WriteLine(isSymmetric ? "Матриця симетрична" : "Матриця не симетрична");
        }

        public static void task4()
        {
            int[][] array =
            {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6, 7, 8 },
            new int[] { 9, 10, 11, 12 }
        };

            int[] X = { 100, 200, 300 }; // Вектор X для заміни парних стовпців

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array[i].Length; j += 2) // Парні стовпці (1, 3...)
                {
                    array[i][j] = X[i];
                }
            }

            foreach (var row in array)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
