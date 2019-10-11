using Laboratorio_6_OOP_201902.Cards;
using Laboratorio_6_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_6_OOP_201902.Static
{
    public static class Visualization
    {
        public static void ShowBoard(Board board, int player,int[] lifePoints,int[] attackPoints)
        {
            Console.WriteLine("Board:");
            int[] values;
            if (player == 1)
            {
                Console.WriteLine($"Oponente  -  LifePoints {lifePoints[0]}   -  AttackPoints{attackPoints[0]}");
                List<Card> cards = board.PlayerCards[0][EnumType.longRange];
                string h = "";
                foreach (Card i in cards)
                {
                    CombatCard j = (CombatCard)i;
                    h += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(longRange) [" + board.GetAttackPoints(EnumType.longRange)+ "]", h);
                List<Card> car = board.PlayerCards[0][EnumType.range];
                string ran = "";
                foreach (Card i in car)
                {
                    CombatCard j = (CombatCard)i;
                    ran += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(Range) [" + board.GetAttackPoints(EnumType.range) + "]" , ran);
                List<Card> cardss = board.PlayerCards[0][EnumType.melee];
                string me = "";
                foreach (Card i in cardss)
                {
                    CombatCard j = (CombatCard)i;
                    me += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(melee) [" + board.GetAttackPoints(EnumType.melee) + "]", me);

                Console.WriteLine($"You  -  LifePoints {lifePoints[1]}   -  AttackPoints{attackPoints[1]}");
                List<Card> cards0 = board.PlayerCards[1][EnumType.longRange];
                string h0 = "";
                foreach (Card i in cards0)
                {
                    CombatCard j = (CombatCard)i;
                    h0 += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(longRange) [" + board.GetAttackPoints(EnumType.longRange) + "]", h0);
                List<Card> car0 = board.PlayerCards[1][EnumType.range];
                string ran0 = "";
                foreach (Card i in car0)
                {
                    CombatCard j = (CombatCard)i;
                    ran0 += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(Range) [" + board.GetAttackPoints(EnumType.range) + "]", ran0);
                List<Card> cardss0 = board.PlayerCards[1][EnumType.melee];
                string me0 = "";
                foreach (Card i in cardss0)
                {
                    CombatCard j = (CombatCard)i;
                    me0 += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(melee) [" + board.GetAttackPoints(EnumType.melee) + "]", me0);

            }
            else
            {
                Console.WriteLine($"Oponente  -  LifePoints {lifePoints[1]}   -  AttackPoints{attackPoints[1]}");
                List<Card> cards = board.PlayerCards[1][EnumType.longRange];
                string h = "";
                foreach (Card i in cards)
                {
                    CombatCard j = (CombatCard)i;
                    h += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(longRange) [" + board.GetAttackPoints(EnumType.longRange) + "]", h);
                List<Card> car = board.PlayerCards[1][EnumType.range];
                string ran = "";
                foreach (Card i in car)
                {
                    CombatCard j = (CombatCard)i;
                    ran += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(Range) [" + board.GetAttackPoints(EnumType.range) + "]", ran);
                List<Card> cardss = board.PlayerCards[1][EnumType.melee];
                string me = "";
                foreach (Card i in cardss)
                {
                    CombatCard j = (CombatCard)i;
                    me += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(melee) [" + board.GetAttackPoints(EnumType.melee) + "]", me);

                List<SpecialCard> mm = board.WeatherCards;

                Console.WriteLine($"You  -  LifePoints {lifePoints[0]}   -  AttackPoints{attackPoints[0]}");
                List<Card> cards0 = board.PlayerCards[0][EnumType.longRange];
                string h0 = "";
                foreach (Card i in cards0)
                {
                    CombatCard j = (CombatCard)i;
                    h0 += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(longRange) [" + board.GetAttackPoints(EnumType.longRange) + "]", h0);
                List<Card> car0 = board.PlayerCards[0][EnumType.range];
                string ran0 = "";
                foreach (Card i in car0)
                {
                    CombatCard j = (CombatCard)i;
                    ran0 += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(Range) [" + board.GetAttackPoints(EnumType.range) + "]", ran0);
                List<Card> cardss0 = board.PlayerCards[0][EnumType.melee];
                string me0 = "";
                foreach (Card i in cardss0)
                {
                    CombatCard j = (CombatCard)i;
                    me0 += $"|{j.AttackPoints}| ";
                }
                Console.WriteLine($"(melee) [" + board.GetAttackPoints(EnumType.melee) + "]", me0);

            }

        }
        public static void ShowHand(Hand hand)
        {
            CombatCard combatCard;
            Console.WriteLine("Hand: ");
            for (int i = 0; i<hand.Cards.Count; i++)
            {
                if (hand.Cards[i] is CombatCard)
                {
                    combatCard = hand.Cards[i] as CombatCard;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"|({i}) {combatCard.Name} ({combatCard.Type}): {combatCard.AttackPoints} |");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"|({i}) {hand.Cards[i].Name} ({hand.Cards[i].Type}) |");
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }
        public static void ShowDecks(List<Deck> decks)
        {
            Console.WriteLine("Select one Deck:");
            for (int i = 0; i<decks.Count; i++)
            {
                Console.WriteLine($"({i}) Deck {i+1}");
            }
        }
        public static void ShowCaptains(List<SpecialCard> captains)
        {
            Console.WriteLine("Select one captain:");
            for (int i = 0; i < captains.Count; i++)
            {
                Console.WriteLine($"({i}) {captains[i].Name}: {captains[i].Effect}");
            }
        }
        public static int GetUserInput(int maxInput, bool stopper = false)
        {
            bool valid = false;
            int value;
            int minInput = stopper ? -1 : 0;
            while (!valid)
            {

                if (int.TryParse(Console.ReadLine(), out value))
                {
                    if (value >= minInput && value <= maxInput)
                    {
                        return value;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine($"The option ({value}) is not valid, try again");
                        Console.ResetColor();
                    }
                }
                else
                {
                    ConsoleError($"Input must be a number, try again");
                }
            }
            return -1;
        }
        public static void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ShowProgramMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ShowListOptions (List<string> options, string message = null)
        {
            if (message != null) Console.WriteLine($"{message}");
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"({i}) {options[i]}");
            }
        }
        public static void ClearConsole()
        {
            Console.ResetColor();
            Console.Clear();
        }

    }
    
}
