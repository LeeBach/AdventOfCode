using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Days
{
    internal class Day01PartB
    {
        int result = 0;
        string[] lines = System.IO.File.ReadAllLines("..\\..\\..\\Inputs\\Day01.txt");

        public int Run()
        {
            List<int> listA = new List<int>();
            List<int> listB = new List<int>();
            Dictionary<int, int> freqDict = new Dictionary<int, int>();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] splitLine = lines[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                listA.Add(int.Parse(splitLine[0]));
                listB.Add(int.Parse(splitLine[1]));
            }

            for (int i = 0; i < lines.Length; i++)
            {
                if (freqDict.ContainsKey(listB[i]))
                    freqDict[listB[i]] += 1;
                else
                    freqDict.Add(listB[i], 1);
            }

            for (int i = 0; i < lines.Length; i++)
            {
                int freq = freqDict.ContainsKey(listA[i]) ? freqDict[listA[i]] : 0 ;
                result += listA[i] * freq;
            }

            return result;
        }
    }
}
