# StarFix – OOP Assignment (C# Windows Forms)

## Project Description
StarFix is a C# Windows Forms application that simulates a space mission quiz game. 
The player acts as a pilot who must answer questions correctly to stabilize the spaceship systems.

The project demonstrates Object-Oriented Programming (OOP) concepts, with a focus on encapsulation, class interaction, and GUI development.

---

## Features
- Player system with score and lives
- Question-based gameplay
- Timer-based challenge
- Interactive Windows Forms graphical user interface (GUI)
- Real-time feedback for correct and incorrect answers

---

## Object-Oriented Design

### Classes Implemented

#### 1. Player
- Stores player name, score, and lives
- Methods:
  - AddScore()
  - LoseLife()
  - IsAlive()

#### 2. Question
- Stores question text, options, and correct answer
- Methods:
  - Display()
  - CheckAnswer()

#### 3. Game
- Controls game flow and logic
- Manages questions, player interaction, and scoring
- Methods:
  - StartGame()
  - ShowQuestion()
  - SubmitAnswer()
  - EndGame()

---

## Encapsulation
Encapsulation is implemented by using private fields in each class to protect data. Public properties are used to provide controlled access to these fields. This ensures that data cannot be modified directly without validation, improving data security and program reliability.

---

## Technologies Used
- C#
- Windows Forms (WinForms)
- Visual Studio

---

## How to Run
1. Open the project in Visual Studio
2. Build the solution
3. Run the application
4. Enter your name and click "Start Game"
5. Answer questions using the buttons

---

## GitHub Repository
This project is stored in a private GitHub repository as required by the assignment.
