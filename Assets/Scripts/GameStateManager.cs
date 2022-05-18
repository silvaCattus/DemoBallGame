using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    [SerializeField] private GameObject _pauseCanvas;
    [SerializeField] private GameObject _gameUICanvas;
    [SerializeField] private GameObject _reloadCanvas;
    [SerializeField] private GameObject _notStartedCanvas;
    //public GameState State { get; private set; }

    void Start()
    {
        //State = GameState.NotStarted;
    }

    public void SetGameOnState()
    {
        //if (State == GameState.NotStarted)
        //{
        //    _notStartedCanvas.SetActive(false);
        //}
        //else if (State == GameState.Pause)
        //{
        //    _pauseCanvas.SetActive(false);
        //}

        //State = GameState.GameOn;
        //Time.timeScale = 1;
    }

    public void SetPauseState()
    {
        //_pauseCanvas.SetActive(true);
        //State = GameState.Pause;
        //Time.timeScale = 0;
    }

    public void SetReloadMenuOpen()
    {
        //_reloadCanvas.SetActive(true);
        //State = GameState.Pause;
        //Time.timeScale = 0;
    }
}
