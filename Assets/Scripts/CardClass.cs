using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/CardObject")]
public class CardClass: ScriptableObject
{
    public string suit;
    public string value;
    public Sprite sprite;
}
