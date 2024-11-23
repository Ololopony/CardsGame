using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.XR.Haptics;
using UnityEngine.Timeline;

public class UIStateMashine : MonoBehaviour
{
    [SerializeField]
    public MainMenu mainMenu;
    [SerializeField]
    public Settings settings;
    [SerializeField]
    public GameMenu gameMenu;
    [SerializeField]
    public GameUi gameUI;

    private void Awake()
    {
        ChangeCurrentStateToMainMenu();
    }

    public void ChangeCurrentStateToMainMenu()
    {
        mainMenu.EnterState();
        settings.ExitState();
        gameMenu.ExitState();
        gameUI.ExitState();
    }

    public void ChangeCurrentStateToSettings()
    {
        mainMenu.ExitState();
        settings.EnterState();
        gameMenu.ExitState();
        gameUI.ExitState();
    }

    public void ChangeCurrentStateToGameMenu()
    {
        mainMenu.ExitState();
        settings.ExitState();
        gameMenu.EnterState();
        gameUI.ExitState();
    }

    public void ChangeCurrentStateToGameUI()
    {
        mainMenu.ExitState();
        settings.ExitState();
        gameMenu.ExitState();
        gameUI.EnterState();
    }
}
