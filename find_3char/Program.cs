// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arrStr = { "is", "simply", "dummy", "text", "of", "the", "printing", "and", "typesetting" };
int Max_Length = 3;

void PrintStrArray(string[] array)
{
    if (array.Length == 0) Console.WriteLine("Array is empty");
    else
    {
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= Max_Length)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{array[i]} ");
            Console.ResetColor();
        }
        else Console.Write($"{array[i]} ");
    }

    }
}

string[] GetShortArray(string[] array)
{
    int slength = array.Length;
    string[] result = new string[slength];
    int count = 0;
    for (int i = 0; i < slength; i++)
    {
        if (array[i].Length <= Max_Length)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

Console.Write("\nSource array: [");
PrintStrArray(arrStr);
Console.WriteLine(" ]");
string[] shortArray = GetShortArray(arrStr);
Console.Write("\nResult array: [");
PrintStrArray(shortArray);
Console.WriteLine(" ]\n");