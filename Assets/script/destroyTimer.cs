using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTimer : MonoBehaviour
{
    public
        GameObject t;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(t.gameObject);
            this.gameObject.GetComponent<destroyTimer>().enabled = false;
        }
    }


}
