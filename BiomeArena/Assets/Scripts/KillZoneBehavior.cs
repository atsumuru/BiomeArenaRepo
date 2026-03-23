using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZoneBehavior : MonoBehaviour
{
    public GameBehavior GameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<PlayerBehavior>() != null)
        {
            Time.timeScale = 1f; // reset in case game was paused
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}