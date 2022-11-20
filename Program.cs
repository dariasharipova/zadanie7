using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите значение х");
        double x = double.Parse(Console.ReadLine());
        static double vicheslenie(ref double x)
        {
            if(Math.Sin(x)<-0.5)
            {
                return Math.Sin(x);
            }
            else if ( -0.5 >= Math.Sin(x) & Math.Sin(x) <= 0.5)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        Console.WriteLine(vicheslenie(ref x));
    }
}



