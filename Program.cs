// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void ShowSecondDigit(int number)
{
    System.Console.WriteLine("EXERCISE 10.  " + "Second digit of " + number + " is " + number / 10 % 10);
}
ShowSecondDigit(258);





// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void ShowThirdDigit(int sum)
{
    if (sum > 99)
    {
        System.Console.WriteLine("EXERCISE 13.  " + "The third digit of " + sum.ToString() + " is " + sum.ToString()[2]);
    }
    else
    {
        System.Console.WriteLine("Third digit is not exist");
    }
}
ShowThirdDigit(129215);




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


void IfWeekend(int day)
{
    if (day == 6 || day == 7)
    {
        System.Console.WriteLine("weekend");
    }
    else
    {
        System.Console.WriteLine("not weekend");
    }
}

int number1;
while (true)
{
    try
    {
        Console.Write("EXERCISE 15.  Print number from 1 to 7: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        if (number1 > 0 && number1 < 8)
        {
            break;
        }
        else
        {
            Console.WriteLine("Number is wrong, try again");
        }
    }
    catch (FormatException) { }
}

IfWeekend(number1);




//  ** Дополнительное не обезательное *****
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
// 14 -> нет 
// 46 -> нет 
// 161 -> да

void IfMultiplicate(int data)
{
    if (data % 7 == 0 && data % 23 == 0)
    {
        System.Console.WriteLine("Yes");
    }

    else
    {
        System.Console.WriteLine("No");
    }
}

System.Console.WriteLine("EXERCISE **.  Print integer: ");
int number2 = int.Parse(Console.ReadLine());

IfMultiplicate(number2);


