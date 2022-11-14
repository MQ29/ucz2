// See https://aka.ms/new-console-template for more 
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;


    namespace nauka1
    {
        public class Delegaty   //https://www.p-programowanie.pl/c-sharp/delegaty
    {
        public delegate void MojDelegat(string tekst);
        public static void Main()
        {
            Action<int, int> d1 = metoda;
            d1(10, 10);


            //MojDelegat d1 = new MojDelegat(Metoda1);
            //d1("test");

            //MojDelegat d2 = new MojDelegat(Metoda2);
            //d2("test2");
            //MojDelegat d3 = new MojDelegat(c1.Metoda3);

            //MojDelegat dele = d1 + d2;
            
            //dele += d3;
           
            //dele("test dodanych");

            //Console.WriteLine();

            //dele -= d2;
            
            //dele("test"); //d1 + d2 + d3 - d2

            //d3.Invoke("test3");
            
            //metoda(d1); //wywolanie delegatu z parametrem
           
        }

        static void metoda(int a, int b)
        {
            Console.WriteLine("Action: " + a);
        }

        //static void metoda(MojDelegat del)
        //{
        //    del("z paramterem");
        //}
        //public static void Metoda1(String tekst)
        //{
        //    Console.WriteLine("Metoda1: " + tekst);
        //}

        //public static void Metoda2(String tekst)
        //{
        //    Console.WriteLine("Metoda2: " + tekst);
        //}

        //public class c1
        //{
        //    public static void Metoda3(String tekst)
        //    {
        //        Console.WriteLine("Metoda3: " + tekst);
        //    }
        }
    }
































    //    public class P1
    //    {
    //        public int dane;
    //        public static P1 operator +(P1 o1, P1 o2)
    //        {
    //            P1 p = new P1();
    //            p.dane = o1.dane + o2.dane;
    //            return p;
    //        }
    //        public static P1 operator +(P1 o1, int o2)
    //        {
    //            P1 p = new P1();
    //            p.dane = o1.dane + o2;
    //            return p;
    //        }
    //        public static P1 operator ++(P1 o1)
    //        {
    //            o1.dane++;
    //            return o1;
    //        }
    //    public static P1 operator --(P1 o1)
    //    {
    //        o1.dane--;
    //        return o1;
    //    }

    //}


    //    class Program
    //    {
    //        public static void Main(string[] args)
    //        {
    //            P1 o1 = new P1(); o1.dane = 5;
    //            P1 o2 = new P1(); o2.dane = 4;
    //            P1 o3 = o1-- + o2 + 6;
    //            System.Console.WriteLine(o3.dane);


    //        }
    //    }
    //}



    /*class Program
    {
        static void Main(string[] args)
        {
            Sterownik ster = new Sterownik();
            PojazdMechaniczny p = new PojazdMechaniczny();
            ster.st = (Sterowanie) p;
            ster.steruj();
            Console.In.ReadLine();
        }
            public interface Sterowanie
        {
            void Ruszaj();
            void Stop();
            }
        public class PojazdMechaniczny : Sterowanie
        {
            public void Ruszaj() { Console.WriteLine("ruszam"); }
            public void Stop() { }

       }
        public class Sterownik
        {
            public Sterowanie st;
            public void steruj()
            {
                if (st != null)
                    st.Ruszaj();
            }
        }


    */




/*klasa obiektklasy1;
obiektklasy1 = new klasa();
obiektklasy1.at1 = 11;
obiektklasy1.metoda1(3);
Console.In.ReadLine();
*/
//string a = "cos";
//switch (a)
//{
//    case "cos":
//        Console.WriteLine("2");
//        break;
//    case "text":
//        Console.WriteLine("5");
//        break;
//    default:
//        Console.WriteLine("no 5 and no 2");
//        break;

/*class Nadklasa
{
    public int atrybutNadklasy1 = 10;
}

    class klasa : Nadklasa
{
    public int at1 = 12;
    public void metoda1(int w)

    {
        Console.WriteLine("Liczba " + w + "  " + at1 + "  " + atrybutNadklasy1);
    }
*/














//    for (;a > 18;)
//    {
//        a = a + 1;
//        funkcja(11, "cos", false);

//        funkcja(14, "cos", false);
//    }

//    // || - lub, 
//    int b = 10;
//    if (a == 10)
//    {
//        funkcja(11, "cos", false);
//        funkcja(14, "cos", false);
//    }
//    else if(a == 8)
//    {
//        funkcja(8, "cos", false);
//    }
//    else
//    {
//        Console.WriteLine("Error");
//    }
//    Console.In.ReadLine();
//}
//    public static int funkcja(int a, string b, bool c)
//    {
//        Console.WriteLine("a: " + a + " ,b:" + b + " ,c:" + c);
//        return 3;
//    }
//}

//}