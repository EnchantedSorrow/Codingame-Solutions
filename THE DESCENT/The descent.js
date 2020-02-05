while (true) {
    var highestIndex = 0
    var highestHeight = 0
    
    for (let i = 0; i < 8; i++) {
        const mountainH = parseInt(readline()); // represents the height of one mountain.
        
        if (mountainH > highestHeight) {
            highestHeight = mountainH
            highestIndex = i
        }
    }

    console.log(highestIndex);     // The index of the mountain to fire on.

}