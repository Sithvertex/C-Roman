//1.Диапозон
int start = 100;
int stop = 999;

//2.Генерация числа из условий (100 999]
int value = new Random().Next(start,stop+1);

//3.Извлечение цифр
int digit_first = value % 100;
int digit_second = digit_first / 10;

//4.Вывод результата решения
 Console.WriteLine("Трех-значное число:" +value);
 Console.WriteLine("2-я цифра числа:" +digit_second);
 