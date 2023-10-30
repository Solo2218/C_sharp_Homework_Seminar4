// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine($"[{String.Join(", ", GetArray(GetNumber()))}]");

int GetNumber()
{
    int num;
    while (true)
    {
        Console.Write($"Введите количество элементов массива: ");
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

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}