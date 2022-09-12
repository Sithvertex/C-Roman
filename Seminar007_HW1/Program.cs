// Задача 1. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными (тип double) числами.

Console.Write("Введите размерность массива строк M:");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите размерность массива столбцов N:");
int N = int.Parse(Console.ReadLine());

//Функция для вывода массива
void PrintArray(double[,] array)
{
    int count1 = array.GetLength(0);
    int count2 = array.GetLength(1);

    for (int i = 0; i < count1; i++)
    {
        for (int j = 0; j < count2; j++)
        {
            Console.Write("{0,6:F2}", array[i, j]);
            //Console.Write("{0,6:F2}"{array[i, j]});
        }
        Console.WriteLine();
    }
}

double[,] a = new double[M, N];

Random random = new Random();
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        a[i, j] = random.NextDouble() * 100;
    }
}
PrintArray(a);