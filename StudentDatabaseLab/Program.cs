using System;

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
