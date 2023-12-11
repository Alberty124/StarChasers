using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningArea : MonoBehaviour
{
    public string nextLevel = "NextLevelScene";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player reached the winning area!");
            Invoke("LoadNextScene", 2f); // Change the delay time as needed
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextLevel);
    }
}