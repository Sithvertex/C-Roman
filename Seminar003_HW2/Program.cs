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
