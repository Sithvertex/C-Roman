// Задача 1: Программа запрашивает натуральное число M, 
// пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 все-таки 4

Console.Write("ВВедите количества которые будете водить N:");
int N = int.Parse(Console.ReadLine());

int[] arr = new int[N];

int count=0;
Console.WriteLine("Введите N чисел через ввод:");
for(int i=0; i<N; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    if ( arr[i] > 0)
    {
        count++;
    }
}  
Console.WriteLine("Количество полож. введеных чисел. {0}", count);
