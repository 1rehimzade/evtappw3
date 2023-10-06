using System;

class Program
{
    static void Main()
    {
        int[] myArray = { 11, 23, 39, 74, 51 };
        int[] valuesToAdd = { 63, 72, 88 };

        InsertArray(ref myArray, valuesToAdd);

        Console.WriteLine("yenilenmis,kohne arr:");
        PrintArray(myArray);
    }

    static void InsertArray(ref int[] array, int[] values)
    {
        int oldLength = array.Length;
        int newLength = oldLength + values.Length;

        int[] newArray = new int[newLength];

        for (int i = 0; i < oldLength; i++)
        {
            newArray[i] = array[i];
        }

        for (int i = 0; i < values.Length; i++)
        {
            newArray[oldLength + i] = values[i];
        }

        array = newArray; 
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
