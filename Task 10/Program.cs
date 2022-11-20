// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int threeDigitNum = Convert.ToInt32(Console.ReadLine());
int workNumber = Math.Abs(threeDigitNum);

int FindSecondDigit(int number)
{
    int result = threeDigitNum / 10 % 10;
    return result;
}


if (workNumber > 99 && workNumber < 1000)
{
    int secondDigit = FindSecondDigit(workNumber);
    Console.WriteLine($"Второй цифрой в числе является {secondDigit}");
}
else
{
    Console.WriteLine("Число введено некорректно, введите трехзначное число!");
}