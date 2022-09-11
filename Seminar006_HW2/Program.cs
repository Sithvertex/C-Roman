// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Танген угла наклона первой прямой k1=");
double k1 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b1 уравнение вида y = k1 * x + b1=");
int b1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Танген угла наклона первой прямой k2=");
double k2 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2 уравнение вида y = k2 * x + b2=");
int b2 = Int32.Parse(Console.ReadLine());

double x, y;

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллейны");
}
else if (1 + k1 * k2 == 0)
{
    Console.WriteLine("Прямые перпендикулярны");
}
else 
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine("Результат равен x= {0} y= {1}", x, y);
}