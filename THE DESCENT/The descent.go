package main

import "fmt"

func main() {
    for {
        
        highestIndex := 0
        highestHeight := 0
        
        for i := 0; i < 8; i++ {
            // mountainH: represents the height of one mountain.
            var mountainH int
            fmt.Scan(&mountainH)
            
            if (mountainH > highestHeight) {
                highestHeight = mountainH
                highestIndex = i
            }
        }
        
        fmt.Println(highestIndex) // The index of the mountain to fire on.
    }
}