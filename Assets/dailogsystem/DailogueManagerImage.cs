using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailogueManagerImage : MonoBehaviour
{
    public Image nameText;
    public Image sentencesText;
    private Queue<Sprite> ssentencesImage;
    // Start is called before the first frame update
    void Start()
    {
        ssentencesImage = new Queue<Sprite>();
    }

    // Update is called once per frame
    public void StartDailog(DailogImage dailogueImage)
    {
        //Debug.Log("Starting new conversation with" + dailogueImage.sprite);
       nameText.sprite= dailogueImage.nameImage;
        ssentencesImage.Clear();
        foreach (Sprite sentencesImmage in dailogueImage.sentencesImmage)
        {
            ssentencesImage.Enqueue(sentencesImmage);
        }
        DisplayNextSentences();
    }
    public void DisplayNextSentences()
    {
        if (ssentencesImage.Count == 0)
        {
            EndDailogue();
            return;

        }
        Sprite sentencesImmage = ssentencesImage.Dequeue();
       // Debug.Log(sentencesImmage);
        sentencesText.sprite = sentencesImmage;
    }

    private void EndDailogue()
    {
        Debug.Log("end of the conversation");
    }
}
