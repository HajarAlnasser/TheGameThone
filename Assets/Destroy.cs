using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Destroy : MonoBehaviour
{
    public GameObject Button;

    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(Button);
    }

    public GameObject dailoge;
    public void dailogueDestroy()
    {
        Destroy(dailoge);
    }
}
