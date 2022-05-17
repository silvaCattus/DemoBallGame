using UnityEngine;

[RequireComponent(typeof(PlayerInput))]

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _playerInput;
    private Gravity _gravity;
    private bool _needChangeGravity;

    private float _xPos;
    private float _yPos;

    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _gravity = Gravity.Normal;
        Physics.gravity = new Vector3(Physics.gravity.x, Physics.gravity.y, Physics.gravity.y * (int)_gravity);

        _xPos = transform.position.x;
        _yPos = transform.position.y;
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

    private void LateUpdate()
    {
        transform.position = new Vector3(_xPos, _yPos, transform.position.z);
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
