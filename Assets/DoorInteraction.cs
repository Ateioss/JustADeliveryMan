using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class DoorInteraction : MonoBehaviour
{
    public string nomDeLaScene;
    public TextMeshProUGUI instructionText;
    public GameObject choicesPanel;
    public Button stayButton;
    public Button leaveButton;

    private bool isPlayerNearDoor = false;

    private void Start()
    {
        choicesPanel.SetActive(false);
        stayButton.onClick.AddListener(Stay);
        leaveButton.onClick.AddListener(Leave);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerNearDoor = true;
            instructionText.text = "Vous êtes devant une porte. Appuyez sur 'U' pour ouvrir.";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerNearDoor = false;
            instructionText.text = "";
        }
    }

    private void Update()
    {
        if (isPlayerNearDoor && Input.GetKeyDown(KeyCode.U))
        {
            instructionText.text = "";
            choicesPanel.SetActive(!choicesPanel.activeSelf);
        }
    }

    private void Stay()
    {
        Debug.Log("Vous restez dans la pièce.");
        choicesPanel.SetActive(false);
    }

    private void Leave()
    {
        Debug.Log("Vous sortez de la pièce.");
        choicesPanel.SetActive(false);
        SceneManager.LoadScene(nomDeLaScene);
    }
}