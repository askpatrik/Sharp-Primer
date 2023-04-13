using System;
using System.Collections.Generic;

namespace Sharp_Primer.Challenges
{
    public class Challenge
    {
        public string Title { get; }
        public string Description { get; }

        public Challenge(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public static Challenge GetRandomChallenge()
        {
            Random random = new Random();
            List<Challenge> challenges = new List<Challenge>()
    {
        new Challenge("Challenge 1", "Write a program that outputs the numbers from 1 to 100. But for multiples of three, output “Fizz” instead of the number and for the multiples of five, output “Buzz”. For numbers which are multiples of both three and five, output “FizzBuzz”."),
        new Challenge("Challenge 2", "Write a program that takes a string input from the user and outputs the string reversed."),
        new Challenge("Challenge 3", "Write a program that takes an integer input from the user and outputs whether the number is even or odd."),
        new Challenge("Challenge 4", "Write a program that takes two integer inputs from the user and outputs their sum, difference, product, and quotient."),
        new Challenge("Challenge 5", "Write a program that takes an integer input from the user and outputs the factorial of that number.")
        // Add more challenges here
    };
            int index = random.Next(challenges.Count);
            return challenges[index];
        }
    }
}