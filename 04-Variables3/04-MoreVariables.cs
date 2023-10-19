using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

/*
===============================================================================
PROJECT 04: MORE VARIABLES
===============================================================================
Objective:
- Understand and practice creating and using variables to store and manipulate data.

Main Tasks:
1. This program has 3 errors that you can fix by creating some variables.
   Create the correct variables using 3 different data types so that the WriteLine statement outputs:
   "As of 2016 the population of China was 1.379 billion."

Questions:
1. Why were the words "year", "country", and "population" originally underlined? because they had nothing connected to it
2. What is the purpose of the dollar sign ($) before the double quotes in the final message? i have no clue

Extension Tasks:
1. Print out another statement using three or more new variables of different data types.
2. Find out how to include "double quotes" in a string using an "escape character".
3. Find out how to round down or change the display format of a number using ".ToString()".        

Additional Resources:
- String Interpolation: https://www.w3schools.com/cs/cs_strings_interpol.php
- Escape and Special Characters: https://www.w3schools.com/cs/cs_strings_chars.php
- Formatting Strings: https://learn.microsoft.com/en-us/dotnet/standard/base-types/formatting-types
- Standard Numeric Formats: https://learn.microsoft.com/en-us/dotnet/standard/base-types/formatting-types
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_04_MoreVariables
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            int year = 1945;
            string country = "Hiroshima";
            int population = 0;

            // Do not edit below this line
            Console.WriteLine($"As of {year} the population of {country} was {population} billion.");
            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================
Feedback from Craig on your C# Programming Task

Code structure: Your code is well-structured and clean. You have correctly declared and initialized your variables. Good job!

Variable naming: Your variable names are clear and descriptive which is good practice.

Code logic: The logic of your code is correct. The Console.WriteLine statement correctly uses string interpolation to include the values of your variables.

Comments: Your comments are clear and useful. You've correctly followed the instructions not to edit below a certain line.

Areas for Improvement

Value of population variable: You've initialized the population variable as 0. While technically correct, it might be more meaningful to provide a realistic population number for Hiroshima in 1945.

Code commenting: While your comments are clear, consider adding more comments in your code to explain what each part does. This is especially useful for more complex code.

Missing tasks: As per the instructions, there should be numbered tasks in the comments. If these were provided and you've not completed them, make sure to do so in future assignments.

Keep up the good work!


===============================================================================
*/
