using System.Drawing;
using System.Globalization;

void Main()
{
    int sizeArray = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(sizeArray, 0, 99);
    PrintArray(array);
    for (int i = array.Length - 1; i >= 0; i--)
    {
        Console.Write("[" + array[i] + "]");
    }
    
}
int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    return tempArray;
}
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arrayForPrint)
{
    foreach (int number in arrayForPrint)
    {
        System.Console.Write(number + " ");
    }

}
Main();
