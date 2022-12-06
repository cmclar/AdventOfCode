using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AOCDay1.src
{
    public class CalorieCalculator
    {
        List<int[]> elfs;

        public CalorieCalculator()
        {
            elfs = new List<int[]>();
        }

        public List<int[]> ReadCalories(string fileName)
        {
            var list = File.ReadAllLines(fileName);

            List<int> elf = new List<int>();

            foreach(string s in list)
            {
                int tempInt;
                if (!string.IsNullOrEmpty(s) && int.TryParse(s, out tempInt))
                {
                    elf.Add(tempInt);
                }
                else
                {
                    if (elf.Any())
                    {
                        elfs.Add(elf.ToArray());
                    }
                    elf.Clear();
                }
            }

            return elfs;
        }

        public int MaxCalories()
        {
            int maxCalories = elfs.Select(elf => elf.Sum()).Max();

            return maxCalories;
        }

        public int MaxTopThree()
        {
            int maxTopThree = elfs.Select(elf => elf.Sum()).OrderByDescending(i => i).Take(3).Sum();

            return maxTopThree;
        }
    }
}

