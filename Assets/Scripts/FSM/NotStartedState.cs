using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotStartedState : State
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
