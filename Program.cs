using System;
using System.Collections.Generic;

namespace Top_Trumps
{

    public class TopTrumpsMainDeckStats
        {
            public string name;
            public int health;
            public int strength;
            public int cunning;
            public int intelligence;
            public int magical;
            public int corruption; 

    class Program
    {
            static void Main(string[] args)
            {
                // Player One Deck
                 List <TopTrumpsMainDeckStats> PlayerOneCards = new List <TopTrumpsMainDeckStats>();
                 PlayerOneCards.Add(new TopTrumpsMainDeckStats {name = "Bigby Wolf", health = 9, strength = 1, cunning = 2, intelligence = 3, magical = 4, corruption = 5});
                 PlayerOneCards.Add(new TopTrumpsMainDeckStats {name = "Snow White", health = 8, strength = 7, cunning = 6, intelligence = 5, magical = 4, corruption = 2});
                 PlayerOneCards.Add(new TopTrumpsMainDeckStats {name = "Jack Pumpkinhead", health = 6, strength = 9, cunning = 2, intelligence = 4, magical = 3, corruption = 6});
                 PlayerOneCards.Add(new TopTrumpsMainDeckStats {name = "Belle Beauty", health = 7, strength = 5, cunning = 7, intelligence = 2, magical = 8, corruption = 5});
                 PlayerOneCards.Add(new TopTrumpsMainDeckStats {name = "Cinderella", health = 3, strength = 4, cunning = 7, intelligence = 2, magical = 4, corruption = 7});
                 PlayerOneCards.Add(new TopTrumpsMainDeckStats {name = "Prince Charming", health = 6, strength = 4, cunning = 9, intelligence = 1, magical = 6, corruption = 7});
                 PlayerOneCards.Add(new TopTrumpsMainDeckStats {name = "Captain Hook", health = 4, strength = 7, cunning = 2, intelligence = 3, magical = 8, corruption = 5});
                 PlayerOneCards.Add(new TopTrumpsMainDeckStats {name = "Wicked Witch", health = 5, strength = 9, cunning = 2, intelligence = 5, magical = 7, corruption = 5});
                 PlayerOneCards.Add(new TopTrumpsMainDeckStats {name = "Evil Queen", health = 8, strength = 8, cunning = 2, intelligence = 1, magical = 5, corruption = 3});
                 PlayerOneCards.Add(new TopTrumpsMainDeckStats {name = "Rumplestiltskin", health = 10, strength = 3, cunning = 6, intelligence = 8, magical = 1, corruption = 4});

                // Player Two Deck
                List <TopTrumpsMainDeckStats>  PlayerTwoCards = new List <TopTrumpsMainDeckStats>();
                PlayerTwoCards.Add(new TopTrumpsMainDeckStats {name = "Robin Hood", health = 6, strength = 5, cunning = 7, intelligence = 1, magical = 9, corruption = 3});
                PlayerTwoCards.Add(new TopTrumpsMainDeckStats {name = "Tinker Bell", health = 4, strength = 3, cunning = 7, intelligence = 1, magical = 8, corruption = 8});
                PlayerTwoCards.Add(new TopTrumpsMainDeckStats {name = "Jekyll And Hyde", health = 8, strength = 3, cunning = 6, intelligence = 1, magical = 9, corruption = 4});
                PlayerTwoCards.Add(new TopTrumpsMainDeckStats {name = "Maid Marian", health = 5, strength = 6, cunning = 7, intelligence = 8, magical = 9, corruption = 10});
                PlayerTwoCards.Add(new TopTrumpsMainDeckStats {name = "Mulan", health = 8, strength = 7, cunning = 6, intelligence = 9, magical = 3, corruption = 5});
                PlayerTwoCards.Add(new TopTrumpsMainDeckStats {name = "Prince Eric", health = 3, strength = 5, cunning = 7, intelligence = 1, magical = 4, corruption = 6});
                PlayerTwoCards.Add(new TopTrumpsMainDeckStats {name = "Victor Frankenstein", health = 4, strength = 3, cunning = 8, intelligence = 5, magical = 7, corruption = 8});
                PlayerTwoCards.Add(new TopTrumpsMainDeckStats {name = "Peter Pan", health = 7, strength = 4, cunning = 6, intelligence = 12, magical = 7, corruption = 4});
                PlayerTwoCards.Add(new TopTrumpsMainDeckStats {name = "Mother Gothel", health = 6, strength = 9, cunning = 7, intelligence = 6, magical = 2, corruption = 7});
                PlayerTwoCards.Add(new TopTrumpsMainDeckStats {name = "Queen Elsa", health = 8, strength = 6, cunning = 1, intelligence = 4, magical = 7, corruption = 2});
           
                // PlayerOne wins card
                if( PlayerOneCards[0].health > PlayerTwoCards[0].health)
                {
                    PlayerOneCards.Add(PlayerTwoCards[0]);
                    PlayerTwoCards.RemoveAt(0);
                    System.Console.WriteLine("Player One has {0} cards",PlayerOneCards.Count);
                    System.Console.WriteLine("Player Two has {0} cards",PlayerTwoCards.Count);
                }

                // PlayerTwo wins card
                if(PlayerTwoCards[0].health > PlayerOneCards[0].health)
                {
                    PlayerTwoCards.Add(PlayerOneCards[0]);
                    PlayerOneCards.RemoveAt(0);
                    System.Console.WriteLine("Player One has {0} cards",PlayerOneCards.Count);
                    System.Console.WriteLine("Player Two has {0} cards",PlayerTwoCards.Count);
                }
            }
        }
    }
}

                // CardDeck.StatCategories CardCharacterDetails = new CardDeck.StatCategories();
                // // TopTrumpsMainDeckStats topTrumpsMainDeckStats = new TopTrumpsMainDeckStats();
                // string name01 = "Daniel";
                // Console.WriteLine(name01);

                // string[] names = new string[4];
                // names[0] = "Daniel";
                //  Console.WriteLine(names[0]);