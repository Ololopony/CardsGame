using UnityEngine;

public class GameController : MonoBehaviour
{
    public GenerateDeck generator;
    private string strongestSuit;

    private void Start()
    {
        generator.Shuffle();
        strongestSuit = generator.GetRandomSuit();
    }
}
