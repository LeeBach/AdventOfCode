using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Days
{
    internal class Day02PartA
    {
        int result = 0;
        string[] lines = System.IO.File.ReadAllLines("..\\..\\..\\Inputs\\Day02.txt");

        public int Run()
        {
            
            for (int i = 0; i < lines.Length; i++)
            {
                bool safe = true;

                string[] levels = lines[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int initialDifference = Math.Sign(Int32.Parse(levels[1]) - Int32.Parse(levels[0]));

                for (int j = 1; j < levels.Length; j++)
                {
                    if (Math.Sign(Int32.Parse(levels[j]) - Int32.Parse(levels[j - 1])) != initialDifference ||
                        Math.Abs(Int32.Parse(levels[j]) - Int32.Parse(levels[j - 1])) < 1 ||
                        Math.Abs(Int32.Parse(levels[j]) - Int32.Parse(levels[j - 1])) > 3)
                    {
                        safe = false;
                        break;
                    }
                }

                if (safe) result++;

            }
            
            return result;
        }
    }
}
