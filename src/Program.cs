using System;

namespace FunctionChallenges
{
    class Program
    { 

        
        //Function of Challenge 1
        static void StringNumberProcessor(params object[] inputs){
        string concatenatedString = ""; 
        List<string>  stringInputs = new List<string>();
        int sumOfNumbers = 0;
     try { 
        foreach (var input in inputs)
          {
            if (input is string)
            {
                concatenatedString += input + " ";
                stringInputs.Add((string)input);
               
            }
            else if (input is int)
            {
                sumOfNumbers += (int)input;
            }
        } }
        catch(Exception e)
        { 
            Console.WriteLine(e.Message);
        }


        // Trim white space from the string
        concatenatedString = concatenatedString.Trim();

        // Print the string + number 
        Console.WriteLine($"{concatenatedString}; {sumOfNumbers}");
    }

    //Function of Challenge 2 
    static void SwapObjects(ref object obj1, ref object obj2) {

        if (obj1.GetType() != obj2.GetType()) { 
    
                Console.WriteLine("Objects must be of the same type.");
                return;
            }

            if (obj1 is string && ((string)obj1).Length > 5 && ((string)obj2).Length > 5)
            {
                var temp = obj1;
                obj1 = obj2;
                obj2 = temp;
            }
            else if (obj1 is int && (int)obj1 > 18 && (int)obj2 > 18)
            {
                var temp = obj1;
                obj1 = obj2;
                obj2 = temp;
            }
            else
            {
                Console.WriteLine("Objects don't meet swapping conditions.");
            }

     }
   
    //Function of Challenge 3
    static void GuessingGame() {
    Random num = new Random();
    Console.ForegroundColor = ConsoleColor.Green;
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
    } }

    //Function 4: Challenge 4
      // Function 4: Challenge 4
static string ReverseWords(string sentence)
{
    if (string.IsNullOrWhiteSpace(sentence))
    {
        throw new Exception("Invalid Input...");
    }

    string[] sentenceArray = sentence.Split(' ');
    List<string> reversedWords = new List<string>();

    foreach (var str in sentenceArray)
    {
        string reversedWord = new string(str.Reverse().ToArray());
        reversedWords.Add(reversedWord);
    }

    string result = string.Join(" ", reversedWords);
    Console.WriteLine($"Result: {result}"); 
    return result;
}

          static void Main(string[] args)
        {
            // Challenge 1: String and Number Processor
            Console.WriteLine("Challenge 1: String and Number Processor");
            StringNumberProcessor("Hello", 100, 200, "World"); // Expected outcome: "Hello World; 300"
            StringNumberProcessor("Hello", 100, 500, "World"); 
            StringNumberProcessor("Hello", 100, "Hi", 500, 700, "World"); 


            // Challenge 2: Object Swapper
            Console.WriteLine("\nChallenge 2: Object Swapper");
            int num1 = 25;
            int num2 = 30;
            // int num3 = 10, num4 = 30;
            string str1 = "HelloWorld", str2 = "Programming";
            string str3 = "Hi", str4 = "Programming";  
            object objNum1 = num1;
            object objNum2 = num2;
            SwapObjects(ref objNum1, ref objNum2);
            num1 = (int)objNum1;
            num2 = (int)objNum2;      
            // SwapObjects(ref num1, ref num2); // Expected outcome: num1 = 30, num2 = 25  
            // SwapObjects(ref num3, ref num4); // Error: Value must be more than 18

            // SwapObjects(str1, str2); // Expected outcome: str1 = "Programming", str2 = "HelloWorld"
            // SwapObjects(str3, str4); // Error: Length must be more than 5

            // SwapObjects(true, false); // Error: Upsupported data type
            // SwapObjects(ref num1, str1); // Error: Objects must be of same types

            Console.WriteLine($"Numbers: {num1}, {num2}");
            Console.WriteLine($"Strings: {str1}, {str2}");

            // Challenge 3: Guessing Game
            Console.WriteLine("\nChallenge 3: Guessing Game");
            // Uncomment to test the GuessingGame method
             GuessingGame(); // Expected outcome: User input until the correct number is guessed or user inputs `Quit`

            // Challenge 4: Simple Word Reversal
            Console.WriteLine("\nChallenge 4: Simple Word Reversal");
            string sentence = "This is the original sentence!";
            string reversed = ReverseWords(sentence);
            Console.WriteLine(reversed); // Expected outcome: "sihT si eht lanigiro !ecnetnes"
        }
    } } 

