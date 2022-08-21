using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dailogTrigger : MonoBehaviour
{
    public Dailogue dailogue;
    // Start is called before the first frame update
    public void TriggerDailog()
    {
        FindObjectOfType<dailogManager>().StartDailog(dailogue);   
    }
}
