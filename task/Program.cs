
string[] FillPrintArray(string[] firstArray)
{
    for (int j = 0; j < firstArray.Length; j++)
    {
        Console.Write("Введите слово: ");
        string word = Convert.ToString(Console.ReadLine());
        firstArray[j] = word;
    }
    Console.WriteLine();
    Console.WriteLine("Первоначальный массив: ");
    for (int k = 0; k < firstArray.Length; k++)
        Console.Write($"{firstArray[k]} ");
    Console.WriteLine();
    return firstArray;
}

int Checking(string[] firstArray)
{
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        int l = 0;
        foreach (var item in firstArray[i])
            l++;
        if (l <= 3)
            j++;
    }
    return j;
}

void FillSecondArray(string[] firstArray, string[] newArray)
{
    int k = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        int l = 0;
        foreach (var item in firstArray[i])
            l++;
        if (l <= 3)
        {
            newArray[k] = firstArray[i];
            Console.Write($"{newArray[k]} ");
            k++;
        }
    }
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[length];
FillPrintArray(firstArray);
string[] newArray = new string[Checking(firstArray)];
FillSecondArray(firstArray, newArray);


