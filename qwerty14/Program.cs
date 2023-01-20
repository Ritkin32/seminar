
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

void MyTask1(int n)
        {
            if(n == 0)
                return;

            if (n == 1)
                Console.Write($"{n}");
            else
                Console.Write($"{n}, ");

            MyTask1(n - 1);
        }
Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"N = {n} -> ");
            MyTask1(n);

            Console.ReadLine();