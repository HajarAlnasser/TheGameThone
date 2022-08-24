using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dailogCollaider : MonoBehaviour
{
    public GameObject dalogue;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            dalogue.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        dalogue.SetActive(false);
    }
}
