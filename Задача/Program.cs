// Вход: массив строк inputArray
Console.Write("Введите массив через пробел:");
string[] inputArray = Console.ReadLine().Split(' ');
// string[] inputArray = { "apple", "banana", "cat", "dog", "elephant" };

// Создаем пустой массив outputArray
string[] outputArray = new string[0];

// Цикл for по строкам
for (int i = 0; i < inputArray.Length; i++)
{
    string str = inputArray[i];

    // Проверка длины строки
    if (str.Length <= 3)
    {
        // Добавление строки в outputArray
        Array.Resize(ref outputArray, outputArray.Length + 1);
        outputArray[outputArray.Length - 1] = str;
    }
}

// Вывести outputArray
Console.WriteLine("Массив строк, длина которых меньше или равна 3 символам:");
for (int i = 0; i < outputArray.Length; i++)
{
    Console.Write(outputArray[i]);
    if (i < outputArray.Length -1)
    {
        
        Console.Write(", ");
    }
    
}
