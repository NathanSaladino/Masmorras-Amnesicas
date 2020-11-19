using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BGMovement : MonoBehaviour
{

    private BoxCollider2D boxCollider;

    private Rigidbody2D rb;

    private float width;

    private float speed = -50f;
    // Start is called before the first frame update
    void Start()
    {

        boxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = boxCollider.size.x + 585;
        rb.velocity = new Vector2(speed, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -width)
        {
            Reposition();
        }
    }

    private void Reposition()
    {
        Vector2 vector = new Vector2(width * 4f - 17, 0);
        transform.position = (Vector2)transform.position + vector;
    }
}
