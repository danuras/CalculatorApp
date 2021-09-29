using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
