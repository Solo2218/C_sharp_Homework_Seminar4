// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = GetNumber();
Console.WriteLine($"Сумма всех цифр числа {number} равена {Sum(number)}");

int GetNumber()
{
    int num;
    while (true)
    {
        Console.Write($"Введите число: ");
        string stringNumber = Console.ReadLine();
        bool isNumber = int.TryParse(stringNumber, out num);
        if (isNumber)
        {
            Console.WriteLine($"Вы ввели число: {num}.");
            break;
        }
        else Console.WriteLine("Вы ввели не число, а текст!");
    }
    return num;
}

int Sum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    } 
    return result;
}