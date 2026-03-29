(a) Project Tittle: StarFix

(b) Group Members:
Ranjitaranee 
Nurul Iman Batrisyia binti Mohd Romizan
Engku Nurul Faraheen binti Engku Zaid
Shanchanaa Subramaniam
Dzulfan bin Mohd Noor

(c) Project Description
StarFix is a C# Windows Forms (GUI-based) quiz game where the player takes on the role of a scientist repairing a damaged spaceship. The player must answer space-related quiz questions correctly to restore the ship’s systems and safely return to Earth. Each correct answer repairs the spaceship and increases the player’s score, while incorrect answers or timeouts reduce lives. The game progresses through 2 levels with increasing difficulty and the mission is successful only if the player completes all levels before losing all lives.

The system integrates game logic, user interaction and real-time feedback using a graphical interface, making the gameplay interactive and engaging.

(d) System Features
(i) Player Management
   - Player can enter their name before starting
   - Tracks player score and remaining lives
(ii) Quiz System
   - Multiple-choice questions (3 options per question)
   - Questions are organized into levels
   - Input validation ensures only valid answers (1–3) are accepted
(iii) Level System
   - Multiple levels (2 levels)
   - Level progression after completion
   - Option to proceed or end after each level
(iv) Spaceship Repair Mechanism
   - Spaceship repair progress increases with correct answers
   - Damage or reset occurs when player fails
   - Status messages provide real-time feedback
(v) Timer System
   - Countdown timer (30 seconds per question)
   - Player loses a life if time runs out
   - Automatically proceeds to next question after timeout
(vi) Game State Control
   - Detects level completion, game completion and player failure
   - Restart level when all lives are lost
   - Displays final mission result (Success/Failure)
(vii) Graphical User Interface (GUI)
   - Built using Windows Forms
   - Interactive buttons (Start, Submit)
   - Displays question, choices, score, lives and timer
   - Uses message boxes for feedback and alerts
(viii)Exception Handling
   - Handles unexpected errors during application startup
   - Input validation prevents invalid user entries

(e) OOP Concepts Used
The StarFix system applies several Object-Oriented Programming (OOP) concepts to ensure a well-structured and maintainable design. Encapsulation is implemented throughout the system by using private fields and public properties to control access to data. For example, classes such as `Player`, `Spaceship` and `Level` restrict direct access to their internal variables like score, lives and repair progress. Validation logic is also included within property setters to ensure that only valid values are assigned which improves data integrity.

Abstraction is demonstrated through the use of the abstract class `Question`, which defines a general structure for all question types without exposing full implementation details. This allows the system to focus on what a question should do rather than how it is implemented. The abstract method `GetFormattedQuestion()` ensures that all derived classes provide their own version of how a question is displayed.

Inheritance is used by the `SpaceQuizQuestion` class, which is derived from the `Question` class. This allows it to reuse common properties and methods while also customizing behavior specific to the game. Through inheritance, code duplication is reduced and the system becomes easier to extend.

Polymorphism is achieved through method overriding and virtual methods. The `SpaceQuizQuestion` class overrides the `GetFormattedQuestion()` method to provide a unique format for displaying questions. Additionally, the `CheckAnswer()` method is defined as virtual in the base class, allowing it to be modified in derived classes if needed. This enables flexibility in how different question types behave.

Furthermore, the system uses collections, specifically `List<T>`, to manage groups of data such as questions, levels and answer options. This allows dynamic storage and easy iteration through elements during gameplay.

Finally, exception handling is implemented to improve system reliability. A try-catch block in the main program prevents the application from crashing due to unexpected errors, while input validation in the GUI ensures that users provide correct and acceptable input values.


(g) How to Run the Program
(i) Click on the green "Code" button on the top right of the GitHub repository
(ii) Find "launch in Visual Studio" option and click on it
(iii) Clone GitHub repository
(iv) Run using Start Debugging (F5)

OR
(i) Click on the green "Code" button on the top right of the GitHub repository
(ii) Find "Download ZIP files" option and click on it
(iii) Extract ZIP files once downloaded
(iv) Open the .sln file in Visual Studio
(v) Click Start Debugging (F5) to run

(h) Project Structure

File                 Description
Program.cs           Main program that starts the game and handle user interaction
Game.cs              Controls overall game logic, levels and flow of the game
Level.cs             Represents each game level and stores a list of questions
Player.cs            Stores player information such as name, score and lives
Spaceship.cs         Manages spaceship repair progress and status messages
Question.cs          Abstract class that defines the structure of a question
SpaceQuizQuestion    Child class implementing specific question behaviour

