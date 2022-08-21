//создание переменных
double a1;
double a2;
string input1;
string input2;
double max;
Console.Write("Введите любое вещественое число 1 ");
input1 = Console.ReadLine();
Console.Write("Введите любое вещественое число 2 ");
input2 = Console.ReadLine();

a1 = Double.Parse(input1);
a2 = Double.Parse(input2);

max = a1;
if( a2 > max ) max = a2;

Console.Write("Макимальное число:" +max);
// Вопрос на семинаре, как считать с консоли число, без
// конвертации:
//input = int.Parse(Console.ReadLine());