using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me the height of the cylinder:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLIne("Tell me its Radius");
            float r = float.Parse(Console.Readline());
            float V = 3.1415926*(r*r)*a;
            Console.WriteLine($"Volume: {V}." );
            float S = 2*3.1415926*r(r + a);
            Console.WriteLine($"Surface area: {S}." );
        }
    }
}
