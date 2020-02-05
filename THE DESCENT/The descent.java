import java.util.*;
import java.io.*;
import java.math.*;


class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        
        // game loop
        while (true) {
            
            int highestIndex = 0;
            int highestHeight = 0;
            for (int i = 0; i < 8; i++) {
                int mountainH = in.nextInt(); // represents the height of one mountain.
                
                if (mountainH > highestHeight) {
                    highestHeight = mountainH;
                    highestIndex = i;
                }
            }


            System.out.println(highestIndex); // The index of the mountain to fire on.
        }
    }
}