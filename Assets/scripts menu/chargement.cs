using UnityEngine;
using UnityEngine.SceneManagement;

public class chargement : MonoBehaviour
{
    public string Houses1;

    public void LoadScene()
    {
        SceneManager.LoadScene(Houses1);
    }
}