using System;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int A=0;
            Console.Write("Nhap so can tim:");
            string inputA = Console.ReadLine();
            A = Int32.Parse(inputA);

            int tram = A / 100;

            int chuc = ((A % 100 / 10));

            int dv = (A % 10);

            Console.WriteLine("chuc So Tram:"+tram);
            Console.WriteLine("chuc So Chuc:" + chuc);
            Console.WriteLine("chuc So Don Vi:" + dv);
            Console.ReadLine();
        }
    }
}
