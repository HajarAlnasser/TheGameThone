using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class timer : MonoBehaviour
{
    [SerializeField] GameObject losePanel;
    public TMP_Text t;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timerEnd());

    }

    IEnumerator timerEnd()
    {
        for (int i = 60; i > 1; i--)
        {

            yield return new WaitForSeconds(1);

            //  textmeshPro.SetText(i.ToString());
            t.text = i.ToString();
        }

        losePanel.SetActive(true);
        yield return new WaitForSeconds(4);

        SceneManager.LoadScene("MainMenu");

    }

    public void des()
    {
        Destroy(gameObject);
    }



}
