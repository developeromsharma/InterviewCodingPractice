using System;

class Program
{
    //static void Main()
    //{
    //    PrintNumbers(1);
    //}

    static void PrintNumbers(int num)
    {
        if (num > 10)
            return;

        Console.WriteLine(num);
        PrintNumbers(num + 1);
    }
}
