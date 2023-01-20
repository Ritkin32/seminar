
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка





int[,] CreateFillArray()
{
    Console.WriteLine("Введите количество строк и столбцов в таблице (ввод числа через enter): ");
    int[,] arr = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Random.Shared.Next(10);
            Console.Write($"|{arr[i, j],2} | ");
        }
        Console.WriteLine();
    }
    return arr;
}

int MinSumLine(int[,] array)
{
    int tempSum = 0; int tempMin = 0; int minLine = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }

        if (i == 0) { tempMin = tempSum; }
        if (tempSum < tempMin)
        {
            tempMin = tempSum;
            minLine = i;
        }
        Console.WriteLine($"Строка: {i} -> Сумма: {tempSum}; Строка с минимальной суммой: {minLine};");
        tempSum = 0;
    }
    return minLine;
}

int[,] arr = CreateFillArray();

Console.WriteLine("\nВывод для удобства: ");
Console.WriteLine("\nСтрока с минимальной суммой: " + MinSumLine(arr));