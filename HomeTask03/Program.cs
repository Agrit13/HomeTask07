//  Задайте произвольный массив. 
//  Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.



    int ReadInt(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

    void PrintArrayReverse(int[] array, int i)
    {
        if (i >= 0)
        {
            Console.Write($"{array[i]} ");
            PrintArrayReverse(array, i - 1);
        }
    }

int[] GenerateArray(int size, int leftRange, int rightRange)
    {
        int[] tempArray = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
    }

void PrintArray(int[] array)
    {
        System.Console.WriteLine($"{string.Join(", ", array)}");
    }
   

        
        int size = ReadInt("Введите размер массива: ");
        int[] myArray = GenerateArray(size, 1, 100);
        PrintArray(myArray);
        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReverse(myArray, myArray.Length - 1);
    

