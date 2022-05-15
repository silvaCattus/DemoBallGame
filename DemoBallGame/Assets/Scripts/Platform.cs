using UnityEngine;

public class Platform : MonoBehaviour
{
    private float _speed;
    private bool _needGo;

    public void SetSpeed(float speed)
    {
        _speed = speed;
        _needGo = true;
    }

    private void FixedUpdate()
    {
        if(_needGo)
            Move();
    }

    private void Move()
    {
        transform.position = new Vector3(_speed, 0, 0);
    }
}
