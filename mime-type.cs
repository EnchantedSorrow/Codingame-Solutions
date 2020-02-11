using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        
        Dictionary<string, string> mimeTypes =  new Dictionary<string, string>();
        
        string[] EXT = new string[N];
        string[] MT = new string[N];
        
        for (int i = 0; i < N; i++) {
            string[] inputs = Console.ReadLine().Split(' ');
            
            string tempEXT = inputs[0].ToLower(); // file extension
            string tempMT = inputs[1]; // MIME type.
  
            if ((CheckIfValid(tempEXT, tempMT)) && (mimeTypes.ContainsKey(tempEXT) == false)) {
                mimeTypes.Add(tempEXT, tempMT);
            }
        }
        
        for (int i = 0; i < Q; i++) {
            string fName = Console.ReadLine(); // One file name per line.
            fName = fName.ToLower();

            if (CheckFileNameValid(fName)) {
                //Compare extension
                string fNameFile = fName.Substring(fName.LastIndexOf('.') + 1);
                    
                if (mimeTypes.ContainsKey(fNameFile)) {
                    Console.WriteLine(mimeTypes[fNameFile]);
                } else {
                    Console.WriteLine("UNKNOWN");
                }
            } else  {
                Console.WriteLine("UNKNOWN");
            }
        }
    }

    static bool CheckIfValid(string extension, string mimeType) {
        if ((extension.Length > 10) || (extension.Contains(" "))) {
            return false;
        }
        if ((mimeType.Length > 50) || (mimeType.Contains(" "))) {
            return false;
        }
        
        return true;
    }

    static bool CheckFileNameValid(string fileName) {
        if (fileName.Length > 256) {
            return false;
        }
        if (fileName.Contains(" ")) {
            return false;
        }
        if (fileName.IndexOf('.') == -1) {
            return false;
        }

        return true;
    }
}
