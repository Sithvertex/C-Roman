// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

string t = "";
Console.WriteLine("Введите размерность массива n*m (через пробел):");
t = Console.ReadLine();
string[] tv = t.Split(' ').ToArray();
int n = int.Parse(tv[0]);
int m = int.Parse(tv[1]);

int start = 1;
int stop = 10;

int[,] a = new int[n, m];
int[] b = new int[m];

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

//Функция для сортировки чисел в матрице от мах. до мин.
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
                maxPosition = j;
        }

        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

FillArray(a);

PrintArray2(a);

for (int i = 0; i < a.GetLength(0); i++)
{

    for (int k = 0; k < a.GetLength(1); k++)
    {
        b[k] = a[i, k];
    }

    SelectionSort(b);

    for (int l = 0; l < a.GetLength(1); l++)
    {
        a[i, l] = b[l];
    }
}
Console.WriteLine("Отсортированый массив по убыванию:");
PrintArray2(a);
