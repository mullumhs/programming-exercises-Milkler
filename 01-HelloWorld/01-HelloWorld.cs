using System;

/*
===============================================================================
PROJECT 01: HELLO WORLD
===============================================================================
Objective:
- Familiarize with basic console output and input operations in C#.

Main Tasks:
1. Output 'Hello World!' to the console screen using 'Console.WriteLine();'.
2. Make the program wait for input using 'Console.ReadLine();'.

Questions:
1. What is the difference between input and output?
Imput is Brom the person
Output is from the computer
Extension Tasks:
1. Output another message / pause after the ReadLine.
2. Research online how to change the colour and/or make the console beep.

Additional Resources:
- Microsoft Docs: Console.WriteLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline
- Microsoft Docs: Console.ReadLine Method: https://docs.microsoft.com/en-us/dotnet/api/system.console.readline
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_01_HelloWorld
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("Hey Kitty");
            Console.ReadLine();
            Console.WriteLine("Goodbye Kitty");
            Console.Beep(10000,10000);
            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
Craig Feedback:

Task 1: You have successfully used Console.WriteLine() to output a string to the console. However, the task was to output 'Hello World!', but you have used 'Hey Kitty'. Try to stick to the task requirements.

Task 2: You have correctly used Console.ReadLine() to make the program wait for input before proceeding. Well done!

Extension Task 1: You have successfully output another message after the Console.ReadLine(). Good job!

Extension Task 2: You have correctly used Console.Beep() to make the console beep. However, the frequency and duration you have used (10000,10000) may result in a very loud and long beep. You might want to experiment with different values.

Code Commenting Feedback:

Your code could benefit from more comments, especially before each line of code explaining what it does. This is good practice and helps others understand your code.
Question Feedback:

Your answer to the question about the difference between input and output is not entirely accurate. Input refers to the data entered into the computer by the user, while output is the data that the computer returns after processing. Try to provide more detail in your answers.
Overall:

You're doing well! Just remember to follow the task requirements more closely and add more comments to your code. Keep practicing!


===============================================================================
*/