using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [HideInInspector]
    private Rigidbody2D rb;
    private float limitDerecha;
    private float limitIzquierda;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        limitDerecha = UIManager.instance.limitDerecha;
        limitIzquierda = UIManager.instance.limitIzquierda;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && transform.position.x > limitIzquierda)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            rb.velocity = new Vector2(-2, 0);
        }
        else if (Input.GetKey(KeyCode.D) && transform.position.x < limitDerecha)
        {
            rb.velocity = new Vector2(2, 0);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else rb.velocity = Vector2.zero;
    }
}