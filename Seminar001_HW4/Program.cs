
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