// Hernandez - BSCPE/BSCOE 1-1
// VoteHub PH Alpha ver.
// Methods and arrays are not used, resulting in long lines of code.
using System;

namespace VoteHubPH
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctAns = "333"; // declaration and assignment of the correctAns variable/verification code

            //introduction
            Console.WriteLine("Welcome to VoteHub PH");
            Console.WriteLine("---------------------");
            Console.WriteLine("In order to participate in our voting system, please verify");
            Console.WriteLine("your pagka-Pinoy by answering the following question. Thank you.");
            Console.WriteLine("");
            // pinoy verification
            Console.Write("Please enter your name/nickname: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hi {userName}!, thanks for participating in VoteHub PH! Here's your verification question.");
            Console.WriteLine("");
            Console.WriteLine("Ilang taon tayo sinakop ng mga Espanyol?");
            Console.Write("Type only the number of years (ex: 222): ");
            string userAnswer = Console.ReadLine();

            string favFood = "";
            string favFruit = "";
            string favGame = "";

            // if user's input is correct, the program will run the main menu
            while (userAnswer != "0")
            {
                string result = userAnswer == correctAns ? "correct" : "error";

                if (result == "correct")
                {
                    // MAIN MENU
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("|=============================|");
                    Console.WriteLine("|   |>> VOTEHUB PH MENU <<|   |");
                    Console.WriteLine("|=============================|");
                    Console.WriteLine("| 1 >> Favorite Food/Dish     |");
                    Console.WriteLine("|-----------------------------|");
                    Console.WriteLine("| 2 >> Favorite Fruit         |");
                    Console.WriteLine("|-----------------------------|");
                    Console.WriteLine("| 3 >> Favorite Pinoy Game    |");
                    Console.WriteLine("|-----------------------------|");
                    Console.WriteLine("| 4 >> Check Casted Votes     |");
                    Console.WriteLine("|-----------------------------|");
                    Console.WriteLine("| 0 >> Exit Menu              |");
                    Console.WriteLine("|=============================|");
                    Console.WriteLine("|  (O_O)(^-^)(^o^)(^>^)(-_-)  |");
                    Console.WriteLine("|=============================|");
                    Console.WriteLine("");
                    Console.WriteLine("Please select the number of the topic you want to vote for (1-4)");
                    Console.WriteLine("Enter 0 to exit the menu.");
                    Console.Write("Enter your choice: ");
                    string userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        // FAVORITE FOOD/DISH SUB-MENU
                        case "1":
                            Console.WriteLine("");
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("|  |>> FAVORITE FOOD/DISH <<|  |");
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("|      1 >> Sinigang           |");
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|      2 >> Adobo              |");
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|      3 >> Tinola             |");
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("");
                            Console.Write("Please select the number of your favorite food/dish (1-3): ");
                            string foodInput = Console.ReadLine();
                            switch (foodInput) // switch-case statements for the interpretation of user's numerical input
                            {
                                case "1":
                                    Console.WriteLine("NICE! YOU VOTED FOR SINIGANG!");
                                    favFood = "Sinigang";
                                    break;

                                case "2":
                                    Console.WriteLine("NICE! YOU VOTED FOR ADOBO!");
                                    favFood = "Adobo";
                                    break;

                                case "3":
                                    Console.WriteLine("NICE! YOU VOTED FOR TINOLA!");
                                    favFood = "Tinola";
                                    break;
                            }
                            break;

                        // FAVORITE FRUIT SUB-MENU
                        case "2":
                            Console.WriteLine("");
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("|    |>> FAVORITE FRUIT <<|    |");
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("|      1 >> Pakwan             |");
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|      2 >> Mangga             |");
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|      3 >> Saging             |");
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("");
                            Console.Write("Please select the number of your favorite fruit (1-3): ");
                            string fruitInput = Console.ReadLine();
                            switch (fruitInput) // switch-case statements for the interpretation of user's numerical input
                            {
                                case "1":
                                    Console.WriteLine("NICE! YOU VOTED FOR PAKWAN!");
                                    favFruit = "Pakwan";
                                    break;

                                case "2":
                                    Console.WriteLine("NICE! YOU VOTED FOR MANGGA!");
                                    favFruit = "Mangga";
                                    break;

                                case "3":
                                    Console.WriteLine("NICE! YOU VOTED FOR SAGING!");
                                    favFruit = "Saging";
                                    break;
                            }
                            break;
                        // FAVORITE PINOY GAME SUB-MENU
                        case "3":
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("|  >> FAVORITE PINOY GAME <<|  |");
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("|      1 >> Patintero          |");
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|      2 >> Tumbang Preso      |");
                            Console.WriteLine("|------------------------------|");
                            Console.WriteLine("|      3 >> Jackstones         |");
                            Console.WriteLine("|==============================|");
                            Console.WriteLine("");
                            Console.Write("Please select the number of your favorite game (1-3): ");
                            string gameInput = Console.ReadLine();
                            switch (gameInput) // switch-case statements for the interpretation of user's numerical input
                            {
                                case "1":
                                    Console.WriteLine("NICE! YOU VOTED FOR PATINTERO!");
                                    favGame = "Patintero";
                                    break;

                                case "2":
                                    Console.WriteLine("NICE! YOU VOTED FOR TUMBANG PRESO!");
                                    favGame = "Tumbang Preso";
                                    break;

                                case "3":
                                    Console.WriteLine("NICE! YOU VOTED FOR JACKSTONES!");
                                    favGame = "Jackstones";
                                    break;
                            }
                            break;

                        // CHECKING CASTED VOTES SUB-MENU
                        case "4":
                            Console.WriteLine("|========================================|");
                            Console.WriteLine("|        >> YOUR CASTED VOTES <<|        |");
                            Console.WriteLine("|========================================|");
                            Console.WriteLine($"1. FAVORITE FOOD/ DISH: {favFood}");
                            Console.WriteLine($"2. FAVORITE FRUIT: {favFruit}");
                            Console.WriteLine($"3. FAVORITE PINOY GAME: {favGame}");
                            break;

                        // EXIT MENU
                        case "0":
                            return;

                        default:
                            Console.WriteLine("Invalid Input!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong answer!");
                    Console.WriteLine("Please try again or press 0 to exit");
                    Console.WriteLine("Ilang taon tayo sinakop ng mga Espanyol?");
                    Console.Write("Type only the number of years (ex: 222): ");
                    userAnswer = Console.ReadLine();
                }
            }
        }
    }
}