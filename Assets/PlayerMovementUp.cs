using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementUp : MonoBehaviour
{
    public float speed = 5f; // la vitesse de déplacement du personnage

    private Rigidbody2D rb; // le rigidbody du personnage

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Obtenez les entrées de l'axe horizontal et vertical
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Créez un vecteur de mouvement à partir des entrées de l'axe horizontal et vertical
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Déplacez le personnage en utilisant le vecteur de mouvement et la vitesse de déplacement
        rb.velocity = movement * speed;
    }
}

