using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : State
{
    private void OnEnable()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
