using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerManager : MonoBehaviour
{
    public GameObject mome, dad, frind1, frind2, teacher;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "mome")
        {
            mome.SetActive(true);
        }
        if (other.gameObject.tag == "dad")
        {
            dad.SetActive(true);
        }
        if (other.gameObject.tag == "frind1")
        {
            frind1.SetActive(true);
        }
        if (other.gameObject.tag == "teacher")
        {
            frind2.SetActive(true);
        }
       /* if (other.gameObject.tag == "teacher")
        {
            teacher.SetActive(true);
        }*/
    }

}
