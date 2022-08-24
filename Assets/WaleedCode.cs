using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaleedCode : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("LoadingScreen");

        Debug.Log("Loading in 8 seconds");

        StartCoroutine(StartDelay());
    }

    IEnumerator StartDelay()
    {
        Debug.Log("Coroutine Loaded");

        yield return new WaitForSeconds(8f);

        Debug.Log("Loaded");

        SceneManager.LoadScene("waleed end");
        //FindObjectOfType<AudioManager>().Play("Ambiente");
        //Health.ResetLife();

    }
}
