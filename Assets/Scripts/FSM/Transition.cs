using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    [SerializeField] private State _targetState;

    public State TargetState { get => _targetState; }

    public bool NeedTransit { get; protected set; }

    protected void SetNeedTransition()
    {
        NeedTransit = true;
    }

    private void OnDisable()
    {
        NeedTransit = false;
    }
}
