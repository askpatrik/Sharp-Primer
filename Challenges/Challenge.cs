using System;
using System.Collections.Generic;

namespace Sharp_Primer.Challenges
{
    public class Challenge
    {
        public string Title { get; }
        public string Description { get; }
        public int Input1 {get;}
        public int Input2 {get;}
        public int ExpectedOutput { get; set; }

        public Challenge(string title, string description, int input1, int input2, int expectedOutput)
        {
            Title = title;
            Description = description;
            Input1 = input1;
            Input2 = input2;
            ExpectedOutput = expectedOutput;
        }

        public bool CheckAnswer(int answer)
        {
            return answer == ExpectedOutput;
        }

        public static Challenge GetRandomChallenge()
        {
            Random random = new Random();
            List<Challenge> challenges = new List<Challenge>()
    {
        new Challenge("Sum of two integers", "Write a program that takes two integer inputs and returns their sum", 5, 10, 15)
    
        // Add more challenges here
    };
            int index = random.Next(challenges.Count);
            return challenges[index];
        }
    }
}