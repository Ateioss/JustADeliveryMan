using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public string sceneName; // Le nom de la scène vers laquelle on veut changer

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Vérifie que le collider en contact est celui du joueur
        {
            SceneManager.LoadScene(sceneName); // Charge la scène spécifiée
        }
    }
}
