using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool CheckTouching()
    {
        if (Input.touchCount > 0)
        {
            return true;
        }
        return false;
    }
}
