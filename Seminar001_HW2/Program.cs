int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.Write("Введите любое число 1 ");
int input1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое число 2 ");
int input2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое число 3 ");
int input3 = Convert.ToInt32(Console.ReadLine());

int max = Max(input1, input2, input3);

Console.Write("Макимальное число:" +max);