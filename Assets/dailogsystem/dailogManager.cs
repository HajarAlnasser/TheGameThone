using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dailogManager : MonoBehaviour
{
    
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI sentencesText;
    private Queue<string> ssentences;
    // Start is called before the first frame update
    void Start()
    {
        ssentences = new Queue<string>();
    }

    // Update is called once per frame
   public void StartDailog(Dailogue dialogue)
    {
        Debug.Log("Starting new conversation with"+dialogue.name);
        nameText.text = dialogue.name;
        ssentences.Clear();
       foreach(string sentences in dialogue.sentences)
        {
            ssentences.Enqueue(sentences);
        }
        DisplayNextSentences();
    }
    public void DisplayNextSentences()
    {
        if(ssentences.Count==0)
        {
            EndDailogue();
            return;

        }
        string sentences = ssentences.Dequeue();
        Debug.Log(sentences);
        sentencesText.text = sentences;
    }

    private void EndDailogue()
    {
        Debug.Log("end of the conversation");
    }
}
