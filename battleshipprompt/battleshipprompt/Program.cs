namespace battleshipprompt
{
    internal class Program
    {
        // Participants: Dasi, Dave, Robert, Sam

        static void Main(string[] args)
        {
            // Greet player
            Console.WriteLine("Welcome to Battleship.");

            // Set up hiddenGrid and fill with ~
            string[,] hiddenGrid = new string[8, 8];
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    hiddenGrid[row, column] = "~";
                }
            }

            // Set up visibleGrid and fill with ~
            string[,] visibleGrid = new string[8, 8];
            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    visibleGrid[row, column] = "~";
                }
            }

            // Get grid dimensions
            int gridHeight = visibleGrid.GetLength(0); // Get grid height (i.e., number of rows)
            int gridWidth = visibleGrid.GetLength(1); // Get grid width (i.e., number of columns)

            // Place ship(s) on hidden grid
            hiddenGrid[1, 4] = "*";
            hiddenGrid[2, 2] = "*";
            hiddenGrid[1, 3] = "*";
            hiddenGrid[4, 3] = "*";
            hiddenGrid[4, 4] = "*";
            hiddenGrid[5, 0] = "*";
            hiddenGrid[5, 2] = "*";
            hiddenGrid[6, 5] = "*";
            hiddenGrid[6, 6] = "*";
            hiddenGrid[7, 2] = "*";
            hiddenGrid[7, 3] = "*";
            hiddenGrid[7, 4] = "*";
            hiddenGrid[7, 6] = "*";

            // Create variables for tracking numbers of ships and hits
            int numberOfShips = 13; // Total number of cells containing ships
            int numberOfHits = 0; // Total number of cells containing ships that have been hit

            // Inform player of grid size and print out (visible) grid
            Console.WriteLine($"The battle space is {gridHeight}×{gridWidth} cells.");
            for (int row = 0; row < gridHeight; row++)
            {
                for (int column = 0; column < gridWidth; column++)
                {
                    Console.Write(visibleGrid[row, column]);
                }
                Console.WriteLine();
            }

            while (numberOfHits < numberOfShips)
            {
                // Ask player to indicate row and column of cell to target
                Console.WriteLine($"Please enter the row of the cell you'd like to target.");
                int targetRow = Convert.ToInt32(Console.ReadLine()) - 1; // Numerical value of targeted row
                Console.WriteLine($"Please enter the column of the cell you'd like to target.");
                int targetColumn = Convert.ToInt32(Console.ReadLine()) - 1; // Numerical value of targeted column

                // Inform player of hit or miss
                if (hiddenGrid[targetRow, targetColumn] == "*")
                {
                    Console.WriteLine("Hit!");
                    visibleGrid[targetRow, targetColumn] = "X";
                    numberOfHits += 1;
                    Console.WriteLine($"There are {numberOfShips - numberOfHits} ship cells remaining.");
                }
                //else if (hiddenGrid[targetRow - 1, targetColumn] == "*" || hiddenGrid[targetRow, targetColumn - 1] == "*")
                else
                {
                    Console.WriteLine("Miss!");
                    visibleGrid[targetRow, targetColumn] = "O";
                }

                for (int row = 0; row < gridHeight; row++)
                {
                    for (int column = 0; column < gridWidth; column++)
                    {
                        Console.Write(visibleGrid[row, column]);
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Congratulations, you've sunk all the enemy's ships!");
        }
    }
}