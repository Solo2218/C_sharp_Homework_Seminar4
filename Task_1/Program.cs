// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A = GetNumber('A');
int B = GetNumber('B');
Console.WriteLine($"Результат возведения числа {A} в степень {B} равен {Exponentiation(A, B)}");

int GetNumber(char letter)
{
    int num;
    while (true)
    {
        Console.Write($"Введите число {letter}: ");
        string stringNumber = Console.ReadLine();
        bool isNumber = int.TryParse(stringNumber, out num);
        if (isNumber)
        {
            Console.WriteLine($"Вы ввели число {letter}: {num}.");
            break;
        }
        else Console.WriteLine("Вы ввели не число, а текст!");
    }
    return num;
}

int Exponentiation(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result *= number;
    }
    return result;
}