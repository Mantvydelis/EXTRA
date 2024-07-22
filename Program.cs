using System;
using System.Buffers;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManoPrograma
{
    public class ExtraUzduotys
    {
        ////1 uzduotis
        //public static void Main(string[] args)
        //{
        //    int[] masyvas = new int[4];
        //    Console.WriteLine("Įveskite pirmą sveikąjį skaičių:");
        //    masyvas[0] = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Įveskite antrą sveikąjį skaičių:");
        //    masyvas[1] = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Įveskite trečią sveikąjį skaičių:");
        //    masyvas[2] = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Įveskite ketvirtą sveikąjį skaičių:");
        //    masyvas[3] = Convert.ToInt32(Console.ReadLine());
        //    ArLyginis(masyvas);

        //}
        //public static void ArLyginis(int[] m)
        //{
        //    if ((m[0] + m[1] + m[3] + m[4]) % 2 == 1)
        //    {
        //        Console.WriteLine("Suma yra nelyginė");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Suma yra lyginė");
        //    }

        //}

        //2 uzduotis

        //public static void Main(string[] args)
        //{
        //    int[] masyvas = new int[3];
        //    Console.WriteLine("Įveskite pirmą sveikąjį skaičių:");
        //    masyvas[0] = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Įveskite antrą sveikąjį skaičių:");
        //    masyvas[1] = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Įveskite trečią sveikąjį skaičių:");
        //    masyvas[2] = Convert.ToInt32(Console.ReadLine());
        //    ArDaugiau(masyvas);
        //}
        //public static void ArDaugiau(int[] m)
        //{
        //    if (m[0] > m[1] && m[0] < m[2])
        //    {
        //        Console.WriteLine("Pirmas elementas yra tarp antro ir trečio");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Pirmas elementas nėra tarp antro ir trečio");
        //    }
        //}

        //3 uzduotis

        //    public static void Main(string[] args)
        //    {
        //        int[] masyvas = new int[5];
        //        Console.WriteLine("Įveskite pirmą sveikąjį skaičių:");
        //        masyvas[0] = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Įveskite antrą sveikąjį skaičių:");
        //        masyvas[1] = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Įveskite trečią sveikąjį skaičių:");
        //        masyvas[2] = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Įveskite ketvirtą sveikąjį skaičių:");
        //        masyvas[3] = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Įveskite penktą sveikąjį skaičių:");
        //        masyvas[4] = Convert.ToInt32(Console.ReadLine());
        //        ArLyginis(masyvas);
        //    }
        //    public static void ArLyginis(int[] m)
        //    {
        //        if (m[0] % 2 == 0 && m[4] % 2 == 1)
        //        {
        //            Console.WriteLine("Pirmas nelyginis, paskutinis lyginis");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Sąlyga neatitinka");
        //        }
        //    }

        //4 uzduotis

        //public static void Main(string[] args)
        //{
        //    int[] masyvas = new int[2];
        //    Console.WriteLine("Įveskite pirmą sveikąjį skaičių:");
        //    masyvas[0] = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Įveskite antrą sveikąjį skaičių:");
        //    masyvas[1] = Convert.ToInt32(Console.ReadLine());
        //    ArNeigiamas(masyvas);
        //}
        //public static void ArNeigiamas(int[] m)
        //{
        //    if (m[0] > 0 && m[1] < 0)
        //    {
        //        Console.WriteLine("Vienas elementas neigiamas, kitas teigiamas");
        //    }
        //    else if (m[1] > 0 && m[0] < 0)
        //    {
        //        Console.WriteLine("Vienas elementas neigiamas, kitas teigiamas");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Abu elementai teigiami arba abu neigiami");
        //    }
        //}

    }
}

