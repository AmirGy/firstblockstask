Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[length];

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