// Задача 2. Напишите программу, которая на вход принимает позиции (две) 
// элемента в двумерном массиве, и возвращает значение этого элемента
//  или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет 

string t = "";
Console.WriteLine("Введите строку и столбец элемента в массиве n*m (через пробел):");
t = Console.ReadLine();
string[] tv = t.Split(' ').ToArray();
int n = int.Parse(tv[0]);
int m = int.Parse(tv[1]);

int k = 5;
int l = 5;
int start = 1;
int stop = 99;

int[,] a = new int[k, l];

//Функция заполнения масива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(start, stop + 1);
        }
    }
}

//Функция для вывода массива
void PrintArray(int[,] array)
{
    int count1 = array.GetLength(0);
    int count2 = array.GetLength(1);

    for (int i = 0; i < count1; i++)
    {
        for (int j = 0; j < count2; j++)
        {
            Console.Write($" {array[i,j]},");
        }
        Console.WriteLine();
    }
}

FillArray(a);
PrintArray(a);

if ( n > (k-1) && m > (l-1))
{
   Console.WriteLine("Вышли за пределы массива"); 
}
else
{
Console.Write("Значение элемента равно =");
Console.Write(a[n,m]);
}
