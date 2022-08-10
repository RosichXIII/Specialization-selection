Method();

void Method()
{
    int arrayLength = 15;
    string[] array = new string[arrayLength];

    FillArray(array);
    PrintArray(array);

    string[] arraySecond = new string[SecondArraySize(array)];
    ThreeCharSearch(array, arraySecond);
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
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

int SecondArraySize(string[] array)
{    
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    Console.WriteLine("Размер второго массива: " + count);
    return count;
}

void ThreeCharSearch(string[] array, string[] arraySecond)
{
    int i = 0;
    Console.WriteLine("Результат");
    
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            arraySecond[i] = array[j];
            Console.Write(arraySecond[i] + "  ");
            i++;
        }           
    }
}