📦 Overview
This is a basic implementation of the classic Battleship game, built entirely using C# and the .NET console. The game initializes an 8x8 grid where ships are hidden from the player. The player attempts to sink all the hidden ships by guessing their positions.

Created by: Dasi, Dave, Robert, Sam
Language: C#
Platform: Console Application (.NET)

🎮 How to Play
Run the application.

You'll see a blank 8x8 grid representing the ocean.

Enter the row and column numbers (1–8) to target a specific cell.

The game will tell you if it's a Hit or Miss.

The goal is to hit all 13 hidden ship cells.

The game ends when all ship parts are destroyed.

Symbols:
~ = Unknown / Untargeted cell

X = Hit

O = Miss

🛠️ Features
8x8 grid initialization

Pre-placed ships at specific coordinates

User input for targeting

Real-time hit/miss feedback

Visual update of the player's known battlefield

Win condition when all ship cells are hit

📌 Notes
Ship locations are hardcoded and not randomly generated.

No input validation or error handling is included — future improvements could add this.

There's no multiplayer mode or AI.

💡 Future Improvements
Random ship placement

Input validation and error handling

Add AI or multiplayer mode

Graphical interface (WPF or Unity version)
