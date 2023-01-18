//треугольник паскаля

const int cellWidth = 5; // то количество элем. буду использовать для вывода этого треугольника

void FillTriangle(int[,] pas)  // метод, который заполняет треугольник
{
    int side = pas.GetLength(0);

    for (int i = 0; i < side; i++) 
    {
        pas[i, 0] = 1; // заполнение  1столбика первый цикл пробегает по 1 столбику заполняе 1, 
        pas[i, i] = 1; //  и диагонали главной сооттветственно iзаполняется тоже 1
    }
    
    for (int i = 2; i < side; i++) //со второй строки заполняем, сумма текущего элемента = сумме того элемента над ним
      for (int j = 1; j <= i; j++)  //и того элемента который выше и левее
         pas[i, j] = pas[i - 1, j - 1] + pas[i - 1, j];
}   
      
   


void PrintTriangle(int[,] pas) //метод печати  
{
  int size = pas.GetLength(0);
  for (int i = 0; i < size; i++)
    {
     for (int j = 0; j < size; j++) 
      if (pas[i, j] != 0)   // все что не нулевое мы печатать будем
          Console.Write($"{pas[i, j], cellWidth}");  
     Console.WriteLine();
    }
}

 int row = 5;  // 5 строк
 int[,] pas = new int[row, row]; // массив
 int col = cellWidth * row;

FillTriangle(pas);

PrintTriangle(pas);

return;

