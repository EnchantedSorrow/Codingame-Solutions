package main

import (
	"fmt"
	"sort"
)

func main() {
    var N int
    fmt.Scan(&N)
    
	strengths := []int{}
	
    for i := 0; i < N; i++ {
        var pi int
		fmt.Scan(&pi)
		
		strengths = append(strengths, pi)
    }
	
	sort.Ints(strengths)

	fmt.Println(ReturnMinDiff(strengths))
}

func ReturnMinDiff(nums []int) int {
	if (len(nums) == 0) {
		return 0;
	}

	minDiff := nums[len(nums) - 1]

	for i := 0; i < len(nums) - 1; i++ {
		diff := nums[i + 1] - nums[i]

		if (diff < minDiff) {
			minDiff = diff
		}
	}

	return minDiff
}
