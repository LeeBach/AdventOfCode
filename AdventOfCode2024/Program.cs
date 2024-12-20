using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2024;

namespace AdventOfCode2024
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Write("Day to run, '01' - '25': ");
                string day = Console.ReadLine();
                Console.Write("Part to run, 'A' or 'B': ");
                string part = Console.ReadLine();

                object dayToRun = Activator.CreateInstance(Type.GetType($"AdventOfCode2024.Days.Day{day}Part{part}"));
                Console.Write($"Day{day}Part{part} result: ");
                Console.WriteLine(dayToRun.GetType().GetMethod("Run").Invoke(dayToRun, null));

                Console.Write("Run another day? (y/n): ");
                running = Console.ReadLine().ToLower() == "y";
            }

            System.Environment.Exit(1);
        }
    }
}
