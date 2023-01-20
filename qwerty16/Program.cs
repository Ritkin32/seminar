//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.


int A(int n, int m)
            {
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return A(n - 1, 1);
                if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
                return A(n,m);
            }
Console.WriteLine("Введите m:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"M = {m}, N = {n} -> {A(m, n)}");

            Console.ReadLine();
