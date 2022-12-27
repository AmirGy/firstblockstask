
string[] FillPrintArray(string[] firstArray, int length)
{
    for (int j = 0; j < length; j++)
    {
        Console.Write("Введите слово: ");
        string word = Convert.ToString(Console.ReadLine());
        firstArray[j] = word;
    }
    Console.WriteLine();
    Console.WriteLine("Первоначальный массив: ");
    for (int k = 0; k < length; k++)
        Console.Write($"{firstArray[k]} ");
    Console.WriteLine();
    return firstArray;
}

void SecondArray(string[] firstArray)
{
    int size = new Random().Next(1, 4);
    string[] newArray = new string[size];
    Console.WriteLine("Второй массив: ");
    for (int i = 0; i < size; i++)
    {
        int number = new Random().Next(0, size);
        newArray[i] = firstArray[number];
        Console.Write($"{newArray[i]} ");
    }
}

Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[length];
FillPrintArray(firstArray, length);
SecondArray(firstArray);

