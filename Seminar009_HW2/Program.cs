// Задача 2. Напишите программу, которая заполнит спирально двумерный массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Указание:
// При заполнении массива использовать циклы.

Console.Write("Введите размерность квадратной матрицы N:");
int N = int.Parse(Console.ReadLine());

int[,] a = new int[N, N];

if (N==1)
{
    Console.Write("Создание спиральной матрицы невозможно т.к деленние на ноль");
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

for (int k = 0; k < N; k++)
{
    for (int l = 0; l < N; l++)
    {
        int i = k + 1;
        int j = l + 1; 
        int switcher = (j - i + N) / N;
        int Hc = Math.Abs(i - N / 2 - 1) + (i - 1) / (N / 2) * ((N - 1) % 2);
        int Gc = Math.Abs(j - N / 2 - 1) + (j - 1) / (N / 2) * ((N - 1) % 2);
        int Ring = N / 2 - (Math.Abs(Hc - Gc) + Hc + Gc) / 2;
        int Xs = i - Ring + j - Ring - 1;
        int Coef = 4 * Ring * (N - Ring);
        a[k,l] = Coef + switcher * Xs + Math.Abs(switcher - 1) * (4 * (N - 2 * Ring) - 2 - Xs);
    }
}
PrintArray2(a);


