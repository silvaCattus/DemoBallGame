using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    [SerializeField] private GameStateManager _stateManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            _stateManager.SetReloadMenuOpen();
        }
    }
}
