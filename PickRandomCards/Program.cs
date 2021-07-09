﻿using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the number of cards to pick:, x to exit: ");
                string line = Console.ReadLine();
                if (line == "x")
                    { break;
                    }
                if (int.TryParse(line, out int numberOfCards))
                {
                    foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                    {
                        Console.WriteLine(card);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
    }

}
