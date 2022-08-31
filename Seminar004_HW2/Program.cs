// Задача 2:* Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе, которые являются делителями этого числа. 
// (для получения цифр числа операцию приведения числа к строке не использовать)
// 452 -> 6
// 82 -> 2
// 9012 -> 3
// 23 -> 0

Console.WriteLine("Введите число =");
int a = Int32.Parse(Console.ReadLine());

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

int sum, temp,k, tmp_1,tmp_2,m;
k = countOfRang(a);

int[] b = new int[k];

sum=0;
temp= a;
for (int i = 0; i < k; i++)
 {
        m = Convert.ToInt32(Math.Pow(10, ((k-i)-1)));
        tmp_1 = temp / m;
        tmp_2 = temp % m;
        b[i] = tmp_1;
        temp = tmp_2;
        if (b[i]!=0 && a % b[i] == 0)
        {
            sum += b[i]; //сумма цифр
        }  
 }
 Console.WriteLine(sum);