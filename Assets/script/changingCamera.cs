using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class changingCamera : MonoBehaviour
{

    [SerializeField] private GameObject playerNewPos, player, fade, fadeToNewScene;
   
    [SerializeField] private CinemachineVirtualCamera oldCam, newCam;

    [SerializeField] string sceneName;
    private Animator anim;

    [SerializeField] private bool newScene = false;
    // Start is called before the first frame update

    private void Start()
    {
        anim = fade.GetComponent<Animator>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.enabled = true;
            StartCoroutine(fadeAnimation());
                

          
        }
    }



    IEnumerator fadeAnimation()
    {

        if (newScene)
        {
            fadeToNewScene.SetActive(true);

            fadeToNewScene.SetActive(true);
            yield return new WaitForSeconds(1);
            print("new scene");
            //SceneManager.LoadScene(sceneName);



        }
        else
        {

            fade.SetActive(true);


            player.GetComponent<PlayerMove>().stopAnimation(); ;

            player.GetComponent<PlayerMove>().enabled = false;

            yield return new WaitForSeconds(0.4f);
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = playerNewPos.transform.position;
            player.transform.localRotation = playerNewPos.transform.localRotation;
            player.GetComponent<CharacterController>().enabled = true;


            newCam.gameObject.SetActive(true);

            oldCam.gameObject.SetActive(false);


            yield return new WaitForSeconds(0.5f);
            player.GetComponent<PlayerMove>().enabled = true;

            yield return new WaitForSeconds(0.4f);


            anim.enabled = true;
            fade.SetActive(false); 
        }




    }



}
