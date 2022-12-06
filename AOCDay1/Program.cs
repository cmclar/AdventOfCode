using System;

namespace AOCDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            src.CalorieCalculator calculator = new src.CalorieCalculator();

            calculator.ReadCalories("deps/input.txt");

            int maxCalories = calculator.MaxCalories();

            Console.WriteLine($"Max calories of any elf is: {maxCalories}");

            int maxTopThree = calculator.MaxTopThree();

            Console.WriteLine($"Total calories of the top 3 elfs is: {maxTopThree}");
        }
    }
}

