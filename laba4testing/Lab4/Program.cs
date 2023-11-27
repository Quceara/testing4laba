using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            Console.Write("Введите количество элементов массива: ");
        }

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i + 1}-й элемент массива: ");
            int element;
            while (!int.TryParse(Console.ReadLine(), out element) || element < -1000 || element > 1000)
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                Console.Write($"Введите {i + 1}-й элемент массива: ");
            }
            arr[i] = element;
        }

        Console.Write("Введите значение B: ");
        int B;
        while (!int.TryParse(Console.ReadLine(), out B))
        {
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            Console.Write("Введите значение B: ");
        }

        int countGreater = 0;
        int countLess = 0;
        int[] greaterIndexes = new int[n];
        int[] lessIndexes = new int[n];

        for (int i = 0; i < n; i++)
        {
            if (arr[i] > B)
            {
                greaterIndexes[countGreater] = i;
                countGreater++;
            }
            else if (arr[i] < B)
            {
                lessIndexes[countLess] = i;
                countLess++;
            }
        }

        Console.WriteLine("Количество элементов массива, больших B: " + countGreater);
        Console.WriteLine("Индексы элементов массива, больших B: ");

        for (int i = 0; i < countGreater; i++)
        {
            Console.Write(greaterIndexes[i] + " ");
        }
          
        Console.WriteLine();
        Console.WriteLine("Количество элементов массива, меньших B: " + countLess);
        Console.WriteLine("Индексы элементов массива, меньших B: ");

        for (int i = 0; i < countLess; i++)
        {
            Console.Write(lessIndexes[i] + " ");
        }

        Console.ReadKey();
    }
}
