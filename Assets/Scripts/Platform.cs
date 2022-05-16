using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _needGo;

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
        transform.position = transform.position + new Vector3(-_speed, 0, 0);
    }
}
