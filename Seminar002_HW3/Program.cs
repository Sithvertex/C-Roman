Console.Write("Введите день недели(число))  ");
int input = int.Parse(Console.ReadLine());

switch(input)
{
    case 1: { Console.Write("Сегдоня понедельник на работу");
    break;}
    case 2:{ Console.Write("Сегдоня вторник на работу");
    break;}
    case 3:{ Console.Write("Сегдоня среда на работу");
    break;}
    case 4:{ Console.Write("Сегдоня четверг на работу");
    break;}
    case 5:{ Console.Write("Сегдоня пятница на работу");
    break;}
    case 6:{ Console.Write("Сегдоня суббота выходной УРА!!");
    break;}
    case 7:{ Console.Write("Сегдоня воскресенье выходной УРАА!");
    break;}
default:{ Console.Write("Пора в отпуск");
    break;}
}