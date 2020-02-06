#include <iostream>

using namespace std;

int main() {
    int L;
    cin >> L; cin.ignore();
    int H;
    cin >> H; cin.ignore();
    string T;
    getline(cin, T);
    
    for (int index = 0; index < H; index++) {
        string asciiArt;            //Used to hold the ASCII art
        getline(cin, asciiArt);     //Collect the line of ASCII Art
        
        string Answer;              //Holds answer
        for (int i = 0; i < T.length(); i++) {
            int asciiCode;
            
            //Get position of the letter
            if ((T[i] >= 65) && (T[i] <= 90)) {
                //If A-Z
                asciiCode = T[i] - 65;
            } else if ((T[i] >= 97) && (T[i] <= 122)) {
                //If a-z
                asciiCode = T[i] - 97;
            } else {
                //If not a letter A-Z or a-z
                asciiCode = 26;
            }
            
            //Adds the ASCII character to the string
            for (int j = 0; j < L; j++) {
                char get = asciiArt[((asciiCode * L) + j)];
                Answer += get;
            }
        }
        
        //Output
        cout << Answer << endl;
    }
}
