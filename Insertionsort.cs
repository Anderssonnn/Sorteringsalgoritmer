using System;
using System.Diagnostics;

class Program
{
    static double[] randomArray = new Double[10000];

    static void RandomNumbers()
    {
        Random randomNumber = new Random();
        for (int i = 0; i < randomArray.GetLength(0); i++)
        {
            randomArray[i] = randomNumber.NextDouble();
        }
    }

    static void InsertionSort()
    {
        double temp;
        int inner;
        for (int outer = 0; outer < randomArray.GetLength(0); outer++)
        {
            temp = randomArray[outer];
            inner = outer;
            while (inner > 0 && (randomArray[inner - 1] >= temp))
            {
                randomArray[inner] = randomArray[inner - 1];
                inner -= 1;
            }
            randomArray[inner] = temp;
        }
    }

    static void Main(string[] args)
    {
        RandomNumbers();
        Console.WriteLine("Number of Items: {0}", randomArray.GetLength(0));
        Stopwatch sWatch = new Stopwatch();
        sWatch.Reset();
        sWatch.Start();
        InsertionSort();
        sWatch.Stop();
        Console.WriteLine("Insertion Sort Completed: {0} milliseconds", sWatch.Elapsed);
        Console.ReadLine();
    }
}