using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {//First part of exercise1
            string arg=args[0];
            int x =int.Parse(arg);
            x++;
            Console.WriteLine(x);
            --x;
            --x;
            Console.WriteLine(x);
        }
    }
}
