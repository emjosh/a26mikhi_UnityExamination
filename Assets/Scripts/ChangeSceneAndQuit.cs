using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneAndquit : MonoBehaviour

// Write "Quit" in the string prompt when accessing the method in order to quit the application
// Otherwise simply write the name of the scene you wish to switch to


{
    public void ChangeScene(string sceneName)
    {
        if (sceneName == "Quit")
        {
            Debug.Log("Quitting game");
            Application.Quit();
        }
        else
        {
            Debug.Log("Loading scene: " + sceneName);
            SceneManager.LoadScene(sceneName);
        }
    }
}
