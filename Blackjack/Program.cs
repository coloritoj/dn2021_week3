using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {

        static List<string> AddDecksToShoe(int numOfDecks)
        {
            List<string> deckOfCards = new List<string>();
            for (int i = 0; i < numOfDecks; i++)
            {
                deckOfCards.Add("ACE OF SPADES");
                deckOfCards.Add("ACE OF HEARTS");
                deckOfCards.Add("ACE OF CLUBS");
                deckOfCards.Add("ACE OF DIAMONDS");
                deckOfCards.Add("2 OF SPADES");
                deckOfCards.Add("2 OF HEARTS");
                deckOfCards.Add("2 OF CLUBS");
                deckOfCards.Add("2 OF DIAMONDS");
                deckOfCards.Add("3 OF SPADES");
                deckOfCards.Add("3 OF HEARTS");
                deckOfCards.Add("3 OF CLUBS");
                deckOfCards.Add("3 OF DIAMONDS");
                deckOfCards.Add("4 OF SPADES");
                deckOfCards.Add("4 OF HEARTS");
                deckOfCards.Add("4 OF CLUBS");
                deckOfCards.Add("4 OF DIAMONDS");
                deckOfCards.Add("5 OF SPADES");
                deckOfCards.Add("5 OF HEARTS");
                deckOfCards.Add("5 OF CLUBS");
                deckOfCards.Add("5 OF DIAMONDS");
                deckOfCards.Add("6 OF SPADES");
                deckOfCards.Add("6 OF HEARTS");
                deckOfCards.Add("6 OF CLUBS");
                deckOfCards.Add("6 OF DIAMONDS");
                deckOfCards.Add("7 OF SPADES");
                deckOfCards.Add("7 OF HEARTS");
                deckOfCards.Add("7 OF CLUBS");
                deckOfCards.Add("7 OF DIAMONDS");
                deckOfCards.Add("8 OF SPADES");
                deckOfCards.Add("8 OF HEARTS");
                deckOfCards.Add("8 OF CLUBS");
                deckOfCards.Add("8 OF DIAMONDS");
                deckOfCards.Add("9 OF SPADES");
                deckOfCards.Add("9 OF HEARTS");
                deckOfCards.Add("9 OF CLUBS");
                deckOfCards.Add("9 OF DIAMONDS");
                deckOfCards.Add("10 OF SPADES");
                deckOfCards.Add("10 OF HEARTS");
                deckOfCards.Add("10 OF CLUBS");
                deckOfCards.Add("10 OF DIAMONDS");
                deckOfCards.Add("JACK OF SPADES");
                deckOfCards.Add("JACK OF HEARTS");
                deckOfCards.Add("JACK OF CLUBS");
                deckOfCards.Add("JACK OF DIAMONDS");
                deckOfCards.Add("QUEEN OF SPADES");
                deckOfCards.Add("QUEEN OF HEARTS");
                deckOfCards.Add("QUEEN OF CLUBS");
                deckOfCards.Add("QUEEN OF DIAMONDS");
                deckOfCards.Add("KING OF SPADES");
                deckOfCards.Add("KING OF HEARTS");
                deckOfCards.Add("KING OF CLUBS");
                deckOfCards.Add("KING OF DIAMONDS");
            }
            return deckOfCards;
        }

        static string DrawAndRemoveCard(List<string> shoe)
        {
            Random randomCard = new Random();
            int cardPosition = randomCard.Next(shoe.Count - 1);
            string playerCard = shoe[cardPosition];
            shoe.Remove(shoe[cardPosition]);
            return playerCard;
        }

        static int TranslateCard(string card)
        {
            int cardValue = 0;
            if (card == "ACE OF SPADES" || card == "ACE OF HEARTS" || card == "ACE OF CLUBS" || card == "ACE OF DIAMONDS")
            {
                cardValue = 1;
            }
            else if (card == "2 OF SPADES" || card == "2 OF HEARTS" || card == "2 OF CLUBS" || card == "2 OF DIAMONDS")
            {
                cardValue = 2;
            }
            else if (card == "3 OF SPADES" || card == "3 OF HEARTS" || card == "3 OF CLUBS" || card == "3 OF DIAMONDS")
            {
                cardValue = 3;
            }
            else if (card == "4 OF SPADES" || card == "4 OF HEARTS" || card == "4 OF CLUBS" || card == "4 OF DIAMONDS")
            {
                cardValue = 4;
            }
            else if (card == "5 OF SPADES" || card == "5 OF HEARTS" || card == "5 OF CLUBS" || card == "5 OF DIAMONDS")
            {
                cardValue = 5;
            }
            else if (card == "6 OF SPADES" || card == "6 OF HEARTS" || card == "6 OF CLUBS" || card == "6 OF DIAMONDS")
            {
                cardValue = 6;
            }
            else if (card == "7 OF SPADES" || card == "7 OF HEARTS" || card == "7 OF CLUBS" || card == "7 OF DIAMONDS")
            {
                cardValue = 7;
            }
            else if (card == "8 OF SPADES" || card == "8 OF HEARTS" || card == "8 OF CLUBS" || card == "8 OF DIAMONDS")
            {
                cardValue = 8;
            }
            else if (card == "9 OF SPADES" || card == "9 OF HEARTS" || card == "9 OF CLUBS" || card == "9 OF DIAMONDS")
            {
                cardValue = 9;
            }
            else if (card == "10 OF SPADES" || card == "10 OF HEARTS" || card == "10 OF CLUBS" || card == "10 OF DIAMONDS")
            {
                cardValue = 10;
            }
            else if (card == "JACK OF SPADES" || card == "JACK OF HEARTS" || card == "JACK OF CLUBS" || card == "JACK OF DIAMONDS")
            {
                cardValue = 10;
            }
            else if (card == "QUEEN OF SPADES" || card == "QUEEN OF HEARTS" || card == "QUEEN OF CLUBS" || card == "QUEEN OF DIAMONDS")
            {
                cardValue = 10;
            }
            else if (card == "KING OF SPADES" || card == "KING OF HEARTS" || card == "KING OF CLUBS" || card == "KING OF DIAMONDS")
            {
                cardValue = 10;
            }
            return cardValue;
        }

        static int DealerDrawProcess(string dealerDownCard, int dealerHandValue, List<string>shoe)
        {
            Console.WriteLine($"The dealer's down card is: {dealerDownCard}. The dealer's current hand value is {dealerHandValue}.");

            while (dealerHandValue < 16)
            {
                string dealerNextCard = DrawAndRemoveCard(shoe);
                int dealerValueNextCard = TranslateCard(dealerNextCard);
                dealerHandValue += dealerValueNextCard;
                Console.WriteLine($"The dealer drew a {dealerNextCard}. The dealer's current hand value is now {dealerHandValue}.");
            }
            return dealerHandValue;
        }

        static void Main(string[] args)
        {
            Console.Write("How many decks would you like to add to the shoe?: ");
            int numberOfDecks = int.Parse(Console.ReadLine());

            List<string> shoe = AddDecksToShoe(numberOfDecks);

            foreach (string card in shoe)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine($"You added {numberOfDecks} decks of cards to the shoe.");

            string playerCardOne = DrawAndRemoveCard(shoe);
            int playerCardOneValue = TranslateCard(playerCardOne);

            string dealerDownCard = DrawAndRemoveCard(shoe);
            int dealerCardOneValue = TranslateCard(dealerDownCard);

            string playerCardTwo = DrawAndRemoveCard(shoe);
            int playerCardTwoValue = TranslateCard(playerCardTwo);

            string dealerUpCard = DrawAndRemoveCard(shoe);
            int dealerCardTwoValue = TranslateCard(dealerUpCard);

            int playerHandValue = playerCardOneValue + playerCardTwoValue;
            int dealerHandValue = dealerCardOneValue + dealerCardTwoValue;

            Console.WriteLine($"\nYou drew a {playerCardOne} and a {playerCardTwo}. Your hand value is {playerHandValue}.");
            Console.WriteLine($"The dealer's upcard is {dealerUpCard}. The dealer's current hand value is {dealerCardTwoValue}.");

            Console.Write("What would you like to do? (STAND/HIT/DOUBLE DOWN): ");
            string playerAction = Console.ReadLine().ToLower();

            if (playerAction == "stand")
            {
                Console.WriteLine("You decided to STAND.");
                dealerHandValue = DealerDrawProcess(dealerDownCard, dealerHandValue, shoe);
                Console.WriteLine($"The dealer ended their hand with a value of {dealerHandValue}.");
                if (playerHandValue > dealerHandValue)
                {
                    Console.WriteLine("You WIN!");
                }
                else if (playerHandValue == dealerHandValue)
                {
                    Console.WriteLine("You PUSH!");
                }
                else if (playerHandValue < dealerHandValue)
                {
                    Console.WriteLine("You LOSE!");
                }
            }
            else if (playerAction == "hit")
            {
                do
                {
                    Console.WriteLine("You decided to HIT.");
                    string playerNextCard = DrawAndRemoveCard(shoe);
                    int valuePlayerNextCard = TranslateCard(playerNextCard);
                    playerHandValue += valuePlayerNextCard;
                    if (playerHandValue == 21)
                    {
                        Console.WriteLine($"You drew a {playerNextCard}. Your hand value is now {playerHandValue}. You automatically STAND.");
                        playerAction = "done";
                    }
                    else if (playerHandValue < 21)
                    {
                        Console.WriteLine($"You drew a {playerNextCard}. Your hand value is now {playerHandValue}.");
                        Console.Write($"What would you like to do? (STAND/HIT): ");
                        playerAction = Console.ReadLine().ToLower();
                    }
                    else if (playerHandValue > 21)
                    {
                        Console.WriteLine($"You drew a {playerNextCard}. Your hand value is now {playerHandValue}. You busted!");
                        playerAction = "done";
                    }
                } while (playerAction == "hit");

            }
            else if (playerAction == "double down")
            {
                Console.WriteLine("You decided to DOUBLE DOWN.");
            }

            Console.WriteLine("\nHere are the remaining cards in the shoe");
            foreach (string card in shoe)
            {
                Console.WriteLine(card);
            }
            
        }
    }
}
