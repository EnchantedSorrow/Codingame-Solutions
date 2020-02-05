#include <iostream>
#include <string>
#include <vector>
#include <algorithm>

using namespace std;

int LowestDiff(std::vector<int> &nums, int N) {
    if (N == 0) return 0;
    
    int lowestDiff = nums[N-1];
    
    for (int i = 0; i < N - 1; i++) {
        int diff = nums[i+1] - nums[i];
        
        if (diff < lowestDiff) {
            lowestDiff = diff;
        }
    }
    
    return lowestDiff;
}


int main() {
    int N;
    cin >> N; cin.ignore();
    
    std::vector<int> strengths (N);
    
    for (int i = 0; i < N; i++) {
        cin >> strengths[i]; cin.ignore();
    }
    
    //Sort values
    std::sort(strengths.begin(), strengths.end());
    
    int lowestDiff = LowestDiff(strengths, N);

    cout << lowestDiff << endl;
}
