#include <iostream>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
    while (1) {
        int heights[8];
        int max = 0;
        for (int i = 0; i < 8; i++) {
            int mountainH; // represents the height of one mountain, from 9 to 0.
            cin >> mountainH; cin.ignore();
            heights[i] = mountainH;
            if (heights[max] < heights[i]) max = i;
        }

        cout << to_string(max) << endl;
    }
}