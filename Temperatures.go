package main

import "fmt"
import "os"
import "bufio"
import "strings"
import "strconv"
import "math"

func main() {
    scanner := bufio.NewScanner(os.Stdin)
    scanner.Buffer(make([]byte, 1000000), 1000000)

    // n: the number of temperatures to analyse
    var n int
    scanner.Scan()
    fmt.Sscan(scanner.Text(),&n)
    
    scanner.Scan()
	inputs := strings.Split(scanner.Text()," ")
	var lowestTemp int64 = 0
    for i := 0; i < n; i++ {
        // t: a temperature expressed as an integer ranging from -273 to 5526
        t,_ := strconv.ParseInt(inputs[i],10,32)
		
		if (i == 0) {
			lowestTemp = t
		} else {
			if (math.Abs(float64(t)) < math.Abs(float64(lowestTemp))) {
				lowestTemp = t
			} else if (math.Abs(float64(t)) == math.Abs(float64(lowestTemp))) {
				if (t != lowestTemp) {
				    lowestTemp = int64(math.Abs(float64(lowestTemp)))
				}
			}
		}
    }
    
    fmt.Println(lowestTemp)
}
