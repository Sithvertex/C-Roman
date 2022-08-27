// Напишите программу, которая принимает на 
// вход пятизначное число(ЗДЕСЬ я изменил для любого
// натуральног числа. Да простят меня Боги!!) и проверяет,
// является ли оно палиндромом.

// Введение исходных данных
Console.Write("Введите любое натуральное число  ");
string input = Console.ReadLine();
int length = input.Length;
int number = int.Parse(input);

// Задаем массив и переменые
int[] a = new int[length];
int[] b = new int[length];
int s, number_1,number_2,k,l;
s = 0;

// Разбиваем введеное число на числа и помещаем каждое
// в элемент массива и создаем обратный массив (для будущей
// проверки)
for (int i = 0; i < length; i++)
{
    s = Convert.ToInt32(Math.Pow(10, ((length-i)-1)));
    number_1 = number / s;
    number_2 = number % s;
    a[i] = number_1;
    k = (length-i)-1;
    b[k] = number_1;
    number = number_2;
}
//Функция типа 4 для вывода массивов
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}
//PrintArray(a);
//PrintArray(b);

l = 0;
for (int i = 0; i < length; i++)
{
    if ( a[i]== b[i])
    {
        l++;
        if (l == length)
        {
        Console.Write("Число является палиндромом");
        }
    }
}
if (l != length)
{
Console.Write("Число не является палиндромом");
}
// С выводом наверно можно было и проще, но 
//у меня времени просто не хватила :)