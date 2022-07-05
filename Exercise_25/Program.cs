// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

int numberA = 0;
numberA = EnterNumber(numberA);

int numberB = 0;
numberB = EnterNumber(numberB);

while (numberB < 1)
{
    Console.Write("Введите натуральную степень числа\n");
    numberB = EnterNumber(numberB);
}
double convertNumberB = Convert.ToDouble(numberB);
double convertNumberA = Convert.ToDouble(numberA);

double result = Math.Pow(convertNumberA, convertNumberB);

Console.WriteLine($"{numberA} ^ {numberB} = {result}");