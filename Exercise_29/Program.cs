// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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

Console.Write("Enter length array\n");
int length = 0;
length = EnterNumber(length);

int[] number = new int[length];

for (int i = 0; i < length; i++)
{
    Console.Write($"Enter {i + 1} array element: ");
    number[i] = EnterNumber(number[i]);
}
Console.WriteLine($"[{String.Join(", ", number)}]");