using System;

public class Program
{
    public static void Main(string[] args)
    {
        Write1ThroughN_While(5);
        Console.WriteLine();
        Write1ThroughN_For(7);
        Console.WriteLine();
        WriteNThrough1_While(6);
        Console.WriteLine();
        WriteNThrough1_For(5);
        Console.WriteLine();
        WriteEvensThrough100();
        Console.WriteLine();
        FindSum(0);
        Console.WriteLine();
    }

    public static void Write1ThroughN_While(int n)
    {
        int i = 0;
        if(n > 0)
        {
            while(i != n)
            {
                i++;
                Console.Write($"{i} ");
            }
        }
        else OutOfRangeMessage(n);
    }

    public static void Write1ThroughN_For(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{i} ");
        }
    }

    public static void WriteNThrough1_While(int n)
    {
        int i = n + 1;
        if(n > 0)
        {
            while(i != 1)
            {
                i--;
                Console.Write($"{i} ");
            }
        }
        else OutOfRangeMessage(n);
    }

    public static void WriteNThrough1_For(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            Console.Write($"{i} ");
        }
    }

    public static void WriteEvensThrough100()
    {
        for(int i = 1; i <= 100; i++)
        {
            i++;
            Console.Write($"{i} ");
        }
    }

    public static void FindSum(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            int num = n + i;
            Console.Write($"{num} ");
        }
        if(n == 0) Console.WriteLine(n);
    }

    public static void FindSumOfEvenNumbers(int n)
    {

    }

    public static void FindSumOfOddNumbers(int n)
    {

    }

    public static void OutputRightTriangle(int _base)
    {

    }

    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine($"{n} is out of range!");
    }
}
