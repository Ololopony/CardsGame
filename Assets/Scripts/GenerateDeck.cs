using System.Collections.Generic;
using System;
using UnityEngine;

public class GenerateDeck : MonoBehaviour
{
    public CardClass[] deck = new CardClass[36];
    public List<CardClass> newDeck = new List<CardClass>();

    public void Shuffle()
    {
        System.Random random = new System.Random();

        for (int i = 0; i < deck.Length; i++)
        {
            int r = i + random.Next(35 - i);

            newDeck.Add(deck[r]);
        }
    }
    public string GetRandomSuit()
    {
        System.Random random = new System.Random();
        int r = random.Next(4);

        switch (r)
        {
            case 0:
                return "Pick";
            case 1:
                return "Heart";
            case 2:
                return "Diamond";
            case 3:
                return "Clover";
            default:
                return "None";
        }
    }
}
