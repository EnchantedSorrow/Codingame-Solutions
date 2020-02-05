package main

import "fmt"

func main() {
    var lightX, lightY, initialTx, initialTy int
    fmt.Scan(&lightX, &lightY, &initialTx, &initialTy)
    
    for {
        var remainingTurns int
        fmt.Scan(&remainingTurns)
        
        outputDir := ""
        
        if (lightY - initialTy > 0) {
			outputDir += "S"
			initialTy++;
        } else if (lightY - initialTy < 0) {
			outputDir += "N"
			initialTy--;
		}

		if (lightX - initialTx > 0) {
			outputDir += "E"
			initialTx++;
		} else if (lightX - initialTx < 0) {
			outputDir += "W"
			initialTx--;
		}
        
        
        fmt.Println(outputDir)
    }
}
