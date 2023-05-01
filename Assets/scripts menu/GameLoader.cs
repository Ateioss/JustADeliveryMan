using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameLoader : MonoBehaviour
{
    
    
    public Animator transisition;
    public float transitionTime = 1f;
    
    void Update()
    {
      if(Input.GetMouseButtonDown(0)) 
      {
        LoadNextLevel();
        
      } 
    }

    public void LoadNextLevel() 
    {   
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
        
        
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transisition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
