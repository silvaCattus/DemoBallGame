using UnityEngine;

public class PlatformRemover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Platform>())
            Destroy(other.gameObject);
    }
}
