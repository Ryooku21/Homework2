// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void VacationProof(int num)
{
    if (num > 0 && num < 6)
    {
        Console.WriteLine("Указанный день является будним");
    }
    else
     if (num == 6 || num == 7)
    {
        Console.WriteLine("Указанный день является выходным");
    }
    else
    {
        Console.WriteLine("Введенное число не соответсвует дню недели");
    }
}

VacationProof(dayNumber);