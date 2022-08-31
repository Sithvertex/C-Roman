// Введение кордин. двух  точек в 3D
Console.WriteLine("Введите х1=");
int d = Int32.Parse(Console.ReadLine());
double x1 = Convert.ToDouble(d);

Console.WriteLine("Введите у1=");
int s = Int32.Parse(Console.ReadLine());
double y1 = Convert.ToDouble(s);

Console.WriteLine("Введите z1=");
int v = Int32.Parse(Console.ReadLine());
double z1 = Convert.ToDouble(v);

Console.WriteLine("Введите х2=");
int ty = Int32.Parse(Console.ReadLine());
double x2 = Convert.ToDouble(ty);
 
Console.WriteLine("Введите у2=");
int cv = Int32.Parse(Console.ReadLine());
double y2 = Convert.ToDouble(cv);         
           
Console.WriteLine("Введите z2=");
int az = Int32.Parse(Console.ReadLine());
double z2 = Convert.ToDouble(az);

 //Вычисление по координатам         
double z = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1),2));

//Вывод результата
Console.WriteLine("Результат равен = {0}", z);

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

