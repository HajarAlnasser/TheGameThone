using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Ttimer : MonoBehaviour
{
    public TMP_Text t;
    public GameObject losePanel;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("tim");
    }

    // Update is called once per frame


    IEnumerator tim()
    {
        for (int i = 60; i > 1; i--)
        {
            yield return new WaitForSeconds(1);
            t.text = i.ToString();
        }

        losePanel.SetActive(true);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("MainMenu");



    }
}
