// Введение исходных данных
Console.Write("Введите любое N число  ");
int input = int.Parse(Console.ReadLine());

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

int n;
n = input;

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

Console.WriteLine(input);
Console.WriteLine(countOfRang(n));


// //1. 
// // Input num
// int num = Convert.ToInt32(Console.ReadLine());
// //2.
// // Get number length in digits
// //2.1
//     int countOfDigits = 0;
//     int tmp = num;
//     while (tmp != 0)
//     {
//         tmp = tmp / 10; 
//         countOfDigits++;
//     }
//     //1 15 123
// //2.2
//     //countOfDigits = num.ToString().Length;

// //3.
// //
// // create array with required size
//     int[] digits;
//     digits = new int[countOfDigits];
// //

// //4.
// //fill array digits
//     //123 % 10 -> 3  123/10
//     //12 % 10 -> 2   12/10
//     //1 % 10 -> 1   1/10
//     int i = 0;
//     tmp = num;
//     while (tmp != 0)
//     {
//         digits[i] = tmp % 10;   
//         tmp /= 10; 
//         i++;
//     }

// //5/

