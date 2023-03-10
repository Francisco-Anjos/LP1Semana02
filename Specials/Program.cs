using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb = sbyte.MaxValue;
            short sh = short.MaxValue;
            int it = int.MaxValue;
            long ln = long.MaxValue;
            byte bt = byte.MaxValue;
            ushort us = ushort.MaxValue;
            uint ui = uint.MaxValue;
            ulong ul = ulong.MaxValue;
            float fl = float.MaxValue;
            double db = double.MaxValue;
            sbyte msb = sbyte.MinValue;
            short msh = short.MinValue;
            int mit = int.MinValue;
            long mln = long.MinValue;
            byte mbt = byte.MinValue;
            ushort mus = ushort.MinValue;
            uint mui = uint.MinValue;
            ulong mul = ulong.MinValue;
            float mfl = float.MinValue;
            double mdb = double.MinValue;

            Console.Writeline($"Max of sbyte {sb}, and the minumum is {msb}.");
            Console.Writeline($"Max of short {sh}, and the minumum is {msh}.");
            Console.Writeline($"Max of int {it}, and the minumum is {mit}.");
            Console.Writeline($"Max of long {ln}, and the minumum is {mln}.");
            Console.Writeline($"Max of byte {bt}, and the minumum is {mbt}.");
            Console.Writeline($"Max of ushort {us}, and the minumum is {mus}.");
            Console.Writeline($"Max of uint {ui}, and the minumum is {mui}.");
            Console.Writeline($"Max of ulong {ul}, and the minumum is {mul}.");
            Console.Writeline($"Max of float {fl}, and the minumum is {mfl}.");
            Console.Writeline($"Max of double {db}, and the minumum is {mdb}.");
        }
    }
}
