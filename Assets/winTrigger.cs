using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject winPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            winPanel.SetActive(true);
            StartCoroutine("back");

        }
    }

    IEnumerator back()
    {
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("MainMenu");


    }

}
