string[] CreateArray()
{
    string[] array1 = new string[5];
    Console.Write("Input 5 string: ");
    for (int i = 0; i < 5; i++)
    {
        string word = Console.ReadLine();
        if (word == "")
        {
            Console.WriteLine("Correctly enter the string, must not be empty");
            i--;
        }
        else
            array1[i] = word;
    }
    Console.WriteLine();
    return array1;
}

void MainMethod(string[] array1, string[] array2)
{
    for (int i = 0, count = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void Print(string[] array)
{
    Console.Write("Length is equal to or less than 3 characters: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array1 = CreateArray();
string[] array2 = new string[array1.Length];
MainMethod(array1, array2);
Print(array2);