using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine());
        
        int[] nums = new int[N];
        int answer = -1;
        
        for (int i = 0; i < N; i++) {
            int pi = int.Parse(Console.ReadLine());
            
            nums[i] = pi;
        }

        Array.Sort(nums);
           
        Console.WriteLine(FindMinDiff(nums));
    }
    
    static public int FindMinDiff(int[] nums) {
        if (nums.Length <= 0) {
            return 0;
        }

        int minDiff = nums[nums.Length - 1];
        
        for (int i = 0; i < nums.Length - 1; i++) {
            int diff = nums[i+1] - nums[i];

            if (diff < minDiff) {
                minDiff = diff;
            }
        }

        return minDiff;
    }
}
