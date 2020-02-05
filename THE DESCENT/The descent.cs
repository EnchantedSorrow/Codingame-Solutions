using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            int highestIndex = 0;
            int highestHeight = 0;
            
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                if (mountainH > highestHeight)
                {
                    highestHeight = mountainH;
                    highestIndex = i;
                }
            }

            Console.WriteLine(highestIndex); // The index of the mountain to fire on.
        }
    }
}