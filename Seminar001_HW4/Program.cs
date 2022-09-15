//2.Генерация числа из условий (1 1000000]
int input = new Random().Next(1,10000+1);

int i, j, b, s;
i = 0;
j = 0;

while ( i < input)
{
    i++;
    if (i %2 == 0)
    {
        j++;
      //  Console.WriteLine(j); 
    }
}
b = 0;
while (b < j)
{ 
    b++;
    s = 2*b;
    Console.WriteLine(s);    
}