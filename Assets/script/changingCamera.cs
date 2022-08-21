using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class changingCamera : MonoBehaviour
{

    [SerializeField] private GameObject playerNewPos, player;
    [SerializeField] private CinemachineVirtualCamera oldCam, newCam;
    bool isMoved = false;
    // Start is called before the first frame update

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isMoved = true;
            player.GetComponent<CharacterController>().enabled=false;
            player.transform.position = playerNewPos.transform.position;
            player.GetComponent<CharacterController>().enabled=true;


            newCam.gameObject.SetActive(true);
            newCam.Priority = 10;

            oldCam.Priority = 9;
            oldCam.gameObject.SetActive(false);

          
        }
    }


}
