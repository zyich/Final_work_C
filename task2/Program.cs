



Console.WriteLine("write number of elements in array :");
int number = Convert.ToInt32(Console.ReadLine());




string [] stringArray = new string[number];
    
    for (int i = 0; i < number; i++)
        {
            Console.Write($"Input word, number or symbol {i + 1}: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("it is not possible to leave empty string, try again :");
                    i--; 
                }
            else
                {
                    stringArray[i] = input;
                }
        }


Console.WriteLine("Elements in array with 3 or less symbols:");
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

string[] cutShortStrings = new string[count];
Array.Copy(shortStrings, cutShortStrings, count);

Console.WriteLine("[" + string.Join(", ", cutShortStrings) + "]");
Console.WriteLine();