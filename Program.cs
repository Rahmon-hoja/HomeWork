// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.Write("Введиту трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int high, low, res;
high = num % 100;
low = high / 10;
res = low ;

Console.WriteLine($"Из трeхзначного числа {num} выводим второе число {res}");
*/

/*
int Puck(int num)
{
    int high, low, res;
    high = num % 100;
    low = high / 10;
    res = low ;
    return res;
}



int randNum = new Random().Next(100, 1000);
int res = Puck(randNum);


Console.WriteLine($"Из трeхзначного числа {randNum} выводим второе число {res}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

Console.Write("Введите трехзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);

int res = num % 10;

if (numText.Length > 2)
    {
        Console.WriteLine("Третья цифра: "  + res);
    }
else
    {
        Console.WriteLine("третьего числа нет!");
    }

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool MonthNumber(int x)
{
    if (x > 0 && x < 8)
    {
       if (x == 6 || x == 7)
        return true;
    }
        
    return false;
}

Console.WriteLine($"Программа проверки, являеться ли число, выходным днем недели");

Console.Write("Напишите цифру: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

bool result = MonthNumber(x);


if(result)
    Console.WriteLine($"{x} число, выходной день");
else
    Console.WriteLine($"{x} число, рабочий день");
    
*/