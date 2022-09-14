// Задача 3. Сформируйте двухмерный массив из неповторяющихся
// двузначных чисел (размер массива не более 50 элементов). 
// Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции: Проверить число на присутствие в массиве 
// (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

string t = "";
Console.WriteLine("Введите размерность массива n*m (через пробел):");
t = Console.ReadLine();
string[] tv = t.Split(' ').ToArray();
int n = int.Parse(tv[0]);
int m = int.Parse(tv[1]);

int start = 10;
int stop = 99;
int[,] a = new int[n, m];

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

//Функция для проверки есть ли это число в двухмерном массиве
bool IsinArray(int[,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == value)
            {
                return true;
            }     
    }
    return false;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        int value = a[i, j];
        if (IsinArray(a, value) == true)
        {
            int tmp = new Random().Next(start, stop + 1);
            a[i, j] = tmp;
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


// Console.WriteLine("Итоговая матрица перемножения");
PrintArray2(a);
