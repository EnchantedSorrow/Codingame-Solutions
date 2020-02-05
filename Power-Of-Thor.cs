
        while (true) {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            int diffX = lightX - initialTX;
            int diffY = lightY - initialTY;
            string outputDir = "" 
            
            if (diffY > 0) {
                outputDir += "S";
                initialTY++;
            } else if (diffY < 0) {
                outputDir += "N";
                initialTY--;
            }

            if (diffX > 0) {
                outputDir += "E";
                initialTX++;
            } else if (diffX < 0) {
                outputDir += "W";
                initialTX--;
            }

            Console.WriteLine(outputDir);
        }
