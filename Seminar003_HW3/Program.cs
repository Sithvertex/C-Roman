// Введение исходных данных
Console.Write("Введите любое N число  ");
int input = int.Parse(Console.ReadLine());

// Определение временых переменых
int s, f;
f = 0;
s = 0;

//Определение массива и его разменрности
// +1 потому что есть a[0] поэтому на 1 больше
int[] a = new int[input+1];

// формирование таблицы кубов
for (int j = 0; j <= input; j++)
{        
    f = f + j;
    s = Convert.ToInt32(Math.Pow(f, 3)); 
    a[j] = s;
    Console.WriteLine(a[j]); 
    s = 0;
    f = 0;    
}
