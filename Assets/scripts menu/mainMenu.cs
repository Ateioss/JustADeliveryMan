using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void clickForPlay() {
        SceneManager.LoadScene("test");
    }

    public void quitGame() {
        Debug.Log("QUIT");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

