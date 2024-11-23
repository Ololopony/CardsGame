using UnityEngine;

public abstract class BaseGameState
{
    public abstract void EnterState(GameStateMachineManager gameStateManager);
    public abstract void UpdateState(GameStateMachineManager gameStateManager);
}
