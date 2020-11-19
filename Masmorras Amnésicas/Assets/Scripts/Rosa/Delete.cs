using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    bool MouseInObject;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        MouseInObject = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(MouseInObject == true)
        {
            if (Input.GetMouseButtonDown(0) && GetComponent<SpriteRenderer>().enabled == true)
            {
                audioSource.Play();
                GetComponent<SpriteRenderer>().enabled = false;
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }

    void OnMouseEnter()
    {
        MouseInObject = true;
    }
}
