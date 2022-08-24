using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject dailoge;
    public void dailogueDestroy()
    {
        Destroy(dailoge);
    }
}
