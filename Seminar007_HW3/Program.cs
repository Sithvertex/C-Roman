// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

string t = "";
Console.WriteLine("Введите размерность массива n*m (через пробел):");
t = Console.ReadLine();
string[] tv = t.Split(' ').ToArray();
int n = int.Parse(tv[0]);
int m = int.Parse(tv[1]);

int start = 10;
int stop = 99;
double temp;
int[,] a = new int[n, m];
double[] b = new double[m];

//Функция заполнения масива двухмерного масива
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

//Функция для вывода двухмерного массива
void PrintArray2(int[,] array)
{
    int count1 = array.GetLength(0);
    int count2 = array.GetLength(1);

    for (int i = 0; i < count1; i++)
    {
        for (int j = 0; j < count2; j++)
        {
            Console.Write($" {array[i, j]},");
        }
        Console.WriteLine();
    }
}

//Функция для вывода одномерного массива
void PrintArray1(double[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine();
}

FillArray(a);

for (int j = 0; j < m; j++)
{
    temp = 0;
    for (int i = 0; i < n; i++)
    {
        temp = temp + a[i, j];        
    }
    b[j] = temp / n;
}

PrintArray2(a);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце");
PrintArray1(b);
