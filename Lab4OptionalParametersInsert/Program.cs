using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4OptionalParametersInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            //put this part in Main

            //int fembotAnswer = 0;

            Console.WriteLine("Enemies vary in level of scariness and silliness.");
            Console.WriteLine("Let's figure out how silly your enemies will be.");

            Console.WriteLine("\nOn a scale of 1 - 10, how scary are the Steelers?");
            int steelersAnswer = int.Parse(Console.ReadLine());

            Console.WriteLine("On a scale of 1 - 10, how scary are the Fembots?");
            int fembotAnswer = int.Parse(Console.ReadLine());


            Console.WriteLine($"The Steelers are level {steelersAnswer} on scariness");
            Console.WriteLine($"\tbut a level { SillyEnemies(2, steelersAnswer)} on silliness, which makes them very silly.");

            Console.WriteLine($"The Fembots are level {fembotAnswer} on scariness");
            Console.WriteLine($"\tbut a level { SillyEnemies(fembotAnswer)} on silliness, which makes them only mildly silly.");


            Console.WriteLine("\nDon't worry if those numbers seem nonsensical... this whole calculation is very silly.");
            
            Console.ReadLine();
        }

        static int SillyEnemies (int justSilly, int verySilly = 2)
        {
            int result = 1;

            for (int counter = 1; counter <= verySilly; ++counter)
            {
                result *= justSilly;
            }

            return result;
        }
    }
}
