using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteHub_PH
{
    internal class FoodCategory
    {
        public static int[] favFoods = new int[3];
        public static void CastVote(string userInput) 
        {   
            FoodCategory foodCategory = new FoodCategory();
            switch (userInput) 
            {
                case "1":
                    favFoods[0]++;
                    break;
                case "2":
                    favFoods[1]++;
                    break;
                case "3":
                    favFoods[2]++;
                    break;
                default:
                    break;
            }
        }
    }
    internal class FruitCategory
    {
        public static int[] favFruit = new int[3];
        public static void CastVote(string userInput)
        {
            FruitCategory fruitCategory = new FruitCategory();
            switch (userInput)
            {
                case "1":
                    favFruit[0]++;
                    break;
                case "2":
                    favFruit[0]++;
                    break;
                case "3":
                    favFruit[2]++;
                    break;
                default:
                    break;
            }
        }
    }
    internal class GameCategory
    {
        public static int[] favGame = new int[3];
        public static void CastVote(string userInput)
        {
            GameCategory gameCategory = new GameCategory();
            switch (userInput)
            {
                case "1":
                    favGame[0]++;
                    break;
                case "2":
                    favGame[1]++;
                    break;
                case "3":
                    favGame[2]++;
                    break;
                default:
                    break;
            }
        }
    }
}
