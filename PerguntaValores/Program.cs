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
            float V = Math.PI*Math.Pow(r,2)*a;
            Console.WriteLine($"Volume: {V}." );
            float S = 2*Math.PI*r(r + a);
            Console.WriteLine($"Surface area: {S}." );
        }
    }
}
