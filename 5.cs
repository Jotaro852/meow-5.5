using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] numbers = File.ReadAllLines("numsTask5.txt");
        int[] intNumbers = Array.ConvertAll(numbers, s => int.Parse(s));

        int minIndex = Array.IndexOf(intNumbers, intNumbers.Min());
        int maxIndex = Array.IndexOf(intNumbers, intNumbers.Max());

        int start = Math.Min(minIndex, maxIndex) + 1;
        int end = Math.Max(minIndex, maxIndex);

        int sum = 0;
        for (int i = start; i < end; i++)
        {
            sum += intNumbers[i];
        }

        double average = (double)sum / (end - start);
        Console.WriteLine("Среднее арифметическое элементов между минимальным и максимальным: " + average);
    }
}