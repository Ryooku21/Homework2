// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int anyNumber = Convert.ToInt32(Console.ReadLine());

int FindThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result;
    result = num % 10;
    return result;
}

int thirdDigit = FindThirdDigit(anyNumber);

Console.WriteLine(thirdDigit);
