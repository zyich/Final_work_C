


/*
Console.WriteLine("write number of elements in array :");
int number = Convert.ToInt32(Console.ReadLine());




string [] stringArray = new string[number];
    
    for (int i = 0; i < number; i++)
        {
            Console.Write($"Input word, number or symbol {i + 1}: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("it is not possible to make empty string, try again :");
                    i--; 
                }
            else
                {
                    stringArray[i] = input;
                }
        }

string  NewArrayString = "[" + string.Join(", ", stringArray) + "]";
Console.WriteLine($" Your array : {NewArrayString}:");


*/



string[] stringArray = { "Russia", "God", "Windows", "12", "1" };
Console.WriteLine("Исходный массив:");
Console.WriteLine("[" + string.Join(", ", stringArray) + "]");

Console.WriteLine("Элементы массива с 3 или менее символами:");
string[] shortStrings = new string[stringArray.Length];
int count = 0;
for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
    {
        shortStrings[count] = stringArray[i];
        count++;
    }
}

// Создайте новый массив с фактическим размером
string[] trimmedShortStrings = new string[count];
Array.Copy(shortStrings, trimmedShortStrings, count);

Console.WriteLine("[" + string.Join(", ", trimmedShortStrings) + "]");
Console.WriteLine(); // Переход на новую строку после вывода элементов
