// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
//  Не использовать функцию Math.Pow()
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine("Введите число A=");
int a = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите степень B=");
int b = Int32.Parse(Console.ReadLine());

int tmp;
tmp= 1;

for  (int i = 0; i < b; i++)
{
    tmp*=a;
}

Console.WriteLine(tmp);