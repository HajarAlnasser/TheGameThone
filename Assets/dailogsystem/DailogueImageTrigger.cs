using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailogueImageTrigger : MonoBehaviour
{
    public DailogImage dailogueImage;
    // Start is called before the first frame update
    public void TriggerDailog()
    {
        FindObjectOfType<DailogueManagerImage>().StartDailog(dailogueImage);
    }
}
