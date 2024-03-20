using System;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace FunctionChallenges
{
    class Program
    {

        //Function of Challenge 1
        public static void StringNumberProcessor(params object[] inputs){
        string concatenatedString = "";
        int sumOfNumbers = 0;

        foreach (var input in inputs)
        {
            if (input is string)
            {
                concatenatedString += input + " ";
            }
            else if (input is int)
            {
                sumOfNumbers += (int)input;
            }
        }

        // Trim white space from the string
        concatenatedString = concatenatedString.Trim();

        // Print the string + number 
        Console.WriteLine($"{concatenatedString}; {sumOfNumbers}");
    }

    //Function of Challenge 2 
    //Description: The function should only swap objects if they are of the same type, either string or number. 
    //For string, their lengths must be more than 5, and for number, they must be more than 18.
    public static void SwapObjects(params object[] inputs) {


    }
    //Function of Challenge 3
    public static void GuessingGame()
{
    Random num = new Random();
    Console.WriteLine("To play the Guessing Game...Enter a random number, and if you guess correctly you win :)");
    Console.WriteLine("Type 'End' to quit the game..");

    while (true)
    {
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "end")
        {
            Console.WriteLine("You've exited the game");
            break;
        }

        try
        {
            int guess = int.Parse(userInput);
            int randomNum = num.Next(100);

            if (guess == randomNum)
            {
                Console.WriteLine("Congrats you've guessed correctly");
            }
            else
            {
                Console.WriteLine("Good try.. but not the right number P.S: Type 'End' to quit the game..");
                Console.WriteLine($"The correct number was {randomNum}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

   

        static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"
            StringNumberProcessor("Hello", 100, 500, "World"); 

            // Challenge 2: Object Swapper
            // Console.WriteLine("\nChallenge 2: Object Swapper");
            // int num1 = 25, num2 = 30;
            // int num 3 = 10, num4 = 30;
            // string str1 = "HelloWorld", str2 = "Programming";
            // string str3 = "Hi", str4 = "Programming";
                          
            // SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            // SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            // SwapObjects(str1, str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            // SwapObjects(str3, str4); // Error: Length must be more than 5

            // SwapObjects(true, false); // Error: Upsupported data type
            // SwapObjects(ref num1, str1); // Error: Objects must be of same types

            // Console.WriteLine($"Numbers: {num1}, {num2}");
            // Console.WriteLine($"Strings: {str1}, {str2}");

            // Challenge 3: Guessing Game
            Console.WriteLine("\nChallenge 3: Guessing Game");
            // Uncomment to test the GuessingGame method
             GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`

            // // Challenge 4: Simple Word Reversal
            // Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            // string sentence = "This is the original sentence!";
            // string reversed = ReverseWords(sentence);
            // Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
        }
    }
}
