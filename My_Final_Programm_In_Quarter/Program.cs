// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
string[] startStr = new string[] {"hello", "2", "world", ":-)"};
string[] endStr = new string[startStr.Length];
void PutDigitIfLessThree(string[] startStr, string[] endStr)
{
    int count = 0;
    for (int i = 0; i < startStr.Length; i++)
    {
        if (startStr[i].Length <= 3)
        {
            endStr[count] = startStr[i];
            count++;
        }
    }
}
void PrintString(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PutDigitIfLessThree(startStr, endStr);
Console.Write("Строка со значениями которые меньше трех:            ");
PrintString(endStr);