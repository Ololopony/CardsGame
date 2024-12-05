using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GenerateDeck generator;
    private string strongestSuit;
    private List<Card> cardHand = new List<Card>();
    private List<Card> cardHandEnemy = new List<Card>();

    private void Start()
    {
        generator.Shuffle();
        strongestSuit = generator.GetRandomSuit();
    }
    private void Update()
    {
        
    }
    private void FillHands()
    {
        for (int i = 0; i < 6; i++)
        {
            cardHand.Add(generator.newDeck[i]);
        }
        for (int  j = 6; j < 12; j++)
        {
            cardHandEnemy.Add(generator.newDeck[j]);
        }
        for (int k = 0; k < 12; k++)
        {
            generator.newDeck.RemoveAt(k);
        }
    }
}
