using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    [SerializeField] private Transition[] _transitions;

    public virtual State GetNext()
    {
        foreach (var transition in _transitions)
        {
            if (transition.NeedTransit)
                return transition.TargetState;
        }

        return null;
    }

    public virtual void Exit()
    {
        if (enabled)
        {
            foreach (var transition in _transitions)
            {
                transition.enabled = false;
            }

            enabled = false;
        }
    }

    public virtual void Enter()
    {
        if (!enabled)
        {
            enabled = true;
            foreach (var transition in _transitions)
            {
                transition.enabled = true;
            }
        }
    }

    protected virtual void FixedUpdate()
    {
    }
}
