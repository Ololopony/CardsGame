using System.Runtime.CompilerServices;
using UnityEngine;

public class GameStateMachineManager : MonoBehaviour
{
    BaseGameState currnetState;
    public CardsTakingState cardsTakingState = new CardsTakingState();
    public CardsShufflingState cardsShufflingState = new CardsShufflingState();
    public PlayerTurnState playerTurnState = new PlayerTurnState();
    public EnemyTurnState enemyTurnState = new EnemyTurnState();
    public MenuState menuState = new MenuState();
    public SettingsState settingsState = new SettingsState();

    private void Start()
    {
        currnetState = menuState;
        currnetState.EnterState(this);
    }

    private void Update()
    {
        currnetState.UpdateState(this);
    }

    public void SwitchState(BaseGameState state)
    {
        currnetState = state;
        state.EnterState(this);
    }
}
