// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
string[] startS = new string[] {"hello", "2", "world", ":-"};
string[] endS = new string[startS.Length];
void PutDigitIfLessThree(string[] startS, string[] array2)
{
    int count = 0;
    for (int i = 0; i < startS.Length; i++)
    {
        if (startS[i].Length <= 3)
        {
            endS[count] = startS[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PutDigitIfLessThree(startS, endS);
PrintArray(endS);