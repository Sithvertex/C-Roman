// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// Например
// m = 2, n = 3 -> A(m,n) = 29

string t = "";
Console.WriteLine("Введите размерность массива m*n (через пробел):");
t = Console.ReadLine();
string[] tv = t.Split(' ').ToArray();
int m = int.Parse(tv[0]);
int n = int.Parse(tv[1]);

int ackerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if ((a > 0) && (b == 0))
    {
        return ackerman(a - 1, 1);
    }
    else if ((a > 0) && (b > 0))
    {
        return ackerman(a - 1, ackerman(a, b - 1));
    }
    else
        return b + 1;
}

Console.WriteLine("Значение функции Аккермана = {0}", ackerman(m, n));