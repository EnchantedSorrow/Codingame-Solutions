using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution {
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string temps = Console.ReadLine(); // the n temperatures expressed as integers ranging from -273 to 5526

        int lowestTemp = 0;
        
        if (n > 0) {
            int marker = 0;
            int[] temperatures = new int[n];
            
            string[] tempContainer = new string[n];
            tempContainer = temps.Split(' ');
            for (int i = 0; i < n; i++) {
                temperatures[i] = int.Parse(tempContainer[i]);
            }
            
            
            int currTemp = 0;
            
            for (int i = 0; i < n; i++)
            {
                currTemp = temperatures[i];                
                if (lowestTemp == 0) {
                    lowestTemp = currTemp;
                } else {
                    if (Math.Abs(currTemp) < Math.Abs(lowestTemp)) lowestTemp = currTemp;
                    else if (Math.Abs(currTemp) == Math.Abs(lowestTemp)) {
                        if (currTemp != lowestTemp) lowestTemp = Math.Abs(lowestTemp);
                    }
                }
            }
        }
        
        Console.WriteLine(lowestTemp);
    }
}
