// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int EnterNumber(int number)
{
    bool result;
    do
    {
        Console.Write("Enter number: ");
        result = int.TryParse(Console.ReadLine(), out number);
    }
    while (result == false);
    return number;
}

int number = 0;
number = EnterNumber(number);

string? numberString = Convert.ToString(number);
number = Convert.ToInt32(numberString);

int remainder = 1;
int digitSum = 0;

for (int i = 0; i < numberString.Length; i++)
{
    remainder = number % 10;
    number /= 10;
    digitSum += remainder;
}
Console.Write($"Sum digits = {digitSum}");