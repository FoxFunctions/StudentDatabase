using System;
using System.Linq;

namespace StudentDatabaseLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string[] studentName = { "Aaron", "Clyde", "Kelly", "Meryl", "Simon", "Rose", "Jack", "David", "Popeye" };
                string[] homeTown = { "Los Angeles, California", "Juneao, Alaska", "Duluth, Minnesota", "Akron, Ohio", "Talladega, Alabama", "Marfa, Texas", "Tombstone, Arizona", "Toronto, Ontario", "Victoria, Texas" };
                string[] favoriteFood = { "pizza", "cornbread", "plain white rice", "lasanga", "anything from Jimmy Johns", "salmon", "fish sticks", "ramen noodle soup", "canned spinach" };
                int navChoice;

                while (true)
                { 
                    Console.WriteLine("Welcome to the Student Database. Would you like to begin by viewing a directory of all students or proceed to learning about our students? To view the directory, please type directory. To learn about students, please type database.");
                    string directoryOrDatabase = Console.ReadLine().ToLower().Trim();
                    Console.WriteLine();

                    if (directoryOrDatabase.Contains("dir"))
                    {
                        Console.WriteLine("All Students in our database:");

                        for (int i = 0; i < studentName.Length; i++)
                        {
                            Console.WriteLine($"Student {i+1}: {studentName[i]}");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Which student would you like to learn more about? Enter a number 1-9.");
                        int studentChoice = int.Parse(Console.ReadLine());

                        if (studentChoice <= 0 || studentChoice > studentName.Length + 1)
                        {
                            Console.WriteLine("Sorry, that is not a valid input. Please choose a number 1-9.");
                            Console.WriteLine();
                            continue;
                        }
                        else
                        {
                            navChoice = studentChoice - 1;
                            break;
                        }

                    }
                    else if (directoryOrDatabase.Contains("data"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Which student would you like to learn more about? Enter a number 1-9.");
                        int studentChoice = int.Parse(Console.ReadLine());

                        if (studentChoice <= 0 || studentChoice > studentName.Length + 1)
                        {
                            Console.WriteLine("Sorry, that is not a valid input. Please choose a number 1-9.");
                            continue;
                        }
                        else
                        {
                            navChoice = studentChoice - 1;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is not a valid input. Please enter directory or database");
                        continue;
                    }
                }

                while (true)
                {

                    Console.WriteLine($"You have chosen {studentName[navChoice]}. What would you like to know? Please enter hometown or favorite food. ");
                    string navigationChoice = Console.ReadLine().ToLower().Trim();

                    if (navigationChoice.Contains("town"))
                    {
                        Console.WriteLine($"{studentName[navChoice]} was born in {homeTown[navChoice]}.");
                        Console.WriteLine();
                        break;
                    }
                    else if (navigationChoice.Contains("food"))
                    {
                        Console.WriteLine($"{studentName[navChoice]}'s favorite food is {favoriteFood[navChoice]}.");
                        Console.WriteLine();
                        break;
                    }
                    
                    else
                    {
                        Console.WriteLine("Sorry, I didn't quite get that. Please choose hometown or favorite food.");
                        Console.WriteLine();
                        continue;
                    }
                }

                Console.WriteLine("Would you like to run the program again? Please enter y/n");
                string userContinue = Console.ReadLine().ToLower();

                if (userContinue == "y")
                {
                    continue;
                }
                else if (userContinue == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't quite get that. Please choose y/n");
                }
            }
        }
    }
}



/* STUDENT DATABASE
Objectives: Storing Data in Arrays, Searching Data

Task: Write a program that will recognize invalid inputs when the user requests information about students in a class.

What will the application do?
2 Points: Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food
1 Point: Prompt the user to ask about a particular student by number. Convert the input to an integer. Use the integer as the index for the arrays. Print the student’s name.
1 Point: Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
1 Point: Ask the user if they would like to learn about another student.

Build Specifications:
1 Point: Validate user number: Use an if statement to check if the number is out of range, i.e. either less than 0 or greater than the maximum index of the arrays. If so, display a friendly message and let the user try again.
1 Point: Validate category: Ask the user what information category to display: "Hometown" or "Favorite Food". Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question.
1 Point: Array Length: Use the first array’s Length property in your code instead of hardcoding it.

Hints:
Make sure the arrays are the same size.
Let the user enter a number from 1 up to and including the length of the array. To get the index, subtract 1 from the number they entered.
Make it easy for the user – tell them what information is available
Try to use good grammar. Make your messages polite.

Extra Challenges:
1 Point: Provide an option where the user can see a list of all students.
2 Points: Allow the user to search by student name
1 Point: Category names: Allow uppercase and lowercase; allow portion of word such as "Food" instead of "Favorite Food" */