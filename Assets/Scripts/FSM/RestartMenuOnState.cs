using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartMenuOnState : State
{

    private void OnEnable()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        
    }
}
