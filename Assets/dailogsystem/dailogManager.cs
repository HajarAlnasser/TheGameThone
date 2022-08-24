using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dailogManager : MonoBehaviour
{
    
    public Image nameText;
    public Image sentencesText;
    private Queue<Sprite> ssentences;
    // Start is called before the first frame update
    void Start()
    {
        ssentences = new Queue<Sprite>();
    }

    // Update is called once per frame
   public void StartDailog(Dailogue dialogue)
    {
        Debug.Log("Starting new conversation with"+dialogue.name);
        nameText.sprite = dialogue.name;
        ssentences.Clear();
       foreach(Sprite sentences in dialogue.sentences)
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
        Sprite sentences = ssentences.Dequeue();
        //Debug.Log(sentences);
        sentencesText.sprite = sentences;
    }

    private void EndDailogue()
    {
        Debug.Log("end of the conversation");
    }
}
