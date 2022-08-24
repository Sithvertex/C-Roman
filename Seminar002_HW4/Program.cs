Console.Write("Введите число  ");
int input = int.Parse(Console.ReadLine());

if (input % 7 ==0 && input % 23 == 0)
{
Console.Write("Число кратно 7 и 23 одновремено:");
}
else
{
Console.Write("Число не кратно 7 и 23 одновремено");
}
// Проверить можно числом 16905