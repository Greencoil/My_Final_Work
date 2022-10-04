// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
string[] startStr = new string[] {"hello", "2", "world", ":-)"}; // объявляем изначальную строку с заданными значениями
string[] endStr = new string[startStr.Length]; // объявляем вторую, пустую строку соответствующую размерам первой
void PutDigitIfLessThree(string[] startStr, string[] endStr) // Прописываем метод поиска в первой строке значений < = 3
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
void PrintString(string[] array) // Метод распечатки строки
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PutDigitIfLessThree(startStr, endStr); // Вызов написанных методов
Console.Write("Строка со значениями которые меньше трех:            ");
PrintString(endStr);