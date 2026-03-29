(a) Project Title: #StarFix#
(b) Group Members
- Ranjitaranee A/P Ramesh (24006978)
- Nurul Iman Batrisyia binti Mohd Romizan (25014830)
- Engku Nurul Faraheen binti Engku Zaid (25011533)
- Shanchanaa A/P Subramaniam (24006193)
- Dzulfan bin Mohd Noor (21001006)
- Dhesigan A/L Vengadajalapathy (22009144)

(c) Project Description
StarFix is a C# Windows Forms (GUI-based) quiz game where the player takes on the role of a scientist repairing a damaged spaceship. The player must answer space-related quiz questions correctly to restore the ship’s systems and safely return to Earth. Each correct answer repairs the spaceship and increases the player’s score, while incorrect answers or timeouts reduce lives. The game progresses through 2 levels with increasing difficulty, and the mission is successful only if the player completes all levels before losing all lives.
The system integrates game logic, user interaction, and real-time feedback using a graphical interface, making the gameplay interactive and engaging.

(d) System Features
1. Player Management
- Player can enter their name before starting.
- Tracks player score and remaining lives (starts with 3 lives).

2. Quiz System
- Multiple-choice questions (3 options per question).
- Questions are organized into themed levels.
- Input validation ensures only valid answers are accepted.

3. Level System
- Multiple levels (2 levels currently implemented).
- Level progression triggers automatically after completing all questions in a level.
- Option to proceed to the next stage or end the session.

4. Spaceship Repair Mechanism
- Spaceship repair progress (0–100%) increases with correct answers.
- Status messages provide real-time feedback on ship integrity.
- Reset or damage occurs if the player fails a level.

5. Timer System
- Countdown timer (30 seconds per question).
- Player loses a life if the timer reaches zero.
- Automatically proceeds to the next question after a timeout.

6. Game State Control
- Detects level completion, overall game success, and player failure.
- Restart level option when all lives are lost.
- Displays final mission results (Success/Failure) with the final score.

7. Graphical User Interface (GUI)
- Built using Windows Forms for a visual experience.
- Interactive controls (Buttons for Start, Submit, and Navigation).
- Real-time display for questions, choices, score, lives, and the timer.

8. Exception Handling
- Robust startup error handling to prevent application crashes.
- Property-level validation to maintain data integrity.

(e) OOP Concepts Used
1. Encapsulation
Encapsulation is demonstrated through private fields and public properties. For example, the Question class has private fields questionText, options, and correctAnswer. Access to these fields is controlled through public read-only properties like QuestionText and Options. By providing only a get accessor, the class prevents direct modification of data by other parts of the program, ensuring data integrity.

2. Abstraction
Abstraction is achieved through the use of the abstract keyword to define the shared structure of questions. The abstract Question class acts as a blueprint, ensuring that all derived question classes implement essential functionality, such as the GetFormattedQuestion() method. This enforces consistency, allowing the Game controller to interact with all question objects through a unified interface.

3. Inheritance
Inheritance is implemented via the abstract Question class, which acts as a parent for specific question types. The SpaceQuizQuestion class inherits from Question, allowing it to reuse common properties and behaviors (like the constructor and checking logic) while adding specific functionality for space-themed content. This eliminates code duplication and makes the system easy to extend.

4. Polymorphism
Polymorphism is achieved through method overriding. The abstract method GetFormattedQuestion() is declared in the Question class and is overridden in the SpaceQuizQuestion class to provide a unique mission-themed format. This allows the system to treat all question objects uniformly while executing specific, flexible behavior at runtime.

5. Collections
Collections, specifically List<T>, are utilized to manage multiple questions and levels efficiently. The Level class uses a List<Question> to store stage-specific data. This allows for dynamic storage, easy iteration during gameplay, and ensures the game can scale to include more content in the future.

6. Exception Handling
Exception Handling improves system robustness using try-catch blocks. In the Program class, the application startup is wrapped in a try-catch block to handle unexpected errors gracefully without crashing. Additionally, input validation and null-checks (such as in the Questions property setter) ensure the game remains stable during user interaction.

(g) How to Run the Program
There are two methods given. Choose the one that works best for you.
Method 1:
1. Click on the green "Code" button on the top right of the GitHub repository.
2. Select "Download ZIP" option and extract the files once downloaded.
3. Open the .sln file in Visual Studio 2022.
4. Press F5 or click Start Debugging to run the application.

Method 2:
1. Click on the green "Code" button on the top right of the GitHub repository.
2. Find "launch in Visual Studio" option and click on it.
3. Clone GitHub repository.
4. Press F5 or click "Start Debugging" to run the application.

(h) Project Structure
|---------------|------------------------------------------------------------------------------------------|
| File          | Description                                                                              |
|---------------|------------------------------------------------------------------------------------------|
| Program.cs    | Main program that starts the game and handles user interaction.                          |
| Form1.cs      | The Graphical User Interface (GUI) that manages user inputs, timers and visual updates.  |
| Game.cs       | Controls overall game logic, levels and flow of the game.                                |
| Level.cs      | Represents each game level and stores a list of questions.                               |
| Player.cs     | Manages player-specific data including name, lives and score.                            |
| Spaceship.cs  | Manages spaceship repair progress and status messages.                                   |
| Question.cs   | Contains the abstract Question base class and the SpaceQuizQuestion derived class.       |
|---------------|------------------------------------------------------------------------------------------|

