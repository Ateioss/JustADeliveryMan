using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnContact : MonoBehaviour
{
    public string sceneName; // Le nom de la scène vers laquelle on veut changer

    private void OnTriggerEnter(Collider other)
    
    {   Debug.Log("ok");
        if (other.gameObject.CompareTag("Player")) // Vérifie que le collider en contact est celui du joueur
        {
            SceneManager.LoadScene("Houses 1"); // Charge la scène spécifiée
        }
    }
}
