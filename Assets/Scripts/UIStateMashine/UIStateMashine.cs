using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;
using UnityEngine.Timeline;

public class UIStateMashine : MonoBehaviour
{
    [SerializeField]
    public GameObject mainMenu;
    [SerializeField]
    public GameObject settings;
    [SerializeField]
    public GameObject gameMenu;
    [SerializeField]
    public GameObject gameUI;

    private void Awake()
    {
        ChangeCurrentStateToMainMenu();
    }

    public void ChangeCurrentStateToMainMenu()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
        gameMenu.SetActive(false);
        gameUI.SetActive(false);
    }

    public void ChangeCurrentStateToSettings()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
        gameMenu.SetActive(false);
        gameUI.SetActive(false);
    }

    public void ChangeCurrentStateToGameMenu()
    {
        mainMenu.SetActive(false);
        settings.SetActive(false);
        gameMenu.SetActive(true);
        gameUI.SetActive(false);
    }

    public void ChangeCurrentStateToGameUI()
    {
        mainMenu.SetActive(false);
        settings.SetActive(false);
        gameMenu.SetActive(false);
        gameUI.SetActive(true);
    }
}
