package main

import "fmt"

func main() {
    var surfaceN int
    fmt.Scan(&surfaceN)
    
    for i := 0; i < surfaceN; i++ {
        var landX, landY int
        fmt.Scan(&landX, &landY)
    }
    for {
        var X, Y, hSpeed, vSpeed, fuel, rotate, power int
        fmt.Scan(&X, &Y, &hSpeed, &vSpeed, &fuel, &rotate, &power)
		
		if vSpeed <= -40 {
			if power < 4 {
				power++
			}
		} else if (power > 0) {
			power--
		}

        fmt.Println(0," ",power)
    }
}
