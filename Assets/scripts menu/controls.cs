using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controls : MonoBehaviour
{
    public float speed = 5f;
    public float jump = 8f;
    private Rigidbody2D rb;

    private bool grounded;
    private Collider2D[] leSol;
    public float centreCercle;
    public float rayonCercle;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && grounded) {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
        checkGround();
    }

    void checkGround() {
        grounded = false;
        leSol = Physics2D.OverlapCircleAll(transform.position + Vector3.up * centreCercle, rayonCercle);
        foreach(Collider2D truc in leSol)
        {
            if (truc.transform != transform)
            {
                grounded = true;
                break;
            }
        }
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position + Vector3.up * centreCercle, rayonCercle);
    }
}
