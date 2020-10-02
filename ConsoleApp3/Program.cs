using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Высокий
            try
            {
                double V, h, S1, S2, a, b;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите a:");
                a = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                S1 = (a * a);
                Console.WriteLine("S1=" + S1);
                Console.WriteLine($"Площадь Основания S1 = {S1}");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите b:");
                b = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                S2 = (b * b);
                Console.WriteLine("S2=" + S2);
                Console.WriteLine($"Площадь Основания S2 = {S2}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Введите h:");
                h = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                V = h * (S1 + Math.Sqrt(S1 * S2) + S2) / 3;
                Console.WriteLine("V=" + V);
                Console.WriteLine($"Объём усечённой пирамиды V = {V}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
