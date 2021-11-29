using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static string ReverseWord(string word)
        {
            List<char> lettersInWord = new List<char>();
            string reverseWord = "";

            foreach (char letter in word)
            {
                lettersInWord.Add(letter);
            }

            for (int i = (lettersInWord.Count -1); i >= 0; i--)
            {
                reverseWord += lettersInWord[i];
            }

            return reverseWord;
        }

        static string ReverseWordUsingStack(string word)
        {
            Stack<char> lettersInWord = new Stack<char>();
            string reverseWord = "";

            foreach (char letter in word)
            {
                lettersInWord.Push(letter);
            }

            for (int i = (lettersInWord.Count -1); i >=0; i--)
            {
                reverseWord += lettersInWord.Pop();
            }

            return reverseWord;
        }

        static string ReverseSentence(string sentence)
        {
            List<string> wordsInSentenceList = new List<string>();
            string[] wordsInSentenceArray = sentence.Split(' ');
            string reversedSentence = "";

            foreach (string word in wordsInSentenceArray)
            {
                wordsInSentenceList.Add(ReverseWord(word));
            }

            for (int i = 0; i < wordsInSentenceList.Count; i++)
            {
                reversedSentence += wordsInSentenceList[i] + " ";
            }

            return reversedSentence;

        }

        static bool ContainsInvalidCharacter(string word)
        {
            if (word.Contains('1') || word.Contains('2') || word.Contains('3') || word.Contains('4') || word.Contains('5') || word.Contains('6') || word.Contains('7') || word.Contains('8') || word.Contains('9') || word.Contains ('0'))
            {
                return true;
            }
            else if (word.Contains('.') || word.Contains(',') || word.Contains('!') || word.Contains('@') || word.Contains('#') || word.Contains('$') || word.Contains('%') || word.Contains('^') || word.Contains('&') || word.Contains('*'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            // MAIN BUILD
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine();

            while (ContainsInvalidCharacter(word))
            {
                Console.Write("You did not enter a valid word. Please enter a word without numbers or special characters: ");
                word = Console.ReadLine();
            }

            Console.WriteLine("\n===== WORD IN REVERSE USING A LIST =====");
            string wordInReverse = ReverseWord(word);
            Console.WriteLine(wordInReverse);

            Console.WriteLine("\n===== WORD IN REVERSE USING A STACK =====");
            wordInReverse = ReverseWordUsingStack(word);
            Console.WriteLine(wordInReverse);

            // EXTRA CHALLENGES
            Console.WriteLine("\n===== SENTENCE IN REVERSE USING A LIST =====");
            Console.Write("\nPlease enter a sentence: ");
            string sentence = Console.ReadLine();
            string reversedSentence = ReverseSentence(sentence);
            Console.WriteLine(reversedSentence);
        }
    }
}

/*----- WHAT WILL THE APPLICATION DO? -----
 * Take in a user input and display said input in reverse.
 * 
 * ----- BUILD SPECIFICATIONS -----
 * 1 POINT: Request and take user input --- COMPLETE
 * 3 PONTS: Create a separate method for reversing your strings --- COMPLETE
 * ... Return type should be a string --- COMPLETE
 * ... Parameter should be a string --- COMPLETE
 * 5 POINTS: Inside your string reverse method, figure out how to reverse the inputted string using a Stack --- COMPLETE
 * ... 1 POINT: Instantiating the stack --- COMPLETE
 * ... 2 POINTS: Using the stack to store characters --- COMPLETE
 * ... 2 POINTS: Using thes tack to retriever characters in reverse order --- COMPLETE
 * 1 POINT: Display the reversed string in the console (1 point) --- COMPLETE
 * 
 * ----- HINTS -----
 * This problem can be solved without using a stack.
 * ... If you find it easier without using a stack, try solving it without a stack first.
 * ... After solving the problem with out a stack, re-iterate over your solution and use a stack instead.
 * 
 * ----- EXTRA CHALLENGES -----
 * Consider cases where the user does not enter a single word but a sentence instead. --- COMPLETE
 * ... Do not reverse the entire sentence, instead reverse each word in the sentence, keeping the words in their original positions. --- COMPLETE
 * Validate user input: make sure the user is only entering words and not symbols or numbers.
 */
