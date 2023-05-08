using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numeros = Enumerable.Range
        (1, 100).Reverse();
        foreach (var numeros in numeros)
        {
            Console.WriteLine(numeros);
        }
    }
}