// Задача 2: Задайте две квадратные матрицы одного размера.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите размерность квадратной матрицы N:");
int n = int.Parse(Console.ReadLine());

int start = 1;
int stop = 10;
int[,] a = new int[n, n];
int[,] b = new int[n, n];
int[,] c = new int[n, n];

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

FillArray(a);
FillArray(b);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        int f = 0;
        for (int k = 0; k < n; k++)
        {
            f = f + a[i, k] * b[k, j];
        }
        c[i, j] = f;
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

PrintArray2(a);
Console.WriteLine();
PrintArray2(b);
Console.WriteLine("Итоговая матрица перемножения");
PrintArray2(c);
