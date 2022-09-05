// Задача 1: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Введение исходных данных
Console.Write("Введите размерность массива N:");
int N = int.Parse(Console.ReadLine());

//Функция для вывода массива
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine();
}

int i =0;
int start = 100;
int stop = 999;
int[] b = new int[N];

int sum =0;

while(i < N)
{
    int input = new Random().Next(start,stop+1); 
    b[i] = input;

    if(input % 2 ==0)
        {
            sum++;
        }
    i++;
}   

 PrintArray(b);
 Console.WriteLine("Кол-во четных чисел в массиве. {0}", sum);
 