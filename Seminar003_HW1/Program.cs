// Введение исходных данных
Console.Write("Введите любое число  ");
int input = int.Parse(Console.ReadLine());

//b[i] = int.Parse(str[i].ToString());


//int[] b = new int[str.Length];


//Console.WriteLine(b);

int i, v, fer, value;
//double c;
//double value;
//int[] a = new int[8];

value =10;
i = 0;
//v = input;

do
{
    value = input / 10;
    fer=  input % 10;    
   // a[i] = value;
    input = fer;
    i++;
    //Console.WriteLine("Трех-значное число:" +value);
    Console.WriteLine("Трех-значное число:" +i);
}
while (value > 9);





//while ( value > 9)
//{
  //  Console.WriteLine(i);
 //   s = Convert.ToInt32(Math.Pow(10, i)); 
  //  value = input / 10;
  //  fer=  input % 10;    
   // a[i] = value;
 //   input = fer;
  //  i++;
    //Console.WriteLine("Трех-значное число:" +value);
  ///  Console.WriteLine("Трех-значное число:" +i);
    
//}