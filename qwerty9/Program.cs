 
 
 //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
 
 int[,] CreateIntArray(int m, int n)
        {
            Random rnd = new Random(); // генератор случайных чисел

            int[,] myArray = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    myArray[i, j] = rnd.Next(0, 11);
                }

            return myArray;
        }
Console.WriteLine("Введите m:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());

            var myArray = CreateIntArray(m, n);
            double[] mySumRowArray = new double[m];

            for (int i = 0; i < m; i++)
            {
                double sum = 0;
                Console.WriteLine();

                for (int j = 0; j < n; j++)
                {
                    sum += myArray[i, j];
                    Console.Write($"{myArray[i, j]}   ");
                }
                mySumRowArray[i] = Math.Round(sum / n, 2);
            }
            double min = double.MaxValue;
            Console.WriteLine();
            Console.WriteLine("среднее по строкам:");
                for (int i = 0; i < m; i++)
            {
                if(min > mySumRowArray[i])
                    min = mySumRowArray[i];
                Console.WriteLine($"{mySumRowArray[i]}");                
            }

            Console.WriteLine($"Минимальное: {min}");
            Console.ReadLine();