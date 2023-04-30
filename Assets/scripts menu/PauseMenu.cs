using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public static bool pause = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if (pause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume ()
        {
            PauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            pause=false;
        }
    public void Pause ()
        {
            PauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            pause=true;
        }
    public void LoadMenu(){
            SceneManager.LoadScene("menu");
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
