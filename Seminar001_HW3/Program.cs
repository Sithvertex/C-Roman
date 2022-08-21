Console.Write("Введите любое число  ");
int input = int.Parse(Console.ReadLine());

if ( input != 0)
{
    if (input %2 == 0)
    {
       Console.WriteLine("Число четное");      
    }
    else
    {
       Console.Write("Число не четное");
    }  
}
else
{
    Console.Write("Число ноль");
}
 