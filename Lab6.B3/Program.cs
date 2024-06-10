using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int>() { 5, 6, 7, 8, 1 };

        Console.WriteLine("Bai3a: ");
        var list3 = list1.Union(list2);
        var list4 = list3.OrderByDescending(x => x);
        foreach (var item in list4)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("Bai3b: ");
        var list5 = list1.Intersect(list2);
        foreach (var item in list5)
        {
            Console.WriteLine(item);
        }
    }
}