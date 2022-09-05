// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму четных элементов,  стоящих на нечётных 
//  позициях (позиция - индекс элемента в массиве).
// [3, 7, 23, 12] -> 12
// [4, 6, 8, 1, 4] -> 6

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

int sum;
sum =0;
int i =0;
int[] b = new int[N];

int start = 1;
int stop = 999;

while(i < N)
{
    int input = new Random().Next(start,stop+1); 
    b[i] = input;

    if(input % 2 ==0 && i ! % 2 != 0)
        {
            sum = sum + input;
        }
    i++;
}   

 PrintArray(b);
 Console.WriteLine("Сумма четных на нечетных поз. {0}", sum);