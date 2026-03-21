using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadCredits()
    {
        Time.timeScale = 1f; // important if game was paused
        SceneManager.LoadScene("Credits");
    }
}