using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        // CountBy(35231).ToList().ForEach(x => Console.WriteLine(x));
        var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
        Console.WriteLine(FindNeedle(haystack_1));
    }
    public static long[] CountBy(long n)
    {
        var data = n.ToString();
        long[] z = new long[data.Length];
        for (int i = 0; i < data.Length; i++)
            z[i] = int.Parse(data[data.Length - i-1].ToString());
        return z;
    }
    public static string FindNeedle(object[] haystack)
    {
        //Code goes here!
        return haystack.ToList().IndexOf("needle") == -1 ? "not found" : $"found the needle at position {haystack.ToList().IndexOf("needle")}";
    }
}
