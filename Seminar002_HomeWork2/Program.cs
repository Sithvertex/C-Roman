//1.Диапозон
int start = 1;
int stop = 65536;
int digit, number;

//2.Генерация числа из условий (1 65536]
int value = new Random().Next(start,stop+1);

//3.Извлечение цифр и вывод числа
if (value >= 100)
{
    if (value < 10000)
    {
        if (value < 1000)
        {
            digit = value % 10;
            Console.WriteLine("Сгенирированое число:" +value);
            Console.WriteLine("3-я цифра числа:" +digit);
        }
        else
        {
        number = value % 100;
        digit = number / 10;
        Console.WriteLine("Сгенирированое число:" +value);
        Console.WriteLine("3-я цифра числа:" +digit);
        }

    }
    else
    {
    number = value % 1000;
    digit = number / 100;
    Console.WriteLine("Сгенирированое число:" +value);
    Console.WriteLine("3-я цифра числа:" +digit);
    }

}
else
{
Console.WriteLine("3-я цифра числа отсутствует");
}

// Жаль, что нельзя использовать пока функцию