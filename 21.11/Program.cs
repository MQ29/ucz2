using System;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
//metody extension

class Program
    
{
    static int metoda(int a)
    {
        return a;
    }
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4 };
        int test = 3;

        var result = from n in numbers where n < test select n;

        foreach (var x in result)
        {
            Console.WriteLine($"{x}  ");
        }

        Func<int, int> d1 = x => x + 2;
        
    }
}
























//class klasa
//{
//    public static void Main()
//    {
//        int x = 10;
        
//        x.jakchcemy();
//        Console.WriteLine($"test: {x.jakchcemy(2)} ");
//        Console.WriteLine($"test: {x.jakchcemy(9)} ");
//        Console.In.Read();
//    }
//}
//public static class numerowana
//{
//    public static bool jakchcemy (this int x)
//    {
//        if (x < 10) return false;
//        else return true;
//    }
//    public static bool jakchcemy(this int x, int drugi)
//    {
//        if (drugi < 10 && x > 10) return false;
//        else return true;
//    }
//}





































//public class numerowana : IEnumerator
//{
//    int index = 0;
//    int[] dane = new int[3] { 1, 2, 3};

//    public object Current
//    {
//        get { return (object)dane[index]; }
//        set { dane[index] = (int)value; }
//    }


//    public bool MoveNext()
//    {
//        if (index < dane.Length)
//        {
//            index++;
//            return true;
            

//        }
//        else
//        {
//            return false;
//        }
//    }
//    public void Reset()
//    {
//        index = 0;
//    }


