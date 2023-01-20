//Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.

int MyTask2(int m, int n)
        {
            if (m == n)
                return n;

            return m + MyTask2(m + 1, n);
        }
Console.WriteLine("Введите m:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (m < n)
                Console.WriteLine($"M = {m}, N = {n} -> {MyTask2(m, n)}");
            else
                Console.WriteLine($"m должно быть меньше n");
            Console.ReadLine();