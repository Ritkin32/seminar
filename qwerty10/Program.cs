
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] array)   // заполнение массива
		{
	    for (int i = 0; i < array.GetLength(0); i++)
		    {
		       for (int j = 0; j < array.GetLength(1); j++)
             {
	              	array[i, j] = Random.Shared.Next(1, 10);
		         }
	       }
	  }
		
		void PrintArray(int[,] array) //печать
		  {
		     for (int i = 0; i < array.GetLength(0); i++)
		       {
		         for (int j = 0; j < array.GetLength(1); j++)
		         {
		             Console.Write($"{array[i, j]}; ");
		         }
		    Console.WriteLine("");
	       	}
		}
		

		void AverageColumn(int[,] array) // сумма и среднее арифм.
		   {
		     for(int i = 0; i < array.GetLength(1); i++)
		        {
	         	double tempSum = 0;
		          for(int j = 0; j < array.GetLength(0); j++)
		            {
		               tempSum += array[j, i];
	             	}
	    	Console.Write($"{Math.Round(tempSum / array.GetLength(0),2)}; ");
	        	}
		   }
		

		Console.WriteLine("Введите количество строк массива: ");
		int col = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите количество столбцов массива: ");
		int row = Convert.ToInt32(Console.ReadLine());
		

		int[,] arr = new int[col, row];
		FillArray(arr);
		

		
		Console.WriteLine("\nМассив: ");
		PrintArray(arr);
		
		Console.WriteLine("\nСреднее арифметическое: ");
		AverageColumn(arr);

	
