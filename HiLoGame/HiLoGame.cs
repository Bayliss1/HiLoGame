using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLoGame
{
    static class HiLoGame
    {
        private static Random random = new Random();
        public const int MAXIMUM = 10;
        public static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        public static int GetPot()
        {
            return pot;
        }

        public static void Guess(bool higher)
        {
            int newNumber = random.Next(1, MAXIMUM + 1);
            if ((higher && newNumber >= currentNumber) || (!higher && newNumber <= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong.");
                pot--;
            }
            currentNumber = newNumber;
            Console.WriteLine($"The current number is {currentNumber}.");
        }

        public static void Hint()
        {
            int halfMAXIMUM = MAXIMUM / 2;
            if (currentNumber >= halfMAXIMUM)
            {
                Console.WriteLine($"The number is at least {halfMAXIMUM}.");
            }
            else
            {
                Console.WriteLine($"The number is at most {halfMAXIMUM}.");
            }
            pot--;
        }
    }
}

