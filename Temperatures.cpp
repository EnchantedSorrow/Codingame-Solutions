#include <iostream>
#include <cmath>

using namespace std;

int main() {
    int n; // the number of temperatures to analyse
    cin >> n; cin.ignore();
    
    int lowTemp = 0;     //Lowest temp difference
    int index = 0;
    if (n == 0) lowTemp = 0;
    else {
        for (int i = 0; i < n; i++) {
            int tempsCont;
            cin >> tempsCont;

            if (lowTemp == 0) lowTemp = tempsCont;
            
            if (abs(tempsCont) < abs(lowTemp)) lowTemp = tempsCont;
            else if (abs(tempsCont) == abs(lowTemp)) {
                if (tempsCont != lowTemp) lowTemp = abs(lowTemp);
            }
        }
    }
    
    cout << lowTemp << endl;
}
    
