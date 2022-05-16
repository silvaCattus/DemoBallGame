using UnityEngine;

[RequireComponent(typeof(PlayerInput))]

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    private Gravity _gravity;
    private bool _needChangeGravity;

    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _gravity = Gravity.Normal;
        Physics.gravity = new Vector3(Physics.gravity.x, Physics.gravity.y, Physics.gravity.y * (int)_gravity);
    }

    private void Update()
    {
        if (_playerInput.CheckTouching())
            _needChangeGravity = true;
    }

    private void FixedUpdate()
    {
        if(_needChangeGravity)
            ChangeGravity();
    }

    private void ChangeGravity()
    {
        if (_gravity == Gravity.Normal)
            _gravity = Gravity.Reverse;
        else
            _gravity = Gravity.Normal;

        Physics.gravity = new Vector3(Physics.gravity.x, Physics.gravity.y, Physics.gravity.y * (int)_gravity);
         
        _needChangeGravity = false;
    }
}
