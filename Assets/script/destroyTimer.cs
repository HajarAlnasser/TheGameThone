using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTimer : MonoBehaviour
{
    [SerializeField] GameObject timeer;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            timeer.GetComponent<timer>().des();
            this.gameObject.GetComponent<destroyTimer>().enabled = false;

        }
    }
}
