using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonsScript : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public bool greenkey;
    public bool pinkkey;
    public bool silverkey;
    public bool yellowkey;
    public bool bluekey;

    public void MainMenu()
    {
        StartCoroutine(LoadLevel(0));
    }

    public void Porta()
    {
        if(bluekey == true)
        StartCoroutine(LoadLevel(3));
    }

    public void RosaDosVentos()
    {
        if(silverkey == true)
            StartCoroutine(LoadLevel(4));
    }

    public void Relogio()
    {
        if(greenkey == true)
        StartCoroutine(LoadLevel(5));
    }

    public void Cadeado()
    {
        if(pinkkey == true)
        StartCoroutine(LoadLevel(6));
    }

    public void Escadas()
    {
        StartCoroutine(LoadLevel(7));
    }

    public void Victory()
    {
        if(yellowkey == true)
        {
            StartCoroutine(LoadLevel(8));
        }
    }


    IEnumerator LoadLevel(int levelIndex)
    {
        //Play animation Fade Start
        transition.SetTrigger("Start");

        //Wait second
        yield return new WaitForSeconds(transitionTime);

        //Play animation Fade End
        SceneManager.LoadScene(levelIndex);
    }
}
