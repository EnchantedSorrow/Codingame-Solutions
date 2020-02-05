import sys
import math

while True:
    highestIndex = 0
    highestHeight = 0
    
    for i in range(8):
        mountain_h = int(input())  # represents the height of one mountain.
        if mountain_h > highestHeight:
            highestHeight = mountain_h
            highestIndex = i

    # The index of the mountain to fire on.
    print(highestIndex)