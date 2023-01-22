// найти максимальное число
//int a = 4;
//int b = 6;
//int c = 10;
//int d = 15;

//int max = a;

//if (b > max) max = b;
//if (c > max) max = c;
//if (d > max) max = d;

//Console.WriteLine("max = "); //выводит макс = 15, чтоб понимал пользователь
//Console.WriteLine(max);

// оператор цикла
//задача про точки алгоритм
//1. определить 3 точки, 2. выбрать2 любых, 3.найти середину,4 поставить точку,5выбрать случ-ю вершину треугольника,
//6.соединить ее с полученной точкой на 4 шаге точкой,7.перейти к шагу 3, 8. шаг 3-7 повторить n раз

//Console.SetCursorPosition(10, 4); // в качестве аргумента отступ левый край и верхний
//Console.WriteLine("+");  //будем рисовать +

int xa = 40;
int ya = 1;
int xb = 5;
int yb = 30;
int xc = 60;
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+"); 
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+"); 
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+"); 

int x = xa, y = xb; // определим случайную точку x и в нее положим xb 
int count = 0; //определим счетчик
while (count < 100000)
{
  int what = new Random().Next(0, 3); //сгенерируем случайное число
  if (what == 0)    //здесь делаем проверку
  {
     x = (x + xa) / 2;
     y = (y + ya) / 2;
  }

  if (what == 1)    
  {
     x = (x + xb) / 2;
     y = (y + yb) / 2;
  }

if (what == 2)    
   {
     x = (x + xc) / 2;
     y = (y + yc) / 2;
   }                                       // определили вершину 

Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;
}

