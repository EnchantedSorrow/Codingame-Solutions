#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int main() {
    int lightX; // the X position of the light of power
    int lightY; // the Y position of the light of power
    int initialTX; // Thor's starting X position
    int initialTY; // Thor's starting Y position
    cin >> lightX >> lightY >> initialTX >> initialTY; cin.ignore();
    
    int posX = initialTX;
    int posY = initialTY;

    // game loop
    while (1) {
        int remainingTurns; // The remaining amount of turns Thor can move. Do not remove this line.
        cin >> remainingTurns; cin.ignore();

        string outputDir = "";
        
        if (lightY - posY > 0)  {
            outputDir += "S";
            posY++;
        } else if (lightY - posY < 0)  {
            outputDir += "N";
            posY--;
        }

        if (lightX - posX > 0) {
            posX++;
            outputDir += "E";
        } else if (lightX - posX < 0) {
            posX--;
            outputDir += "W";
        }

        cout << outputDir << endl;
    }
}
