// Задача 3*: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Задание массива натураль
int [] b = {3,7,22,2,78}; 
int sum;
sum =0;

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

//Функция для сортировки чисел в матрице от мин. до мах
void SelectionSort(int[] array)
{
    for (int i=0; i< array.Length-1; i++)
    {
        int minPosition = i;
        for ( int j=i+1; j< array.Length; j++)
        {
            if (array[j] < array[minPosition]) 
            minPosition =j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

SelectionSort(b);

sum = b[b.Length-1]-b[0];

Console.WriteLine("Разница мах. и мин. элемента = {0}", sum);
PrintArray(b);
