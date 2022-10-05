using System;
using System.Dynamic;

class Program
{

    static void Main()
    {
        Console.WriteLine("Выберите программу, которую вы хотите запустить: ");
        Console.WriteLine("1. Угадай число");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("4. Закрыть программу");
        {
            string operation = Console.ReadLine();
            if (operation == "1")
            {
                game();
            }
            if (operation == "2")
            {
                table();
            }
            if (operation == "3")
            {
                procent();
            }
            if (operation == "4")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Введите верную операцию.");
                Program.Main();
            }
        }
    }
    static void game()
    {
        int answer;
        Console.WriteLine("Угадай число от 1 до 100!");
        Random rnd = new Random();
        int num = rnd.Next(1, 100);
        while (true)
        {
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer < num)
            {
                Console.WriteLine("Нужно число больше. ");
            }
            if (answer > num)
            {
                Console.WriteLine("Нужно число меньше. ");
            }
            if (answer == num)
            {
                Console.WriteLine("Вы угадали!"); Program.Main();
            }
        }
    }
    static void table()
    {
        int[,] array = new int[10, 10];
        for (int i = 1; i < array.GetLength(0); i++)
        {
            for (int a = 1; a < array.GetLength(1); a++)
            {
                array[i, a] = i * a;
            }
        }
        for (int i = 1; i < array.GetLength(0); i++)
        {
            for (int a = 1; a < array.GetLength(1); a++)
            {
                Console.Write(array[i, a] + " ");
            }
            Console.WriteLine();
        }
        Main();
    }
    static void procent()
    {
        Console.WriteLine("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.WriteLine(i);
        }
        Program.Main();
    }
}