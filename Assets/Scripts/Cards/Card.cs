using UnityEngine;

public class Card : MonoBehaviour
{
    public string suit;
    public int value;
    
    private void OnMouseDown()
    {
        Debug.Log("click");
    }
}
