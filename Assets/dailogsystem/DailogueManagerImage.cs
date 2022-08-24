using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailogueManagerImage : MonoBehaviour
{
    public Image nameText;
    public Image sentencesText;
    public Image exprisionwendow;
    private Queue<Sprite> ssentencesImage;
    private Queue<Sprite> expresionImage;
    public DailogImage dailogueImag;

    // Start is called before the first frame update
    void Start()
    {
        expresionImage = new Queue<Sprite>();
        ssentencesImage = new Queue<Sprite>();
        StartDailog(dailogueImag);
    }

    // Update is called once per frame
    public void StartDailog(DailogImage dailogImage)
    {
        //Debug.Log("Starting new conversation with" + dailogueImage.sprite);
        nameText.sprite = dailogImage.nameImage;
        expresionImage.Clear();
        ssentencesImage.Clear();
        foreach (Sprite sentencesImmage in dailogImage.sentencesImmage)
        {
            ssentencesImage.Enqueue(sentencesImmage);
        }
        DisplayNextSentences();
        foreach (Sprite expresionImages in dailogImage.expresionImages)
        {
            expresionImage.Enqueue(expresionImages);
        }
        DisplayNextSentences();

    }
    public void DisplayNextSentences()
    {
        if (ssentencesImage.Count == 0 || expresionImage.Count == 0)
        {
            EndDailogue();
            return;

        }
        Sprite sentencesImmage = ssentencesImage.Dequeue();
        Sprite expresionImages = expresionImage.Dequeue();
        // Debug.Log(sentencesImmage);
        sentencesText.sprite = sentencesImmage;
        exprisionwendow.sprite = expresionImages;
    }

    private void EndDailogue()
    {
        Debug.Log("end of the conversation");
    }
}