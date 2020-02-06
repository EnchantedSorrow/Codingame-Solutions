using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution {
    static void Main(string[] args) {
        //Get parameters
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        
        //
        for (int i = 0; i < H; i++) {
            string ROW = Console.ReadLine();
            int asciiIndex = 0;
            string output = "";
            
            //Find ascii index relative to the input string
            for (int j = 0; j < T.Count(); j++) {
                if ((T[j] >= 'A') && (T[j] <= 'Z')) {
                    asciiIndex = T[j] - 'A';
                } else if ((T[j] >= 'a') && (T[j] <= 'z')) {
                    asciiIndex = T[j] - 'a';
                } else {
                    asciiIndex = 26;
                }
            
            
                //Get output  from ASCII input
                for (int k = 0; k < L; k++) {
                    output += ROW[(asciiIndex * L) + k];
                }
            }
            
            Console.WriteLine(output);
        }
    }
}
