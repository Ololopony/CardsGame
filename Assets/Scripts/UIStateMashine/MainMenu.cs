using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject mainUI;

    public void EnterState()
    {
        mainUI.SetActive(true);
    }
    public void UpdateState()
    {
        
    }
    public void ExitState()
    {
        mainUI.SetActive(false);
    }
}
