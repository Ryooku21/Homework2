// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int threeDigitNum = Convert.ToInt32(Console.ReadLine());
// int secondDigit = threeDigitNum / 10 % 10;

int FindSecondDigit()
{
int result = threeDigitNum / 10 % 10;
return result;
}

int secondDigit = FindSecondDigit();

Console.WriteLine($"Второй цифрой в числе является {secondDigit}"); 