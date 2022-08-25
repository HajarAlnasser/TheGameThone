using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOcINMA : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            StartCoroutine("d");

    }


    IEnumerator d()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("waleed-Cinema");


    }

}
