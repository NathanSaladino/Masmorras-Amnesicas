using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public void PlayGame()
    {
       StartCoroutine(LoadLevel(7));
    }

    public void Credits()
    {
        StartCoroutine(LoadLevel(2));
    }

    public void HowToPlay()
    {
        StartCoroutine(LoadLevel(1));
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
 