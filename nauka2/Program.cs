using System;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(String[] args)
    {
        ArrayList list = new ArrayList();
        list.Add("test1");
        list.Add("test2");
        list.Add("test3");
        list.Add(1);
        list.Add(2);
        list.Add(3);

        Console.WriteLine($"Capacity: {list.Capacity}");
        Console.WriteLine($"Count: {list.Count}");

        Console.WriteLine($"String[0]: {list[0]}");
        Console.WriteLine($"String-Array[0]: {list.ToArray()[0]}");
        Console.WriteLine($"String-Array[0]: {list.ToArray()[0].ToString()}");

        Console.WriteLine($"int[3]: {list.ToArray()[2]}");

        list.RemoveAt(1);
        String cos = "cos";
        list.Add(cos);
        list.Remove(cos);

        List<int> list2 = new List<int>();
        list2.Add(2);
        list2.Add(3);
        int[] dane = new int[2] { 1, 2 };
        list2.AddRange(dane);
        list2.Insert(2, 15);
        if (list2.Contains(13)) Console.WriteLine("ma 13");
        List<int> list3 = new List<int>() { 1, 2, 3, 4, 5 };
        //List<car> list4 = new List<car>() { new car() { marka = "audi" }, new car() { marka = "bmw" } };

        Stack<int> stos1 = new Stack<int>();
        stos1.Push(2);
        stos1.Push(3);
        int w = stos1.Pop();

        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(1,"cos");
        //Console.WriteLine(dic);

        Dictionary<int, string> dic2 = new Dictionary<int, string>()
        { { 10,"cos"},{3,"cos2" } };

        foreach (KeyValuePair<int,string> p in dic2)
        {
            Console.WriteLine($"ss" + p.Key);
        }






        var carlist = new List<car>() {
        new car { marka = "audi", rocznik = 2005 },
        new car { marka = "fiat", rocznik = 2014 },
        new car { marka = "bmw", rocznik = 2002 }
    };
        List<string> markacar = carlist.Select(c => c.marka).ToList();
        foreach (var x in markacar)
        {
            Console.WriteLine(x);
        }
            

             



    }
    public class car
    {
       public string marka;
        public int rocznik;

    }
}


