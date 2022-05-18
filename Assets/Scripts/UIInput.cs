using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInput : MonoBehaviour
{
    [SerializeField] private GameStateManager _stateManager;

    public void PauseOnClick()
    {
        _stateManager.SetPauseState();
    }

    public void ContinueOnClick()
    {
        _stateManager.SetGameOnState();
    }


    public void ReloadOnClick()
    {
        _stateManager.SetPauseState();
    }

    public void RestartOnClick()
    {
        _stateManager.SetPauseState();
    }

    public void StartOnClick()
    {
        _stateManager.SetGameOnState();
    }

}
