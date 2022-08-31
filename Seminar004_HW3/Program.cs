// Задача 3:*(Дополнительная, не обязательная задача):
//  Назовём число «интересным» если его произведение цифр делится на их сумму.
//  Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел.
//  (Каждый эл-т массива должен быть сгенерирован случайно)


// Введение исходных данных
Console.Write("Введите размерность массива N:");
int N = int.Parse(Console.ReadLine());

//Функция для вывода массива
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

//Функция для определения разрядности числа
int countOfRang(int n)
{      
    int tmp = n;
    int countOfDigits = 0;
    while (tmp != 0)
    {
        tmp = tmp / 10; 
         countOfDigits++;
    }
    return countOfDigits;
}

//Определение переменых 
int start = 1;
int stop = 1000000;

// Задание массива "интересных" чисел
int[] a = new int[N+1];

int i, s, m, number_1, number_2;
i = 0;

while(i < N)
{
    int input = new Random().Next(start,stop+1); 
    s = countOfRang(input);
    int[] b = new int[s+1];
    int number;
    number = input;
    // разбиение random числа на числа :)
    for (int k = 0; k < s; k++)
    {
         m = Convert.ToInt32(Math.Pow(10, ((s-k)-1)));
        number_1 = number / m;
        number_2 = number % m;
        b[k] = number_1;
        number = number_2;
    }
    int t1, t2;
    t1= 0;
    t2 =0;
    for (int j = 0; j <= s; j++)
    {
        t1 *= b[j];
        t2 += b[j];
    }
    if (t1%t2 == 0 && input != 0)
    {
        a[i] = input; //присвоение массиву "интересного числа"
        i++;
    }
    s=0;
}

PrintArray(a);
