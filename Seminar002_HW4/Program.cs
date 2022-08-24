int start = 1;
int stop = 1000000;

//2.Генерация числа из условий (1 1000000]
int input = new Random().Next(start,stop+1);

//Проверка условий и вывод
if (input % 7 ==0 && input % 23 == 0)
{
Console.Write("Число кратно 7 и 23 одновремено: число " +input);
}
else
{
Console.Write("Число не кратно 7 и 23 одновремено: число " +input);
}
// Проверить можно числом 16905