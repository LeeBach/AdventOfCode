using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Days
{
    internal class Day02PartB
    {
        int result = 0;
        string[] lines = System.IO.File.ReadAllLines("..\\..\\..\\Inputs\\Day02.txt");

        public int Run()
        {
            
            for (int i = 0; i < lines.Length; i++)
            {
                bool safe = true;

                string[] tempLevels = lines[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                List<string> levels = new List<string>();

                for (int j = 0; j < tempLevels.Length; j++)
                {
                    levels.Add(tempLevels[j]);
                }

                int initialDifference = 0;
                int tempCount = 1;
                while (initialDifference == 0)
                {
                    initialDifference = Math.Sign(Int32.Parse(levels[tempCount]) - Int32.Parse(levels[tempCount - 1]));
                    tempCount++;
                }

                for (int j = 1; j < levels.Count; j++)
                {
                    if (Math.Sign(Int32.Parse(levels[j]) - Int32.Parse(levels[j - 1])) != initialDifference ||
                        Math.Abs(Int32.Parse(levels[j]) - Int32.Parse(levels[j - 1])) < 1 ||
                        Math.Abs(Int32.Parse(levels[j]) - Int32.Parse(levels[j - 1])) > 3)
                    {
                        levels.RemoveAt(j);
                        break;
                    }
                }

                for (int j = 1; j < levels.Count; j++)
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
