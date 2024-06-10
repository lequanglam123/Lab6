using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{


    static void Main(string[] args)
    {
        List<int> listInt = new List<int>() { 2, 4, 5, 6, 7, 8, 9 };
        List<string> listString = new List<string>() { "", "T1", "T2", "T3", "" };
        List<string> listNull = new List<String>();

        Console.Write("cau 1a: ");
        Console.WriteLine(listInt.First(i => i % 2 == 0 && i > 5));

        Console.Write("cau 1b: ");
        Console.WriteLine(listInt.LastOrDefault(i => i > 200));

        Console.Write("cau 1c: ");
        var letterT = listString.FirstOrDefault(i => i != null && i.StartsWith("T"));
        Console.WriteLine(letterT);

        Console.Write("cau 1d: ");
        int sum = listInt.Where((value, Index) => Index % 2 != 0 && value % 2 == 0).Sum();
        Console.WriteLine(sum);
    }
}