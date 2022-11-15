using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessTheNumber
{
    public enum Status { Equal, Greater, Less };
    public class Guess
    {
        private int low;
        private int high;
        private Random random;
        private int number;
        //private int    playerNumber;
        private int steps;

        public Guess(int low, int high)
        {
            random = new Random();
            this.low = low;
            this.high = high;
        }

        public Guess() : this(1, 10) { }

        public int GetSteps()
        {
            return steps;
        }
        public int GetNumber() => number;
        public void GuessNumber()
        {
            number = random.Next(low, high + 1);
        }

        public Status PlayerGuess(int playerNumber)
        {
            steps++;

            if (number == playerNumber)
            {
                return Status.Equal;
            }
            else
            {
                if (number > playerNumber)
                {
                    return Status.Greater;
                }
                else
                {
                    return Status.Less;
                }
            }
        }
    }
}