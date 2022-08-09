Method();

void Method()
{
    string[] array = new string[15];

    FillArray(array);
    PrintArray(array);
    //ThreeCharSearch(array);
}

void FillArray(string[] array)
{
    Random random = new Random();
    int stringLength;

    for (int i = 0; i < array.Length; i++)
    {
        stringLength = random.Next(1, 7);
        for (int j = 0; j <= stringLength; j++)
        {
            array[i] = array[i] + ((char)random.Next('a', 'z' + 1)).ToString();
        }
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine("Массив");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "  ");
    }
}