/* 
Hernandez
BSCPE/BSCOE 1-1
OOP
Voting_System
VoteHub PH Alpha Patch 2.2
*/
using System;
using VoteHub_PH;

namespace VoteHubPH
{
    class Program
    {
        static void Main(string[] args)
        {
            bool verification = IntroMenu();
            Console.Clear();

            while (verification == true)
            {
                string userChoice = MainMenu();
                Console.Clear();
                switch (userChoice)
                {
                    case "1":
                        string foodInput = FavFoodMenu();
                        FoodCategory.CastVote(foodInput);
                        break;

                    case "2":
                        string fruitInput = FavFruitMenu();
                        FruitCategory.CastVote(fruitInput);
                        break;

                    case "3":
                        string gameInput = FavGameMenu();
                        GameCategory.CastVote(gameInput);
                        break;

                    case "4":
                        DisplayResultsMenu();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }
        }
        public static bool IntroMenu()
        {
            Voter voter = new Voter();
            bool verification = false;

            Console.WriteLine("Welcome to VoteHub PH");
            while (verification == false)
            {
                Console.Write("Please enter your Username: ");
                string username = Console.ReadLine();
                Console.Write("Please enter your Password: ");
                string password = Console.ReadLine();
                verification = voter.VerifyVoterProfile(username, password);
                if (verification == false) 
                {
                    Console.WriteLine("Invalid Username and Password" + "\n" + "Please try again" + "\n");
                }
            }
            return verification;

        }
        public static string MainMenu()
        {
            Console.WriteLine("VOTEHUB PH MENU");
            Console.WriteLine("1 >> Favorite Food/Dish");
            Console.WriteLine("2 >> Favorite Fruit");
            Console.WriteLine("3 >> Favorite Pinoy Game");
            Console.WriteLine("4 >> Display Results");
            Console.WriteLine("0 >> Exit Menu" + "\n");
            Console.WriteLine("Please select the number of the topic you want to vote for (1-3)");
            Console.WriteLine("Enter 4 to display results.");
            Console.WriteLine("Enter 0 to exit the menu.");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }
        public static string FavFoodMenu()
        {
            Console.WriteLine("FAVORITE FOOD/DISH");
            Console.WriteLine("1 >> Sinigang");
            Console.WriteLine("2 >> Adobo");
            Console.WriteLine("3 >> Tinola");
            Console.Write("Please select the number of your favorite food/dish (1-3): ");
            string userInput = Console.ReadLine();
            Console.Clear();
            return userInput;
        }
        public static string FavFruitMenu()
        {
            Console.WriteLine("FAVORITE FRUIT");
            Console.WriteLine("1 >> Pakwan");
            Console.WriteLine("2 >> Mangga");
            Console.WriteLine("3 >> Saging");
            Console.Write("Please select the number of your favorite food/dish (1-3): ");
            string userInput = Console.ReadLine();
            Console.Clear();
            return userInput;
        }
        public static string FavGameMenu()
        {
            Console.WriteLine("FAVORITE PINOY GAME");
            Console.WriteLine("1 >> Patintero");
            Console.WriteLine("2 >> Tumbang Preso");
            Console.WriteLine("3 >> Jackstones");
            Console.Write("Please select the number of your favorite food/dish (1-3): ");
            string userInput = Console.ReadLine();
            Console.Clear();
            return userInput;
        }
        public static void DisplayResultsMenu()
        {

            Console.WriteLine("RESULTS");
            Console.WriteLine("Favorite Food/Dish:");
            Console.WriteLine("1. Sinigang: " + GetPercentage(FoodCategory.favFoods[0]) + "%");
            Console.WriteLine("2. Adobo: " + GetPercentage(FoodCategory.favFoods[1]) + "%");
            Console.WriteLine("3. Tinola: " + GetPercentage(FoodCategory.favFoods[2]) + "%");

            Console.WriteLine("Favorite Fruit:");
            Console.WriteLine("1. Pakwan: " + GetPercentage(FruitCategory.favFruit[0]) + "%");
            Console.WriteLine("2. Mangga: " + GetPercentage(FruitCategory.favFruit[1]) + "%");
            Console.WriteLine("3. Saging: " + GetPercentage(FruitCategory.favFruit[2]) + "%");

            Console.WriteLine("Favorite Pinoy Game:");
            Console.WriteLine("1. Patintero: " + GetPercentage(GameCategory.favGame[0]) + "%");
            Console.WriteLine("2. Tumbang Preso: " + GetPercentage(GameCategory.favGame[1]) + "%");
            Console.WriteLine("3. Jackstones: " + GetPercentage(GameCategory.favGame[2]) + "%");
            Console.Write("Press ENTER to return to the MAIN MENU:");
            Console.ReadLine();
            Console.Clear();
            return;
        }
        private static double GetPercentage(int votes)
        {
            return (votes / 20.0) * 100.0;
        }
    }
}