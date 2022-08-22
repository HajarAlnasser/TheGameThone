using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class changingCamera : MonoBehaviour
{

    [SerializeField] private GameObject playerNewPos, player, fade;
    [SerializeField] private CinemachineVirtualCamera oldCam, newCam;
    private Animator anim;
    // Start is called before the first frame update

    private void Start()
    {
        anim = fade.GetComponent<Animator>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fade.SetActive(true);
            anim.enabled = true;
            StartCoroutine(fadeAnimation());
       

          
        }
    }



    IEnumerator fadeAnimation()
    {
        player.GetComponent<PlayerMove>().stopAnimation(); ;

        player.GetComponent<PlayerMove>().enabled = false;

        yield return new WaitForSeconds(1);
        player.GetComponent<CharacterController>().enabled = false;
        player.transform.position = playerNewPos.transform.position;
        player.GetComponent<CharacterController>().enabled = true;


        newCam.gameObject.SetActive(true);

        oldCam.gameObject.SetActive(false);


        yield return new WaitForSeconds(1);
        player.GetComponent<PlayerMove>().enabled = true;

        yield return new WaitForSeconds(1.3f);


        anim.enabled = true;
        fade.SetActive(false); ;





    }
}
