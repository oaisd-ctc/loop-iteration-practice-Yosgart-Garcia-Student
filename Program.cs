using System;

public class Program
{
    public static void Main(string[] args)
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);
        Console.WriteLine();
        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);
        Console.WriteLine();
        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);
        Console.WriteLine();
        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);
        Console.WriteLine();
        WriteEvensThrough100();
        Console.WriteLine();
        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);
        Console.WriteLine();
        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(0);
        Console.WriteLine();
        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(0);
        Console.WriteLine();
        OutputRightTriangle(10);
        Console.WriteLine();
        OutputRightTriangle(-4);
        Console.WriteLine();
        OutputRightTriangle(0);
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
        Console.WriteLine();
    }

    public static void Write1ThroughN_For(int n)
    {
        if(n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }
        }
        else OutOfRangeMessage(n);
        Console.WriteLine();
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
        Console.WriteLine();
    }

    public static void WriteNThrough1_For(int n)
    {
        if(n > 0)
        {
            for (int i = n; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }
        }
        else OutOfRangeMessage(n);
        Console.WriteLine();
    }

    public static void WriteEvensThrough100()
    {
        for(int i = 1; i <= 100; i++)
        {
            i++;
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    public static void FindSum(int n)
    {
        
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        
    }

    public static void FindSumOfOddNumbers(int n)
    {
        
    }

    public static void OutputRightTriangle(int _base)
    {
        if(_base > 0)
        {
            int num = 0;
            for (int i = 1; i <= _base; i++)
            {
                num++;
                for (int j = 1; j <= num; j++) Console.Write("*");
                Console.WriteLine();
            }
        }
        else if(_base < 0)
        {
            int num = _base*-1;
            for (int i = 1; i <= _base*-1; i++)
            {
                for (int j = 1; j <= num; j++) Console.Write("*");
                num--;
                Console.WriteLine();
            }
        }
        else OutOfRangeMessage(_base);
        
    }

    public static void OutOfRangeMessage(int n)
    {
        Console.Write($"{n} is out of range!");
    }
}
