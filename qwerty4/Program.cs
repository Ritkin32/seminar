
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

// 1. Ввод числа
int InputInt(string text)   
{
    return Convert.ToInt32(text);
}

// 2. Создание массива

int[] CreatArray(int length)  
{
    int[] array = new int[length];
    return array;
}

// 3. Заполнение массива
void FillArray(int[] array) 
{
    for (int index = 0; index < array.Length; index++)
    {
       array[index] = InputInt(Console.ReadLine());
    }
}

// 4. Печать массива
string PrintArray(int[] array)   
{
    string output = String.Empty;
    for (int newIndex = 0; newIndex < array.Length; newIndex++)
    {
       output = output + " " + array[newIndex];
    }
    return output;
}

// 5. Подсчёт чисел
int CountNumb(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите длину массива: ");
int[] array = CreatArray(InputInt(Console.ReadLine()));
Console.WriteLine("Введите элементы массива: " );
FillArray(array);
Console.WriteLine(PrintArray(array));
Console.WriteLine("Количество элементов больше 0: " + CountNumb(array));