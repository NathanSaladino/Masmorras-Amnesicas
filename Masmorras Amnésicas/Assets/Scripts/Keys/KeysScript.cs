using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysScript : MonoBehaviour
{
    bool MouseInObject;
    public bool Silver, Pink, Blue, Yellow, Green;
    public ButtonsScript bS;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        MouseInObject = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (MouseInObject == true)
        {
            if (Input.GetMouseButtonDown(0) && GetComponent<SpriteRenderer>().enabled == true)
            {
                if (Silver == true)
                    bS.silverkey = true;
                if (Pink == true)
                    bS.pinkkey = true;
                if (Blue== true)
                    bS.bluekey = true;
                if (Yellow == true)
                    bS.yellowkey = true;
                if (Green == true)
                    bS.greenkey = true;
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
