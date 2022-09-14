// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка

string t = "";
Console.WriteLine("Введите размерность массива n*m (через пробел):");
t = Console.ReadLine();
string[] tv = t.Split(' ').ToArray();
int n = int.Parse(tv[0]);
int m = int.Parse(tv[1]);

int start = 1;
int stop = 10;
double min;
int[,] a = new int[n, m];
double[] b = new double[n];

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

//Функция вычисления ариф. по строке
void CalculateMeanColumns(int[,] array)
{ 
    int count1 = array.GetLength(0);
    int count2 = array.GetLength(1);
    double temp;
    for (int i = 0; i < (count1); i++)
    {
        temp = 0;
        for (int j = 0; j < (count2); j++)
        {
            temp = temp + array[i,j];
        }
        b[i] = temp;
    }

}

CalculateMeanColumns(a);

//Функция для сортировки чисел в матрице от мин. до мах
void SelectionSort(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }

        double temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

SelectionSort(b);

min = b[0];

CalculateMeanColumns(a);

for (int i=0; i< n; i++)
{
    if( min == b[i])
    {
     Console.WriteLine("Минимальное значение наименьшей суммой элементов в строке h= {0}", i+1);
    }
}

PrintArray2(a);
Console.WriteLine("Сумма элементов по строкам");
PrintArray1(b);
