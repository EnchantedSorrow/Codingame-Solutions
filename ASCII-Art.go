package main

import "fmt"
import "os"
import "bufio"

func main() {
    scanner := bufio.NewScanner(os.Stdin)
    scanner.Buffer(make([]byte, 1000000), 1000000)

    var L int
    scanner.Scan()
    fmt.Sscan(scanner.Text(),&L)
    
    var H int
    scanner.Scan()
    fmt.Sscan(scanner.Text(),&H)
    
    scanner.Scan()
	T := scanner.Text()
	output := ""
    for i := 0; i < H; i++ {
        scanner.Scan()
		ROW := scanner.Text()
		
		for i := 0; i < len(T); i++ {
            var ascii int
            ascii = int(T[i])

            if (ascii >= 65) && (ascii <= 90) {
                ascii -= 65
            } else if (ascii >= 97) && (ascii <= 122) {
                ascii -= 97
            } else {
                ascii = 26
            }

            for j := 0; j < L; j++ {
                index := (ascii * L) + j
                output = output + string(ROW[index])
            }
            
		}
		output += "\n"
	}
    fmt.Println(output)// Write answer to stdout
}
