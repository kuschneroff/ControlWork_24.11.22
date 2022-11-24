/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/

string? yesNo = "";
while (yesNo != null && yesNo.ToLower() != "yes" && yesNo.ToLower() != "no")
{
    Console.Write("Желаете вводить строки вручную? (yes/no): ");
    yesNo = Console.ReadLine();
}

string[] arrayOfStrings = new string[] { };

if (yesNo != null && yesNo.ToLower() == "yes")
{
    int n = InputNumbers("Введите количество элементов массива: ");
    arrayOfStrings = new string[n];
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        Console.Write($" Введите {i + 1} строку: ");
        arrayOfStrings[i] = Console.ReadLine() ?? "";
    }
}
else
{
    arrayOfStrings = new string[] { "hello", "2", "world", ":-)" };
}

int lengthLimit = 3;

int numbersItems = CheckArray(arrayOfStrings, lengthLimit);

string[] newArrayOfStrings = new string[numbersItems];

FillNewArray(arrayOfStrings, newArrayOfStrings, lengthLimit);

Console.WriteLine($"{PrintArray(newArrayOfStrings)}");


void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

int CheckArray(string[] array, int lengthLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit) result++;
    }
    return result;
}

string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}