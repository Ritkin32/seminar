
//Console.WriteLine("Привет, World"); // вывод в терминал

//Console.WriteLine("Введите ваше имя");
///string uzername = Console.ReadLine();
//Console.WriteLine("Приветик "); 
//Console.WriteLine(uzername);


//Console.WriteLine("Введите ваше имя");
///string uzername = Console.ReadLine();
//Console.Write("Приветик "); 
//Console.Write(uzername); //в 1 строку


//написать прог.в которой пользователь вводит 2 числа и получет их сумму целые числа
//int numberA = 4;
//int numberB = 5; 
//Console.WriteLine(numberA + numberB);

//int numberA = 4;
//int numberB = 5; 
//int rezalt = numberA + numberB; //можно было создать доп.переменную и в нее положить результат
//Console.WriteLine(rezalt);


//частное 2-х чисел

//double numberA = 11;   //вещественные числа int-целые числа
//double numberB = 5; 
//Console.WriteLine(numberA / numberB);

//bool -правда или ложь
//new Random().Next(min,max) генератор псевдослучайных чисел
//  % - остаток от деления
 //сумма чисел

//int numberA = new Random().Next(1,10); // от 1 до 9
//int numberB = new Random().Next(1,10); 
//int rezalt = numberA + numberB; //можно было создать доп.переменную и в нее положить результат
//Console.WriteLine(rezalt);


//int numberA = new Random().Next(1,10); 
//Console.WriteLine(numberA);
//int numberB = new Random().Next(1,10); 
//Console.WriteLine(numberB);
//int rezalt = numberA + numberB; //можно было создать доп.переменную и в нее положить результат
//Console.WriteLine(rezalt);


//double numberA = new Random().Next(1,10); 
//Console.WriteLine(numberA);
//double numberB = new Random().Next(1,10);
//Console.WriteLine(numberB);
//Console.WriteLine(numberA + numberB);

// приветствие любимчика

Console.Write("Введите имя пользователя: ");
string uzername = Console.ReadLine();

if (uzername.ToLower() == "маша") //маша с маленькой буквы в кавычках,тогда вводим Tolower перевод в нижний регистр
{
  Console.WriteLine("УРА, это же, Маша!");
}
else
{
  Console.WriteLine("Привет!"); 
  Console.WriteLine(uzername);
}