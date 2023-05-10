using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCollisionHandler : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("DoorCollisionHandler script is attached to: " + gameObject.name);
        if (!gameObject.CompareTag("Door"))
        {
            Debug.LogWarning("The GameObject this script is attached to does not have the 'Door' tag.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called with: " + other.gameObject.name);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player tag detected, loading scene 'Houses1'.");
            SceneManager.LoadScene("Houses1");
        }
        else
        {
            Debug.Log("Non-Player object entered trigger: " + other.gameObject.name);
        }
    }
}