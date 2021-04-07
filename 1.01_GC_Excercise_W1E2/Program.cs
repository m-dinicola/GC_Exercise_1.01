using System;

namespace _1._01_GC_Excercise_W1E2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint length, width; // unsigned to allow TryParse to handle validity testing
            Console.Write("Please enter the room's length (numerical positive integer): ");
            while (!uint.TryParse(Console.ReadLine(), out length))  //will repeat read/write until TryParse resolves
            {
                Console.Write("Invalid. Enter a valid length, please: ");
            }
            Console.Write("Please enter the room's width (numerical positive integer): ");
            while (!uint.TryParse(Console.ReadLine(), out width)) //same as previous loop
            {
                Console.Write("Invalid. Enter a valid width, please: ");
            }
            length *= width;                                          //length is now actually an area
            string areaUnits = length.ToString()+ ((length == 1) ? " square foot" : " square feet");  //creating string to handle num & plurals
            Console.WriteLine("Your room has an area of " + areaUnits); //putting it all together
        }
    }
}
