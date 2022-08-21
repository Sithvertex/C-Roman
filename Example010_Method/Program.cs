int [] array = { 1, 12, 13, 14, 5, 14, 65, 117 };

int n = array.Length;

int find = 14;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
