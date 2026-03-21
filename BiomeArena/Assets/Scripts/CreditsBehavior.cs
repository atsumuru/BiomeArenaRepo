using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsBehavior : MonoBehaviour
{
    public GameObject winUI;
    public string sceneToLoad = "GameScene"; // set this in Inspector


    public void ShowWinScreen()
    {
        winUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PlayAgain()
    {
        Debug.Log("Play Again!");
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToLoad);
    }

}