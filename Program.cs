using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quadient_Hires
{
    class Program
    {
        public static void Main(string[] args)
        {
            int firstSize; 
            int secondSize;
            int steps;
            AstroantColony colony1;
            AstroantColony colony2;
            AstroantColony valley;

            Console.WriteLine("********    Welcome to the world of Quadient!    ********\n");
            //Console input for size of the first colony with number verification
            Console.WriteLine("Enter a size of first colony:");
            while ((!int.TryParse(Console.ReadLine(), out firstSize)) || (firstSize <=  0))
            {
                Console.WriteLine("Invalid size. Try again.");
            }

            //Console input for size of the second colony with number verification
            Console.WriteLine("Enter a size of second colony:");
            while ((!int.TryParse(Console.ReadLine(), out secondSize)) || secondSize <= 0)
            {
                Console.WriteLine("Invalid size. Try again.");
            }

            //set number of steps/moves colony do
            Console.WriteLine("Number of moves:");
            while ((!int.TryParse(Console.ReadLine(), out steps)) || steps < 0)
            {
                Console.WriteLine("Invalid number. Try again.");
            }

            //Create both colonies with given size and color
            colony1 = new AstroantColony(firstSize, 0);
            colony2 = new AstroantColony(secondSize, 1);

            //And create an interpretation of valley and positions of members of each colony when they meets
            valley = new AstroantColony();
            valley.addColony(colony1.getColony());
            valley.addColony(colony2.getColony());
            

            //it's time to perform number of moves specified at the beginning
            valley.move(steps, valley);
            

            //output of the program 
            Console.WriteLine("\n\nFinal status of each colony after given steps:\n  0 - Astroant from green colony\n  1 - Astroant from blue colony\n");
            AstroantColony.printColony(valley);


            //don't close the program immediately and wait for an enter ;)
            Console.ReadLine();

        }
        
        
    }
}
