// Brian Hodge
// C00170400
// CMPS 358
// Assignment #02b_3

using System;

namespace _02b_3_C00170400
{
    class Program
    {
        static void Main(string[] args)
        {
            Dirt sample1 = new Dirt();
            Dirt sample2 = new Dirt(10.0, 15.5);
            Dirt sample3 = new Dirt(20.5, 50.0);

            sampleInfo(sample1);
            sampleInfo(sample2);
            sampleInfo(sample3);

            sample1.IncreaseSand();
            sample1.IncreaseClay();
            sampleInfo(sample1);

            sample2.IncreaseSand();
            sample2.IncreaseClay();
            sampleInfo(sample2);

            sample3.IncreaseSand();
            sample3.IncreaseClay();
            sampleInfo(sample3);

            sample1.DecreaseSand();
            sample1.DecreaseClay();
            sampleInfo(sample1);

            sample2.DecreaseSand();
            sample2.DecreaseClay();
            sampleInfo(sample2);

            sample3.DecreaseSand();
            sample3.DecreaseClay();
            sampleInfo(sample3);

        }

        static void sampleInfo(Dirt sample)
        {
            Console.WriteLine($"contains {sample.GetSand()} grams of sand and {sample.GetClay()} grams of clay.");
            Console.WriteLine();
        }

    }
}
