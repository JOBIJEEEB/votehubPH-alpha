// Hernandez - BSCPE/BSCOE 1-1 - OOP
// VoteHub PH Alpha ver. 2
using System;

namespace VoteHubPH
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctAns = "333";

            int[] votedFoods = new int[3];
            int[] votedFruits = new int[3];
            int[] votedGames = new int[3];

            string userInput = IntroMenu();

            while (userInput != "0")
            {
                string result = userInput == correctAns ? "correct" : "error";

                if (result == "correct")
                {
                    string userChoice = MainMenu();
                    switch (userChoice)
                    {
                        case "1":
                            VoteFood(votedFoods);
                            break;

                        case "2":
                            VoteFruit(votedFruits);
                            break;

                        case "3":
                            VoteGame(votedGames);
                            break;

                        case "4":
                            CheckCastedVotes(votedFoods, votedFruits, votedGames);
                            break;

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
                    userInput = Console.ReadLine();
                }
            }
        }
        public static string IntroMenu()
        {
            Console.WriteLine("Welcome to VoteHub PH");
            Console.WriteLine("---------------------");
            Console.WriteLine("In order to participate in our voting system, please verify");
            Console.WriteLine("your pagka-Pinoy by answering the following question. Thank you.");
            Console.WriteLine("");
            Console.Write("Please enter your name/nickname: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}!, thanks for participating in VoteHub PH! Here's your verification question.");
            Console.WriteLine("");
            Console.WriteLine("Ilang taon tayo sinakop ng mga Espanyol?");
            Console.Write("Type only the number of years (ex: 222): ");
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static string MainMenu()
        {
            Console.WriteLine("Please select the number of the topic you want to vote for (1-3)");
            Console.WriteLine("Enter 4 to display casted votes.");
            Console.WriteLine("Enter 0 to exit the menu.");
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
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();
            return input;
        }
        public static void VoteFood(int[] votedFoods)
        {
            string foodInput = FoodMenu();
            switch (foodInput)
            {
                case "1":
                    Console.WriteLine("NICE! YOU VOTED FOR SINIGANG!");
                    votedFoods[0]++;
                    break;
                case "2":
                    Console.WriteLine("NICE! YOU VOTED FOR ADOBO!");
                    votedFoods[1]++;
                    break;
                case "3":
                    Console.WriteLine("NICE! YOU VOTED FOR TINOLA!");
                    votedFoods[2]++;
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }
        public static void VoteFruit(int[] votedFruits)
        {
            string fruitInput = FruitMenu();
            switch (fruitInput)
            {
                case "1":
                    Console.WriteLine("NICE! YOU VOTED FOR PAKWAN!");
                    votedFruits[0]++;
                    break;
                case "2":
                    Console.WriteLine("NICE! YOU VOTED FOR MANGGA!");
                    votedFruits[1]++;
                    break;
                case "3":
                    Console.WriteLine("NICE! YOU VOTED FOR SAGING!");
                    votedFruits[2]++;
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }
        public static void VoteGame(int[] votedGames)
        {
            string gameInput = GameMenu();
            switch (gameInput)
            {
                case "1":
                    Console.WriteLine("NICE! YOU VOTED FOR PATINTERO!");
                    votedGames[0]++;
                    break;
                case "2":
                    Console.WriteLine("NICE! YOU VOTED FOR TUMBANG PRESO!");
                    votedGames[1]++;
                    break;
                case "3":
                    Console.WriteLine("NICE! YOU VOTED FOR JACKSTONES!");
                    votedGames[2]++;
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }
        public static void CheckCastedVotes(int[] votedFoods, int[] votedFruits, int[] votedGames)
        {
            Console.WriteLine("");
            Console.WriteLine("|=========================================|");
            Console.WriteLine("|          |>>  CASTED VOTES <<|          |");
            Console.WriteLine("|=========================================|");
            Console.WriteLine($"1. FAVORITE FOOD/ DISH                 ");
            Console.WriteLine($"   Sinigang: {votedFoods[0]} votes     ");
            Console.WriteLine($"   Adobo: {votedFoods[1]} votes        ");
            Console.WriteLine($"   Tinola: {votedFoods[2]} votes       ");
            Console.WriteLine("|=========================================|");
            Console.WriteLine($"2. FAVORITE FRUIT                      ");
            Console.WriteLine($"   Pakwan: {votedFruits[0]} votes      ");
            Console.WriteLine($"   Mangga: {votedFruits[1]} votes      ");
            Console.WriteLine($"   Saging: {votedFruits[2]} votes      ");
            Console.WriteLine("|=========================================|");
            Console.WriteLine($"3. FAVORITE PINOY GAME                 ");
            Console.WriteLine($"   Patintero: {votedGames[0]} votes    ");
            Console.WriteLine($"   Tumbang Preso: {votedGames[1]} votes");
            Console.WriteLine($"   Jackstones: {votedGames[2]} votes   ");
            Console.WriteLine("|=========================================|");
        }
        public static string FoodMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("|==============================|");
            Console.WriteLine("|  |>> FAVORITE FOOD/DISH <<|  |");
            Console.WriteLine("|==============================|");
            Console.WriteLine("|      1 >> Sinigang           |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|       2 >> Adobo             |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|      3 >> Tinola             |");
            Console.WriteLine("|==============================|");
            Console.WriteLine("");
            Console.Write("Please select the number of your favorite food/dish (1-3): ");
            string foodInput = Console.ReadLine();
            return foodInput;
        }
        public static string FruitMenu()
        {
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
            return fruitInput;
        }
        public static string GameMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("|==============================|");
            Console.WriteLine("|  >> FAVORITE PINOY GAME <<|  |");
            Console.WriteLine("|==============================|");
            Console.WriteLine("|      1 >> Patintero          |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    2 >> Tumbang Preso        |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|      3 >> Jackstones         |");
            Console.WriteLine("|==============================|");
            Console.WriteLine("");
            Console.Write("Please select the number of your favorite game (1-3): ");
            string gameInput = Console.ReadLine();
            return gameInput;
        }
    }
}